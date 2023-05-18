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
            AddOrganizationToGrid();
            AddOrgButton.Click += new EventHandler(AddOrganization_Click);

        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            AddOrganizationToGrid();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value += 1;
            AddOrganizationToGrid();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
            AddOrganizationToGrid();
        }

        public void AddOrganizationToGrid()
        {
            var orgs = _controller.ShowOrganizations((int)PagesSize.Value, (int)NumberOfPage.Value);
            if(orgs.Count != 0)
            {
                ClearGrid();
                foreach (var org in orgs)
                {
                    dataGridOrg.Rows.Add(org.Value);
                }
            }
        }

        public void ClearGrid()
        {
            dataGridOrg.Columns.Clear();
            //dataGridOrg.Columns.Add("Id", "Номер");
            dataGridOrg.Columns.Add("Название", "Название");
            dataGridOrg.Columns.Add("ИНН", "ИНН");
            dataGridOrg.Columns.Add("КПП", "КПП");
            dataGridOrg.Columns.Add("Адрес", "Адрес");
            dataGridOrg.Columns.Add("Тип организации", "Тип организации");
            dataGridOrg.Columns.Add("Вид организации", "Вид организации");
        }



        public void AddOrganization_Click(object sender, EventArgs e)
        {
            if(CheckFilds())
                _controller.CreateOrganization(NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
                    AddressTextBox.Text, 
                    TypeOrganizationComboBox.SelectedItem.ToString(), 
                    TypeOwnerComboBox.SelectedItem.ToString());
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

        private void dataGridOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridOrg.CurrentRow != null)
            {
                var org = dataGridOrg.CurrentRow.Cells;
                NameOrgTextBox.Text = org[0].Value.ToString();
                TaxIdenNumTextBox.Text = org[1].Value.ToString();
                KPPTextBox.Text = org[2].Value.ToString();
                AddressTextBox.Text = org[3].Value.ToString();
                TypeOrganizationComboBox.SelectedItem = org[4].Value.ToString();
                TypeOwnerComboBox.SelectedItem = org[5].Value.ToString();

            }

        }

        private void OrganizationView_Load(object sender, EventArgs e)
        {
            TypeOrganizationComboBox.Items.AddRange(_controller.ShowTypeOrganizations().ToArray());
            TypeOwnerComboBox.Items.AddRange(_controller.ShowTypeOwnerOrganizations().ToArray());
        }
    }
}
