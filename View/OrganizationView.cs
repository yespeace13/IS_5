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
            SelectPageButton.Click += new EventHandler(ForwardToPage_Click);
            _controller = new OrganizationController();
            ShowOrganizations();
            CreateOrgButton.Click += new EventHandler(CreateOrgButton_Click);
            DelOrgButton.Click += new EventHandler(DeleteOrgButton_Click);
        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if(NumberOfPage.Maximum > NumberOfPage.Value)
            {
                NumberOfPage.Value++;
                ShowOrganizations();
            }
            
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
            ShowOrganizations();
        }

        public void ShowOrganizations()
        {
            var orgs = _controller.ShowOrganizations((int)PagesSize.Value, (int)NumberOfPage.Value, out int maxPage);
            NumberOfPage.Maximum = maxPage;
            ClearGrid();
            foreach (var org in orgs)
            {
                DataGridOrg.Rows.Add(org);
            }
        }

        public void ClearGrid()
        {
            DataGridOrg.Columns.Clear();
            DataGridOrg.Columns.Add("Id", "Номер");
            DataGridOrg.Columns.Add("Название", "Название");
            DataGridOrg.Columns.Add("ИНН", "ИНН");
            DataGridOrg.Columns.Add("КПП", "КПП");
            DataGridOrg.Columns.Add("Адрес", "Адрес");
            DataGridOrg.Columns.Add("Тип организации", "Тип организации");
            DataGridOrg.Columns.Add("Вид организации", "Вид организации");
        }

        private bool CheckFilds()
        {
            if(NameOrgTextBox.Text == "" ||  
                TaxIdenNumTextBox.Text == "" ||
                KPPTextBox.Text == "" || 
                AddressTextBox.Text == "" ||
                TypeOrganizationComboBox.SelectedIndex == -1  ||
                TypeOwnerComboBox.SelectedIndex == -1)
                return false;
            else return true;
        }

        public void DeleteOrganization(int id)
        {
            throw new NotImplementedException();
        }

        private void DataGridOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridOrg.CurrentRow != null)
            {
                var org = DataGridOrg.CurrentRow.Cells;
                NameOrgTextBox.Text = org[1].Value.ToString();
                TaxIdenNumTextBox.Text = org[2].Value.ToString();
                KPPTextBox.Text = org[3].Value.ToString();
                AddressTextBox.Text = org[4].Value.ToString();
                TypeOrganizationComboBox.SelectedItem = org[5].Value.ToString();
                TypeOwnerComboBox.SelectedItem = org[6].Value.ToString();
            }
        }

        private void OrganizationView_Load(object sender, EventArgs e)
        {
            TypeOrganizationComboBox.Items.AddRange(_controller.ShowTypeOrganizations().ToArray());
            TypeOwnerComboBox.Items.AddRange(_controller.ShowTypeOwnerOrganizations().ToArray());
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                _controller.CreateOrganization(NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
                    AddressTextBox.Text,
                    TypeOrganizationComboBox.SelectedItem.ToString(),
                    TypeOwnerComboBox.SelectedItem.ToString());
                ShowOrganizations();
            }
        }

        private void UpdateOrgButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                _controller.UpdateOrganization(int.Parse(DataGridOrg.CurrentRow.Cells[0].Value.ToString()), 
                    NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
                    AddressTextBox.Text,
                    TypeOrganizationComboBox.SelectedItem.ToString(),
                    TypeOwnerComboBox.SelectedItem.ToString());
                ShowOrganizations();
            }
        }

        public void DeleteOrgButton_Click(object sender, EventArgs e)
        {
            if(DataGridOrg.CurrentRow != null)
            {
                _controller.DeleteOrganization(int.Parse(DataGridOrg.CurrentRow.Cells[0].Value.ToString()));

                ShowOrganizations();
            }
        }
    }
}
