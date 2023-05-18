using IS_5.Model;
using IS_5.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.Controler
{
    
    public class OrganizationController
    {
        OrganizationService _service;
        public OrganizationController()
        {
            _service = new OrganizationService();

        }

        public Dictionary<int, string[]> ShowOrganizations(int sizePages, int page)
        {
             return _service.GetOrganizations(sizePages, page);
        }
        public string[] ShowTypeOrganizations()
        {
            return _service.GetTypeOrganizations();
        }

        public string[] ShowTypeOwnerOrganizations()
        {
            return _service.GetTypeOwnerOrganizations();
        }

        public void CreateOrganization(
            string nameOrg, string taxIdenNum, string kpp, string address, string typeOrg, string typeOwnOrg)
        {
            _service.CreateOrganization(nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg);
        }
    }
}
