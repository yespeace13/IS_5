using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.Service
{
    public class OrganizationService
    {
        private Dictionary<int, string[]> _mapOrganizations;
        private OrganizationsRepository _organizationsRepository;
        public OrganizationService()
        {
            _organizationsRepository = new OrganizationsRepository();
            
        }

        private void MapOrganizations(Dictionary<int, Organization> organizations)
        {
            _mapOrganizations = new Dictionary<int, string[]>();
            foreach (var org in organizations)
            {
                (int id, Organization organization) = (org.Key, org.Value);
                _mapOrganizations.Add
                    (
                        id,
                        new string[] {
                            organization.NameOrg,
                            organization.TaxIdenNum,
                            organization.KPP,
                            organization.Address,
                            organization.TypeOrganization.Name,
                            organization.TypeOwnerOrganization.Name
                        }
                    );
            };
        }

        public Dictionary<int, string[]> GetOrganizations(int sizePages, int page)
        {
            var organizations = _organizationsRepository.GetOrganizations(sizePages, page);
            MapOrganizations(organizations);
            return _mapOrganizations;
        }
        public string[] GetTypeOrganizations()
        {
            var organizations = _organizationsRepository.GetTypeOrganizations();
            return MapTypeOrganizations(organizations); ;
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
            _organizationsRepository.AddOrganizationToRepository(nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg);
        }
    }
}
