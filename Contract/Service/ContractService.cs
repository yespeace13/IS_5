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
            return MapContracts(contracts.ToList());
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
            _contractRepository.AddContractToRepository(contract);
        }

        internal void UpdateContract(int id, string number, DateTime dateOfConcl, DateTime dateValid, string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            throw new NotImplementedException();
        }
    }
}
