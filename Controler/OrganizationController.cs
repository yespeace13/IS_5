using IS_5.Model;
using IS_5.Service;
using System;
using System.Collections.Generic;
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

        public Dictionary<int, string[]> ShowOrganizations()
        {
             return _service.GetOrganizations();
        }
    }
}
