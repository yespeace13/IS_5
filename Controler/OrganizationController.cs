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

        public List<string[]> ShowOrganizations(
            int sizePages, int page, string[] typeOrg, string[] typeOwnOrg, (string, SortOrder) sortCol, out int maxPage)
        {
             return _service.GetOrganizations(sizePages, page, typeOrg, typeOwnOrg, sortCol, out maxPage);
        }
        public string[] ShowTypesOrganizations()
        {
            return _service.GetTypeOrganizations();
        }

        public string[] ShowTypesOwnerOrganizations()
        {
            return _service.GetTypeOwnerOrganizations();
        }

        public void CreateOrganization(
            string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg, string local)
        {
            _service.CreateOrganization(nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg, local);
        }

        public void UpdateOrganization(
            string id, string nameOrg, string taxIdenNum, string kpp, 
            string address, string typeOrg, string typeOwnOrg, string locality)
        {
            _service.UpdateOrganization(id, nameOrg, taxIdenNum, kpp, address, typeOrg, typeOwnOrg, locality);
        }

        public void DeleteOrganization(int id)
        {
            _service.DeleteOrganization(id);
        }

        public string[] ShowOrganization(int id)
        {
            return _service.ShowOrganzation(id);
        }

        internal string[] ShowLocalitys()
        {
            return _service.Localitys();
        }
    }
}
