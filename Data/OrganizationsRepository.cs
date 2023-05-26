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
        public OrganizationsRepository()
        {
        }

        public Dictionary<int, Organization> GetOrganizations()
        {
            return TestData.Organizations;
            
        }
        public Organization GetOrganization(int id)
        {
            return TestData.Organizations[id];
        }
        public Dictionary<int, TypeOrganization> GetTypeOrganizations()
        {
            return TestData.TypeOrganizations;
        }

        public Dictionary<int, TypeOwnerOrganization> GetTypeOwnerOrganizations()
        {
            return TestData.TypeOwnerOrganizations;
        }

        public void AddOrganizationToRepository(Organization organization) 
        {
            var id = TestData.Organizations.Keys.Max();
            TestData.Organizations.Add(++id, organization);
        }

        public void DeleteOrganizationFromRepository(int id)
        {
            TestData.Organizations.Remove(id);
        }
    }
}
