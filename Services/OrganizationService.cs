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
        public Dictionary<int, string[]> _mapOrganizations;
        public OrganizationService()
        {
            var organizations = new OrganizationsRepository().GetOrganizations();
            MapOrganizations(organizations);
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

        public Dictionary<int, string[]> GetOrganizations()
        {
            return _mapOrganizations;
        }
    }
}
