using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Controler
{
    
    public class OrganizationController
    {
        IOrganizationsView _view;
        IList<Organization> organizations;
        Organization organization;

        public OrganizationController(IOrganizationsView view, 
            List<Organization> organizations)
        {
            _view = view;
            this.organizations = organizations;
            //this.organization = organization;
            view.SetController(this);
        }

        public void LoadView()
        {
            _view.ClearGrid();
            foreach (var org in organizations)
                _view.AddOrganizationToGrid(org);

        }


    }
}
