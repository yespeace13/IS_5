using IS_5.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IS_5.Service
{
    public class OrganizationService
    {
        private OrganizationsRepository _organizationsRepository;
        public OrganizationService()
        {
            _organizationsRepository = new OrganizationsRepository();
        }

        private List<string[]> MapOrganizations(List<Organization> organizations)
        {
            var mapedOrganizations = new List<string[]>();
            foreach (var org in organizations)
            {
                mapedOrganizations.Add
                    (
                        new string[] {
                            org.Id.ToString(),
                            org.NameOrg,
                            org.TaxIdenNum,
                            org.KPP,
                            org.Address,
                            org.TypeOrganization.Name,
                            org.TypeOwnerOrganization.Name,
                            org.Locality.Name
                        }
                    );
            };
            return mapedOrganizations;
        }

        public List<string[]> GetOrganizations(int sizePages, int page, Dictionary<string, string> filters,
            (string, SortOrder) sortCol, out int maxPage)
        {
            //проверка привилегий
            IEnumerable<Organization> orgs;
            if (UserSession.User.Privilege.Organizations.Item1 == Restrictions.Organizations)
                orgs = _organizationsRepository.GetOrganizations()
                    .Where(org => org.NameOrg == UserSession.User.Organization.NameOrg);
            else if (UserSession.User.Privilege.Organizations.Item1 == Restrictions.Locality)
                orgs = _organizationsRepository.GetOrganizations()
                    .Where(org => org.Locality.Name == UserSession.User.Locality.Name);
            else
                orgs = _organizationsRepository.GetOrganizations();
            //проверка на тип организации
            if(UserSession.User.Privilege.Organizations.Item3 != null)
                orgs = orgs.Where(o => UserSession.User.Privilege.Organizations.Item3.Contains(o.TypeOrganization.Id));
            //фильтрация
            var res = FilterOrganizations(orgs, filters);
            //сортировка
            var result = OrderResult(res, sortCol)
                .ToList();
            //вычисление количества страниц
            maxPage = (int)Math.Ceiling((double)result.Count / sizePages);
            //результат только для необходимой страницы
            return MapOrganizations(result
                .Skip(sizePages * (page - 1))
                .Take(sizePages)
                .ToList());
        }

        private IEnumerable<Organization> FilterOrganizations(IEnumerable<Organization> orgs, Dictionary<string, string> filters)
        {
            if (filters["Id"] != "")
            {
                int.TryParse(filters["Id"], out int id);
                orgs = orgs.Where(o => o.Id == id);
            }
            if (filters["NameOrg"] != "")
                orgs = orgs.Where(o => o.NameOrg.Contains(filters["NameOrg"]));
            if (filters["INN"] != "")
                orgs = orgs.Where(o => o.TaxIdenNum.Contains(filters["INN"]));
            if (filters["KPP"] != "")
                orgs = orgs.Where(o => o.KPP.Contains(filters["KPP"]));
            if (filters["Address"] != "")
                orgs = orgs.Where(o => o.Address.Contains(filters["Address"]));
            if (filters["TypeOrg"] != "")
                orgs = orgs.Where(o => o.TypeOrganization.Name.Contains(filters["TypeOrg"]));
            if (filters["TypeOwnOrg"] != "")
                orgs = orgs.Where(o => o.TypeOwnerOrganization.Name.Contains(filters["TypeOwnOrg"]));
            if (filters["Locality"] != "")
                orgs = orgs.Where(o => o.Locality.Name.Contains(filters["Locality"]));
            return orgs;
                
        }

        private IEnumerable<Organization> OrderResult(
            IEnumerable<Organization> orgs, (string, SortOrder) sortCol)
        {
            IEnumerable<Organization> result;
            switch (sortCol.Item1)
            {
                case "Название":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.NameOrg)
                        : orgs.OrderByDescending(org => org.NameOrg);
                case "ИНН":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.TaxIdenNum)
                        : orgs.OrderByDescending(org => org.TaxIdenNum);
                case "КПП":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.KPP)
                        : orgs.OrderByDescending(org => org.KPP);
                case "Адрес":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.Address)
                        : orgs.OrderByDescending(org => org.Address);
                case "Тип организации":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.TypeOrganization.Name)
                        : orgs.OrderByDescending(org => org.TypeOrganization.Name);
                case "Вид организации":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.TypeOwnerOrganization.Name)
                        : orgs.OrderByDescending(org => org.TypeOwnerOrganization.Name);
                case "Муниципальный район":
                    return result = sortCol.Item2 == SortOrder.Descending ?
                        orgs.OrderBy(org => org.Locality.Name)
                        : orgs.OrderByDescending(org => org.Locality.Name);
                default:
                    return orgs.OrderBy(org => org.Id);
            }
        }

        public string[] GetTypeOrganizations()
        {
            var organizations = _organizationsRepository.GetTypeOrganizations();
            if(UserSession.User.Privilege.Organizations.Item3 != null)
                organizations = organizations
                    .Where(o => UserSession.User.Privilege.Organizations.Item3.Contains(o.Id))
                    .ToList();
            return MapTypeOrganizations(organizations);
        }

        private string[] MapTypeOrganizations(List<TypeOrganization> typeOrganizations)
        {
            return typeOrganizations.Select(org => org.Name).ToArray();
        }

        public string[] GetTypeOwnerOrganizations()
        {
            var typeOwnOrg = _organizationsRepository.GetTypeOwnerOrganizations();
            return MapTypeOwnerOrganizations(typeOwnOrg);
        }

        private string[] MapTypeOwnerOrganizations(List<TypeOwnerOrganization> typeOwnOrg)
        {
            return typeOwnOrg.Select(org => org.Name).ToArray();
        }

        public void CreateOrganization(string nameOrg, string taxIdenNum, 
            string kpp, string address, string typeOrg, string typeOwnOrg, string local)
        {
            var typeOrganizations = _organizationsRepository.GetTypeOrganizations();
            var typeOwnerOrganizations = _organizationsRepository.GetTypeOwnerOrganizations();
            var localitys = _organizationsRepository.GetLocalitys();
            var org = new Organization(
                _organizationsRepository.GetOrganizations().Select(o => o.Id).Max() + 1,
                nameOrg, taxIdenNum, kpp, address,
                typeOrganizations
                    .Where(type => type.Name == typeOrg)
                    .FirstOrDefault(),
                typeOwnerOrganizations
                    .Where(typeOwn => typeOwn.Name == typeOwnOrg)
                    .FirstOrDefault(),
                localitys
                    .Where(l => l.Name == local)
                    .FirstOrDefault()
                );
            _organizationsRepository.AddOrganizationToRepository(org);
        }

        public void UpdateOrganization(
            string id, string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg, string locality)
        {
            var oldId = int.Parse(id);
            var oldOrg = _organizationsRepository.GetOrganization(oldId);
            var typeOrganizations = _organizationsRepository.GetTypeOrganizations();
            var typeOwnerOrganizations = _organizationsRepository.GetTypeOwnerOrganizations();
            var localitys = _organizationsRepository.GetLocalitys();
            oldOrg.NameOrg = nameOrg;
            oldOrg.TaxIdenNum = taxIdenNum;
            oldOrg.KPP = kpp;
            oldOrg.Address = address;
            oldOrg.TypeOrganization = typeOrganizations
                .Where(type => type.Name == typeOrg)
                .FirstOrDefault();
            oldOrg.TypeOwnerOrganization =  typeOwnerOrganizations
                .Where(typeOwn => typeOwn.Name == typeOwnOrg)
                .FirstOrDefault();
            oldOrg.Locality = localitys
                .Where(l => l.Name == locality)
                .FirstOrDefault();
        }

        public void DeleteOrganization(int id)
        {
            _organizationsRepository.DeleteOrganizationFromRepository(id);   
        }

        internal string[] ShowOrganzation(int id)
        {
            return MapOrganization(_organizationsRepository.GetOrganization(id)); 
        }
        
        private string[] MapOrganization(Organization organizations)
        {
            return new string[] {
                            organizations.Id.ToString(),
                            organizations.NameOrg,
                            organizations.TaxIdenNum,
                            organizations.KPP,
                            organizations.Address,
                            organizations.TypeOrganization.Name,
                            organizations.TypeOwnerOrganization.Name,
                            organizations.Locality.Name
                        };
        }

        public string[] GetLocalitys()
        {
            var localitys = _organizationsRepository.GetLocalitys();
            if(UserSession.User.Privilege.Organizations.Item1 == Restrictions.Locality)    
                localitys = localitys
                    .Where(l => l.Name == UserSession.User.Locality.Name)
                    .ToList();
            return MapLocalitys(localitys);
        }

        private string[] MapLocalitys(List<Locality> localitys)
        {
            return localitys.Select(l => l.Name).ToArray();
        }

        public void ExportToExcel(Dictionary<string, string> filtres, string[] columns)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = "Организации";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var orgs = GetOrganizations(int.MaxValue, 1, filtres, (null, SortOrder.None), out int maxPage);
                ExportDataToExcel.Export(columns, saveFileDialog1.FileName, orgs);
            }
        }

        public List<string[]> GetOrganizationsAll()
        {
            return MapOrganizations(_organizationsRepository.GetOrganizations());
        }

        public string[] GetLocalitysAll()
        {
            return MapLocalitys(_organizationsRepository.GetLocalitys());
        }
    }
}
