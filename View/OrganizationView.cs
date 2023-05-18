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
    public partial class OrganizationView : Form
    {
        private OrganizationController _controller;
        
        public OrganizationView()
        {
            InitializeComponent();
            PreviousPageButton.Click += new EventHandler(PreviousPageButton_Click);
            NextPageButton.Click += new EventHandler(NextPageButton_Click);
            Load += new EventHandler(NumberOfPage_Load);
            SelectPageButton.Click += new EventHandler(ForwardToPage_Click);
            _controller = new OrganizationController();
            AddOrganizationToGrid();
        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            //_controller.LoadView((int)PagesSize.Value, (int)NumberOfPage.Value);
        }

        private void NumberOfPage_Load(object sender, EventArgs e)
        {
            //15 количество элементов для отображения
            //NumberOfPage.Maximum = (int)Math.Ceiling((double)_controller.CountElems / (int)PagesSize.Value);
            //NumberOfPage.Minimum = 1;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            //    NumberOfPage.Value = NumberOfPage.Value < NumberOfPage.Maximum
            //        ? ++NumberOfPage.Value : NumberOfPage.Maximum;
            //    _controller.LoadView((int)PagesSize.Value, (int)NumberOfPage.Value);
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            //NumberOfPage.Value = NumberOfPage.Value <= 2 ? 1 : --NumberOfPage.Value;
            //_controller.LoadView((int)PagesSize.Value, (int)NumberOfPage.Value);
            
        }

        public string NameOrg { get { return NameOrgTextBox.Text; } set { NameOrgTextBox.Text = value; } }
        public string TaxIdenNum { get { return TaxIdenNumTextBox.Text; } set { TaxIdenNumTextBox.Text = value; } }
        public string KPP { get { return KPPTextBox.Text; } set { KPPTextBox.Text = value; } }
        public string Address { get { return AddressTextBox.Text; } set { AddressTextBox.Text = value; } }
        public string TypeOrganization 
        { 
            get { return TypeOrgamizationComboBox.SelectedValue.ToString(); } 
            set { TypeOrgamizationComboBox.SelectedValue = value; } 
        }
        public string TypeOwnerOrganization
        {
            get { return TypeOwnerComboBox.SelectedValue.ToString(); }
            set { TypeOwnerComboBox.SelectedValue = value; }
        }

        public void AddOrganizationToGrid()
        {
            ClearGrid();
            foreach(var org in _controller.ShowOrganizations())
            {
                dataGridOrg.Rows.Add(org.Value);

            }
        }

        public void ClearGrid()
        {
            dataGridOrg.Columns.Clear();
            dataGridOrg.Columns.Add("Id", "Номер");
            dataGridOrg.Columns.Add("Название", "Название");
            dataGridOrg.Columns.Add("ИНН", "ИНН");
            dataGridOrg.Columns.Add("КПП", "КПП");
            dataGridOrg.Columns.Add("Адрес", "Адрес");
            dataGridOrg.Columns.Add("Тип организации", "Тип организации");
            dataGridOrg.Columns.Add("Вид организации", "Вид организации");
        }


        public void DeleteOrganizationFromGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateViewDetail(int id, Organization organization)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrganization(int id, Organization organization)
        {
            throw new NotImplementedException();
        }

        public void AddOrganization(Organization organization)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrganization(int id)
        {
            throw new NotImplementedException();
        }
    }
}
