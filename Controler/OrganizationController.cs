using IS_5.Model;
using IS_5.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.Controler
{
    
    public class OrganizationController
    {
        private OrganizationService _service;
        public OrganizationController()
        {
            _service = new OrganizationService();
        }

        public List<string[]> ShowOrganizations(int sizePages, int page, out int maxPage)
        {
             return _service.GetOrganizations(sizePages, page, out maxPage);
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
            string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg)
        {
            _service.CreateOrganization(nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg);
        }

        public void UpdateOrganization(
            int id, string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg)
        {
            _service.UpdateOrganization(id, nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg);
        }

        public void DeleteOrganization(int id)
        {
            _service.DeleteOrganization(id);
        }
    }
}
