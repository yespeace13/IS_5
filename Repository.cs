using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class OrganizationsRepository
    {
        public Dictionary<int, Organization> _organizations;
        public OrganizationsRepository()
        {
            _organizations = new TestData().Organizations;
        }

        public Dictionary<int, Organization> GetOrganizations()
        {
            return _organizations;
        }
    }
}
