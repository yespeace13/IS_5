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

        public Dictionary<int, Organization> GetOrganizations(int sizePages, int page, User user, out int maxPage)
        {
            if(user.Privilege.Organizations.Item1 == Restrictions.Organizations) 
            {
                var orgs = TestData.Organizations
                    .Where(org => org.Value.NameOrg == user.Organization.NameOrg)
                    .ToDictionary(org => org.Key, org=> org.Value);

                maxPage = (int)Math.Ceiling((double)orgs.Count / sizePages); ;
                return orgs.Skip(sizePages * (page - 1)).Take(sizePages).ToDictionary(org => org.Key, org => org.Value);
            }
            //else if (user.Privilege.Organizations.Item1 == Restrictions.Locality)
            //{
            //    var orgs = TestData.Organizations
            //        .Where(org => org.Value.NameOrg == user.Organization.NameOrg)
            //        .ToDictionary(org => org.Key, org=> org.Value);

            //    maxPage = (int)Math.Ceiling((double)orgs.Count / sizePages); ;
            //    return orgs.Skip(sizePages * (page - 1)).Take(sizePages).ToDictionary(org => org.Key, org => org.Value);
            //}
            else
            {
                maxPage = (int)Math.Ceiling((double)TestData.Organizations.Count / sizePages); ;
                return TestData.Organizations.Skip(sizePages * (page - 1)).Take(sizePages).ToDictionary(org => org.Key, org => org.Value);
            }
            
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
