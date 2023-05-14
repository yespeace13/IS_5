using IS_5.Controler;
using IS_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class OrganizationView : Form, IOrganizationsView
    {
        DataGridView dataGrid = new DataGridView();
        private OrganizationController _controller;
        
        public OrganizationView()
        {
            InitializeComponent();
           Load += new EventHandler(OrganizationForm_Load);
            
        }
        public string Name { get; set; }
        public string TaxIdenNum { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public TypeOrganizations TypeOrganization { get; set; }
        public TypeOfPred TypeOfPred { get; set; }

        public void AddOrganizationToGrid(Organization organization)
        {
            ListViewItem parent;
            parent = grdOrg.Items.Add(organization.Name);
            parent.SubItems.Add(organization.TaxIdenNum);
            parent.SubItems.Add(organization.KPP);
            parent.SubItems.Add(organization.Address);
            parent.SubItems.Add(organization.TypeOrganization.ToString());
            parent.SubItems.Add(organization.TypeOfPred.ToString());
        }

        public void ClearGrid()
        {
            grdOrg.Columns.Clear();
            grdOrg.Columns.Add("Name", 150, HorizontalAlignment.Left);
            grdOrg.Columns.Add("TaxIdenNum", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("KPP", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Address", 150, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Type", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Type", 50, HorizontalAlignment.Left);
        }

        public void SetController(OrganizationController controller)
        {
            _controller = controller;
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            //Controls.Add(dataGrid);
            grdOrg.Size = new System.Drawing.Size(500, 300);
        }
    }
}
