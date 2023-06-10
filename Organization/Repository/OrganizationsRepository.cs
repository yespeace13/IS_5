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

        public List<Organization> GetOrganizations()
        {
            return TestData.Organizations;
            
        }
        public Organization GetOrganization(int id)
        {
            return TestData.Organizations.Where(o => o.Id == id).FirstOrDefault();
        }
        public List<TypeOrganization> GetTypeOrganizations()
        {
            return TestData.TypeOrganizations;
        }

        public List<TypeOwnerOrganization> GetTypeOwnerOrganizations()
        {
            return TestData.TypeOwnerOrganizations;
        }
        
        public void AddOrganizationToRepository(Organization organization) 
        {
            TestData.Organizations.Add(organization);
        }

        public void DeleteOrganizationFromRepository(int id)
        {
            TestData.Organizations.Remove(TestData.Organizations.Where(o => o.Id == id).FirstOrDefault());
        }
    }
}
