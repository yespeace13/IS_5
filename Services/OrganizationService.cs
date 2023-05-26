using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.Service
{
    public class OrganizationService
    {
        private OrganizationsRepository _organizationsRepository;
        public OrganizationService()
        {
            _organizationsRepository = new OrganizationsRepository();
        }

        private List<string[]> MapOrganizations(Dictionary<int, Organization> organizations)
        {
            var mapedOrganizations = new List<string[]>();
            foreach (var org in organizations)
            {
                (int id, Organization organization) = (org.Key, org.Value);
                mapedOrganizations.Add
                    (
                        new string[] {
                            id.ToString(),
                            organization.NameOrg,
                            organization.TaxIdenNum,
                            organization.KPP,
                            organization.Address,
                            organization.TypeOrganization.Name,
                            organization.TypeOwnerOrganization.Name
                        }
                    );
            };
            return mapedOrganizations;
        }

        public List<string[]> GetOrganizations(int sizePages, int page, string[] typeOrg, string[] typeOwnOrg, 
            (string, SortOrder) sortCol, out int maxPage)
        {
            if (typeOrg == null)
                typeOrg = MapTypeOrganizations(_organizationsRepository.GetTypeOrganizations());
            if (typeOwnOrg == null)
                typeOwnOrg = MapTypeOwnerOrganizations(_organizationsRepository.GetTypeOwnerOrganizations());
            IEnumerable<KeyValuePair<int, Organization>> privilege;
            if (UserSession.User.Privilege.Organizations.Item1 == Restrictions.Organizations)
            {
                privilege = _organizationsRepository.GetOrganizations()
                    .Where(org => org.Value.NameOrg == UserSession.User.Organization.NameOrg);
            }
            else
                privilege = _organizationsRepository.GetOrganizations();
            
            var result = privilege.Join(typeOrg, org => org.Value.TypeOrganization.Name, t => t, (org, t) => org)
                .Join(typeOwnOrg, org => org.Value.TypeOwnerOrganization.Name, t => t, (org, t) => org)
                .ToDictionary(org => org.Key, org => org.Value);
            
            maxPage = (int)Math.Ceiling((double)result.Count / sizePages);
            return MapOrganizations(result
                .Skip(sizePages * (page - 1))
                .Take(sizePages)
                .ToDictionary(org => org.Key, org => org.Value));
        }
        public string[] GetTypeOrganizations()
        {
            var organizations = _organizationsRepository.GetTypeOrganizations();
            return MapTypeOrganizations(organizations);
        }

        private string[] MapTypeOrganizations(Dictionary<int, TypeOrganization> typeOrganizations)
        {
            return typeOrganizations.Select(org => org.Value.Name).ToArray();
        }

        public string[] GetTypeOwnerOrganizations()
        {
            var typeOwnOrg = _organizationsRepository.GetTypeOwnerOrganizations();
            return MapTypeOwnerOrganizations(typeOwnOrg); ;
        }

        private string[] MapTypeOwnerOrganizations(Dictionary<int, TypeOwnerOrganization> typeOwnOrg)
        {
            return typeOwnOrg.Select(org => org.Value.Name).ToArray();
        }

        public void CreateOrganization(string nameOrg, string taxIdenNum, string kpp, string address, string typeOrg, string typeOwnOrg)
        {
            var typeOrganizations = _organizationsRepository.GetTypeOrganizations();
            var typeOwnerOrganizations = _organizationsRepository.GetTypeOwnerOrganizations();
            var org = new Organization(
                nameOrg, taxIdenNum, kpp, address,
                typeOrganizations.Values
                    .Where(type => type.Name == typeOrg)
                    .FirstOrDefault(),
                typeOwnerOrganizations.Values
                    .Where(typeOwn => typeOwn.Name == typeOwnOrg)
                    .FirstOrDefault());
            _organizationsRepository.AddOrganizationToRepository(org);
        }

        public void UpdateOrganization(
            int id, string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg)
        {
            var oldOrg = _organizationsRepository.GetOrganization(id);
            var typeOrganizations = _organizationsRepository.GetTypeOrganizations();
            var typeOwnerOrganizations = _organizationsRepository.GetTypeOwnerOrganizations();
            oldOrg.NameOrg = nameOrg;
            oldOrg.TaxIdenNum = taxIdenNum;
            oldOrg.KPP = kpp;
            oldOrg.Address = address;
            oldOrg.TypeOrganization = typeOrganizations.Values
                .Where(type => type.Name == typeOrg)
                .FirstOrDefault();
            oldOrg.TypeOwnerOrganization =  typeOwnerOrganizations.Values
                .Where(typeOwn => typeOwn.Name == typeOwnOrg)
                .FirstOrDefault();
        }

        public void DeleteOrganization(int id)
        {
            _organizationsRepository.DeleteOrganizationFromRepository(id);   
        }
    }
}
