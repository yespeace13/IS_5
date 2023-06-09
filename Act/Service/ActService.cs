using IS_5.Model;
using IS_5.Service;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public class ActService
    {
        ActRepository _repository;
        public ActService()
        {
            _repository = new ActRepository();
        }

        public List<string[]> GetActs(int sizePages, int page, Dictionary<string, string> filters,
            (string, SortOrder) sortCol, out int maxPage)
        {
            IEnumerable<Act> acts;
            acts = _repository.GetActs();
            //if (UserSession.User.Privilege.Acts.Item1 == Restrictions.Organizations)
            //    acts = new ContractRepository().GetContracts()
            //        .Where(c => c.Client.NameOrg == UserSession.User.Organization.NameOrg ||
            //        c.Executor.NameOrg == UserSession.User.Organization.NameOrg);
            //else if (UserSession.User.Privilege.Contracts.Item1 == Restrictions.Locality)
            //    acts = _contractRepository.GetContracts()
            //        .Where(con => con.Localitysprices
            //        .Where(lp => lp.Locality.Name == UserSession.User.Locality.Name).Count() > 0);
            //else
            //    acts = _contractRepository.GetContracts();
            acts = FilterActs(acts, filters);
            maxPage = (int)Math.Ceiling((double)acts.Count() / sizePages);
            acts = OrderResult(acts, sortCol);
            var res = MapActs(acts.ToList());
            if(sortCol.Item1 == "Contract")
                res = sortCol.Item2 == SortOrder.Descending ?
                        res.OrderBy(a => a[3]).ToList()
                        : res.OrderByDescending(a => a[3]).ToList();
            
            if (filters["Contract"] != "")
                res = res.Where(a => a[3].Contains(filters["Contract"])).ToList();
            
            return res;
        }

        private IEnumerable<Act> OrderResult(IEnumerable<Act> acts, (string, SortOrder) sortCol)
        {
            switch (sortCol.Item1)
            {
                case "Organization":
                    return acts = sortCol.Item2 == SortOrder.Descending ?
                        acts.OrderBy(a => a.Organization.NameOrg)
                        : acts.OrderByDescending(a => a.Organization.NameOrg);
                case "DateOfCapture":
                    return acts = sortCol.Item2 == SortOrder.Descending ?
                        acts.OrderBy(a => a.DateOfCapture)
                        : acts.OrderByDescending(a => a.DateOfCapture);
                default:
                    return acts.OrderBy(org => org.Id);
            }
        }

        private IEnumerable<Act> FilterActs(IEnumerable<Act> acts, Dictionary<string, string> filters)
        {
            if (filters["Id"] != "")
            {
                int.TryParse(filters["Id"], out int id);
                acts = acts.Where(a => a.Id == id);
            }
            if (filters["Organization"] != "")
                acts = acts.Where(a => a.Organization.NameOrg.Contains(filters["Organization"]));
            if (filters["DateOfCapture"] != "")
            {
                var dates = filters["DateOfCapture"].Split(' ');
                acts = acts.Where(a => a.DateOfCapture >= DateTime.Parse(dates[0])
                && a.DateOfCapture <= DateTime.Parse(dates[1]));
            }
            return acts;
        }

        public (string[], List<string>) GetAct(int id)
        {
            var act = _repository.GetActs().Where(a => a.Id == id).FirstOrDefault();
            var docs = new List<string>();
            if (act.Scans != null)
                docs.AddRange(act.Scans.Select(s => s.Path).ToList());
            return (new string[]
            {
                act.Id.ToString(),
                act.Organization.NameOrg,
                act.DateOfCapture.ToShortDateString(),
                new ContractRepository().GetContracts().Where(c => c.Acts.Contains(act)).FirstOrDefault().Number
            }, docs);
        }

        private List<string[]> MapActs(List<Act> acts)
        {
            var mapedActs = new List<string[]>();
            foreach (var act in acts)
            {
                mapedActs.Add(new string[]
                {
                    act.Id.ToString(),
                    act.Organization.NameOrg,
                    act.DateOfCapture.ToShortDateString(),
                    new ContractRepository().GetContracts().Where(c => c.Acts.Contains(act)).FirstOrDefault().Number
            });
            }
            return mapedActs;
        }

        public string[] GetOrganizations()
        {
            var orgs = new OrganizationsRepository()
                .GetOrganizations();
            if (UserSession.User.Organization != null)
                orgs = orgs
                    .Where(o => o.Id == UserSession.User.Organization.Id)
                    .ToList();
            return orgs
                .Select(o => o.NameOrg)
                .ToArray();
        }

        public string[] GetContracts()
        {
            var orgs = new ContractRepository()
                .GetContracts();
            return orgs
                .Select(c => c.Number)
                .ToArray();
        }

        public (string[], List<string>) GetAnimal(int idAct, int idAnimal)
        {
            var act = _repository
                .GetActs()
                .Where(a => a.Id == idAct)
                .FirstOrDefault();
            var animal = act.Animals
                .Where(a => a.Id == idAnimal)
                .FirstOrDefault();
            return (new string[]
            {
                animal.Id.ToString(),
                animal.Category == null ? "" : animal.Category,
                animal.Sex ? "Самка" : "Самец",
                animal.Breed == null ? "" : animal.Breed,
                animal.Size.ToString(),
                animal.Wool == null ? "" : animal.Wool,
                animal.Color == null ? "" : animal.Color,
                animal.Ears == null ? "" : animal.Ears,
                animal.Tail == null ? "" : animal.Tail,
                animal.SpecialSigns == null ? "" : animal.SpecialSigns,
                animal.IdentificationLabel == null ? "" : animal.IdentificationLabel,
                animal.ChipNumber == null ? "" : animal.ChipNumber,
                animal.Locality.Name
            },
            animal.Scans == null ? new List<string>() : animal.Scans.Select(s => s.Path).ToList());
        }

        internal Dictionary<string[], List<string>> GetAnimals(int id)
        {
            var animals = _repository.GetAct(id).Animals;
            return animals
                .ToDictionary(animal => new string[]
                {
                    animal.Id.ToString(),
                    animal.Category == null ? "" : animal.Category,
                    animal.Sex ? "Самка" : "Самец",
                    animal.Breed == null ? "" : animal.Breed,
                    animal.Size.ToString(),
                    animal.Wool == null ? "" : animal.Wool,
                    animal.Color == null ? "" : animal.Color,
                    animal.Ears == null ? "" : animal.Ears,
                    animal.Tail == null ? "" : animal.Tail,
                    animal.SpecialSigns == null ? "" : animal.SpecialSigns,
                    animal.IdentificationLabel == null ? "" : animal.IdentificationLabel,
                    animal.ChipNumber == null ? "" : animal.ChipNumber,
                    animal.Locality.Name,
                }, animal => animal.Scans == null ? new List<string>() : animal.Scans.Select(s => s.Path).ToList());
        }

        public string[] GetLocalitys()
        {
            return new LocalityRepository()
                .GetLocalitys()
                .Select(l => l.Name)
                .ToArray();
        }

        internal void CreateAct(string[] act, List<string> scans, Dictionary<string[], List<string>> animals)
        {
            var acts = _repository.GetActs();
            var actId = 0;
            if (acts.Count != 0)
                actId = _repository.GetActs().Max(a => a.Id);
            Create(++actId, act, scans, animals);
        }

        private void Create(int actId, string[] act, List<string> scans, Dictionary<string[], List<string>> animals)
        {
            var contract = new ContractRepository().GetContracts().Where(c => c.Number == act[0]).FirstOrDefault();
            var actScans = new List<Scan>();
            for (int i = 0; i < scans.Count; i++)
                actScans.Add(new Scan(i + 1, scans[i]));
            var actAnimals = new List<Animal>();
            var id = 1;
            foreach (var animal in animals)
            {
                var animalScans = new List<Scan>();
                for (int i = 0; i < animal.Value.Count; i++)
                    actScans.Add(new Scan(i + 1, scans[i]));
                actAnimals.Add(new Animal(int.Parse(animal.Key[0]), animal.Key[1], animal.Key[2] != "Самец",
                    animal.Key[3], double.Parse(animal.Key[4]), animal.Key[5], animal.Key[6], animal.Key[7],
                    animal.Key[8], animal.Key[9], animal.Key[10], animal.Key[11],
                    new LocalityRepository()
                        .GetLocalitys()
                        .Where(l => l.Name == animal.Key[12])
                        .FirstOrDefault(),
                    animalScans));
            };
            
            var organization = new OrganizationsRepository()
                .GetOrganizations()
                .Where(o => o.NameOrg == act[1])
                .FirstOrDefault();
            var date = DateTime.Parse(act[2]);
            var newAct = new Act(actId, actAnimals, organization, date, actScans);
            contract.Acts.Add(newAct);
            _repository.AddActToRepository(newAct);
        }

        internal void UpdateAct(int id, string[] act, List<string> scans, Dictionary<string[], List<string>> animals)
        {
            _repository.DeleteActFromRepository(id);
            Create(id, act, scans, animals);
        }

        internal void DeleteAct(int id)
        {
            _repository.DeleteActFromRepository(id);
        }

        internal void ExportToExcel(string[] columns, Dictionary<string, string> filters)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = "Акты";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var acts = GetActs(int.MaxValue, 1, filters, (null, SortOrder.None), out int maxPage);
                ExportDataToExcel.Export(columns, saveFileDialog1.FileName, acts);
            }
        }
    }
}
