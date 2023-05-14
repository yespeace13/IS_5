using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Controler
{
    public interface IOrganizationsView
    {
        void SetController(OrganizationController controller);
        void ClearGrid();
        void AddOrganizationToGrid(Organization organization);

        string Name { get; set; }
        string TaxIdenNum { get; set; }
        string KPP { get; set; }
        string Address { get; set; }
        TypeOrganizations TypeOrganization { get; set; }

        TypeOfPred TypeOfPred { get; set; }
    }
}
