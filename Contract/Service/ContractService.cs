using IS_5.Model;
using IS_5.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public class ContractService
    {
        private ContractRepository _contractRepository;
        public ContractService() 
        {
            _contractRepository = new ContractRepository();
        }

        public List<string[]> GetContracts(int sizePages, int page,
            (string, SortOrder) sortCol, out int maxPage)
        {
            IEnumerable<Contract> contracts;
            if (UserSession.User.Privilege.Contracts.Item1 == Restrictions.Organizations)
                contracts = _contractRepository.GetContracts()
                    .Where(c => c.Client.NameOrg == UserSession.User.Organization.NameOrg ||
                    c.Executor.NameOrg == UserSession.User.Organization.NameOrg);
            else if (UserSession.User.Privilege.Contracts.Item1 == Restrictions.Locality)
                contracts = _contractRepository.GetContracts()
                    .Where(con => con.Localitysprices
                    .Where(lp => lp.Locality.Name == UserSession.User.Locality.Name).Count() > 0);
            else
                contracts = _contractRepository.GetContracts();
            //вычисление количества страниц
            maxPage = (int)Math.Ceiling((double)contracts.Count() / sizePages);
            var result = OrderResult(contracts, sortCol);
            return MapContracts(result.ToList());
        }

        private IEnumerable<Contract> OrderResult(IEnumerable<Contract> contracts, (string, SortOrder) sortCol)
        {
            IEnumerable<Contract> result;
            switch (sortCol.Item1)
            {
                case "Номер":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        contracts.OrderBy(org => org.Number)
                        : contracts.OrderByDescending(org => org.Number);
                case "Дата заключения":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        contracts.OrderBy(org => org.DateOfConclusion)
                        : contracts.OrderByDescending(org => org.DateOfConclusion);
                case "Дата действия":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        contracts.OrderBy(org => org.DateValidation)
                        : contracts.OrderByDescending(org => org.DateValidation);
                case "Исполнитель":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        contracts.OrderBy(org => org.Executor.NameOrg)
                        : contracts.OrderByDescending(org => org.Executor.NameOrg);
                case "Заказчик":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        contracts.OrderBy(org => org.Client.NameOrg)
                        : contracts.OrderByDescending(org => org.Client.NameOrg);
                default:
                    return contracts.OrderBy(org => org.Id);
            }
        }

        public List<string[]> MapContracts(List<Contract> contracts)
        {
            var mapedCon = new List<string[]>();
            foreach (var contract in contracts)
            {
                mapedCon.Add(new string[]
                {
                    contract.Id.ToString(),
                    contract.Number.ToString(),
                    contract.DateOfConclusion.ToShortDateString(),
                    contract.DateValidation.ToShortDateString(),
                    contract.Executor.NameOrg,
                    contract.Client.NameOrg
                });
            }
            return mapedCon;
        }

        public void DeleteContract(int id)
        {
            _contractRepository.DeleteContractFromRepository(id);
        }

        public (string[], List<string[]>, List<string>) GetContract(int id)
        {
            return MapContract(_contractRepository.GetContract(id));
        }

        private (string[], List<string[]>, List<string>) MapContract(Contract contract)
        {
            return (new string[]
            {
                contract.Id.ToString(),
                contract.Number.ToString(),
                contract.DateOfConclusion.ToShortDateString(),
                contract.DateValidation.ToShortDateString(),
                contract.Executor.NameOrg,
                contract.Client.NameOrg
            },
            contract.Localitysprices
                .Select(lp => new string[] { lp.Locality.Name, lp.Price.ToString() })
                .ToList(),
            contract.Scans.Select(s => s.Path).ToList());
        }

        public List<string[]> GetOrganizationsAll()
        {
            return new OrganizationService().GetOrganizationsAll();
        }

        public string[] GetLocalitys()
        {
            return new OrganizationService().GetLocalitysAll();
        }

        public void CreateContract(string number, DateTime dateOfConcl, DateTime dateValid, 
            string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            Contract contract = Create(number, dateOfConcl, dateValid, executor, client, localsprices, scans);
            _contractRepository.AddContractToRepository(contract);
        }

        private Contract Create(string number, DateTime dateOfConcl, DateTime dateValid,
            string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            var orgsRep = new OrganizationsRepository();
            var orgs = orgsRep.GetOrganizations();
            var locs = orgsRep.GetLocalitys();
            var localityPrices = new List<Localityprice>();
            for (int i = 0; i < localsprices.Count; i++)
                localityPrices.Add(new Localityprice(
                    i + 1,
                    locs.Where(l => l.Name == localsprices[i][0]).FirstOrDefault(),
                    decimal.Parse(localsprices[i][1].ToString())));

            var files = new List<ContractFile>();
            if (scans != null)
                for (int i = 0; i < scans.Count; i++)
                    files.Add(new ContractFile(i + 1, scans[i]));
            var id = _contractRepository.GetContracts().Max(c => c.Id);
            var contract = new Contract(
                ++id,
                number, dateOfConcl, dateValid,
                orgs.Where(o => o.NameOrg == executor).FirstOrDefault(),
                orgs.Where(o => o.NameOrg == client).FirstOrDefault(),
                localityPrices, files);
            return contract;
        }

        public void UpdateContract(int id, string number, DateTime dateOfConcl, DateTime dateValid, string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            var oldCon = _contractRepository.GetContract(id);
            var contract = Create(number, dateOfConcl, dateValid, executor, client, localsprices, scans);
            _contractRepository.DeleteContractFromRepository(id);
            contract.Id = id;
            _contractRepository.AddContractToRepository(contract);
        }

        public void ExportToExcel(string[] columns)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = "Контракты";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var contracts = GetContracts(int.MaxValue, 1, (null, SortOrder.None), out int maxPage);
                ExportDataToExcel.Export(columns, saveFileDialog1.FileName, contracts);
            }
        }
    }
}
