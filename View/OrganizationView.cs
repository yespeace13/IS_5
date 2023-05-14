using IS_5.Controler;
using IS_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class OrganizationView : Form, IOrganizationsView
    {
        private OrganizationController _controller;
        private int _sizePage = 15;
        
        public OrganizationView()
        {
            InitializeComponent();
            PreviousPageButton.Click += new EventHandler(PreviousPageButton_Click);
            NextPageButton.Click += new EventHandler(NextPageButton_Click);
            Load += new EventHandler(NumberOfPage_Load);
            SelectPageButton.Click += new EventHandler(ForwardToPage_Click);
        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            _controller.LoadView(_sizePage, (int)NumberOfPage.Value);
        }

        private void NumberOfPage_Load(object sender, EventArgs e)
        {
            //15 количество элементов для отображения
            NumberOfPage.Maximum = (int)Math.Ceiling((double)_controller.CountElems / _sizePage);
            NumberOfPage.Minimum = 1;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value < NumberOfPage.Maximum
                ? ++NumberOfPage.Value : NumberOfPage.Maximum;
            _controller.LoadView(_sizePage, (int)NumberOfPage.Value);
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value <= 2 ? 1 : --NumberOfPage.Value;
            _controller.LoadView(_sizePage, (int)NumberOfPage.Value);
            
        }

        public string Name { get; set; }
        public string TaxIdenNum { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public string TypeOrganization { get; set; }
        public string TypeOwnerOrganization { get; set; }
        

        public void AddOrganizationToGrid(int id, Organization organization)
        {
            ListViewItem parent;
            parent = grdOrg.Items.Add(id.ToString());
            parent.SubItems.Add(organization.Name);
            parent.SubItems.Add(organization.TaxIdenNum);
            parent.SubItems.Add(organization.KPP);
            parent.SubItems.Add(organization.Address);
            parent.SubItems.Add(organization.TypeOrganization);
            parent.SubItems.Add(organization.TypeOwnerOrganization);
            
        }

        public void ClearGrid()
        {
            grdOrg.Items.Clear();
            grdOrg.Columns.Clear();
            grdOrg.Columns.Add("Id", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Название", 150, HorizontalAlignment.Left);
            grdOrg.Columns.Add("ИНН", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("КПП", 50, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Адрес", 150, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Тип организации", 100, HorizontalAlignment.Left);
            grdOrg.Columns.Add("Вид организации", 50, HorizontalAlignment.Left);
        }

        public void SetController(OrganizationController controller)
        {
            _controller = controller;
        }
    }
}
