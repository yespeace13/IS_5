using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class OrganizationsRepository
    {
        public Dictionary<int, Organization> _organizations;
        private TestData _testData;
        public OrganizationsRepository()
        {
            _testData = new TestData();
            _organizations = _testData.Organizations;
        }

        public Dictionary<int, Organization> GetOrganizations(int sizePages, int page)
        {
            return _organizations.Skip(sizePages * (page - 1)).Take(sizePages).ToDictionary(org => org.Key, org => org.Value);
        }

        public Dictionary<int, TypeOrganization> GetTypeOrganizations()
        {
            return _testData.TypeOrganizations;
        }

        public Dictionary<int, TypeOwnerOrganization> GetTypeOwnerOrganizations()
        {
            return _testData.TypeOwnerOrganizations;
        }

        public Organization AddOrganizationToRepository(string nameOrg, string taxIdenNum, string kpp, string address, string typeOrg, string typeOwnOrg) 
        {
            var typeOrganizations = new TestData().TypeOrganizations;
            var typeOwnerOrganizations = new TestData().TypeOwnerOrganizations;
            var org = new Organization(
                nameOrg, taxIdenNum, kpp, address, 
                typeOrganizations.Values.Where(type => type.Name == typeOrg).FirstOrDefault(), 
                typeOwnerOrganizations.Values.Where(typeOwn => typeOwn.Name == typeOwnOrg).FirstOrDefault());
            var id = _organizations.Keys.Max();
            _organizations.Add(++id, org);
            return org;
        }
    }
}
