using IS_5.Controler;
using IS_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_5
{
    public partial class OrganizationView : Form
    {
        private OrganizationController _controller;
        private State _state;

        public OrganizationView()
        {
            InitializeComponent();
            InitializeForm();
            _controller = new OrganizationController();
            ShowOrganizations();

        }

        private void InitializeForm()
        {
            _state = State.None;
            
            ChangeVisible();
            var possibilites = UserSession.User.Privilege.Organizations.Item2;
            InitializeGrid();
            CreateOrgButton.Enabled = false;
            
            foreach (var poss in possibilites)
            {
                switch (poss)
                {
                    case Possibilities.Add:
                        CreateOrgButton.Enabled = true;
                        break;
                    case Possibilities.OpenAndEdit:
                        break;
                    case Possibilities.Delete:
                        break;
                    case Possibilities.Open:
                        break;
                    case Possibilities.Change:
                        break;
                }
            }
        }

        private void InitializeGrid()
        {
            var UpdateButton = new DataGridViewButtonColumn
            {
                Name = "Изменить",
                Text = "Изменить",
                UseColumnTextForButtonValue = true,
                Width = 10
            };
            if (OrgDataGrid.Columns["Изменить"] == null)
                OrgDataGrid.Columns.Insert(OrgDataGrid.ColumnCount, UpdateButton);
            UpdateButton.Width = 80;
            var DeleteButton = new DataGridViewButtonColumn
            {
                Name = "Удалить",
                Text = "Удалить",
                UseColumnTextForButtonValue = true,
                
            };
            if (OrgDataGrid.Columns["Удалить"] == null)
                OrgDataGrid.Columns.Insert(OrgDataGrid.ColumnCount, DeleteButton);

            DeleteButton.Width = 80;
            Id.Width = 40;

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
            string[] filtrsType = null;
            if (TypeOrgCheckedListBox.CheckedItems.Count != 0)
                filtrsType = TypeOrgCheckedListBox.CheckedItems.Cast<string>().ToArray();
            
            string[] filtrsTypeOwn = null;
            if (TypeOwnCheckedListBox.CheckedItems.Count != 0)
                filtrsTypeOwn = TypeOwnCheckedListBox.CheckedItems.Cast<string>().ToArray();
            
            (string, SortOrder) sortCol = (null, SortOrder.None);
            if (OrgDataGrid.SortedColumn != null)
                sortCol = (OrgDataGrid.SortedColumn.Name, OrgDataGrid.SortOrder);
            
            var orgs = _controller.ShowOrganizations(
                (int)PagesSize.Value, 
                (int)NumberOfPage.Value, 
                filtrsType,
                filtrsTypeOwn,
                sortCol,
                out int maxPage);
            NumberOfPage.Maximum = maxPage;
            ClearGrid();
            foreach (var org in orgs)
                OrgDataGrid.Rows.Add(org);
        }
        public void ClearGrid()
        {
            //DataGridOrg.Columns.Clear();
            OrgDataGrid.Rows.Clear();
            //DataGridOrg.Columns.Add("Id", "Номер");
            //DataGridOrg.Columns.Add("Название", "Название");
            //DataGridOrg.Columns.Add("ИНН", "ИНН");
            //DataGridOrg.Columns.Add("КПП", "КПП");
            //DataGridOrg.Columns.Add("Адрес", "Адрес");
            //DataGridOrg.Columns.Add("Тип организации", "Тип организации");
            //DataGridOrg.Columns.Add("Вид организации", "Вид организации");
            
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

        private void OrganizationView_Load(object sender, EventArgs e)
        {
            var typeOrg = _controller.ShowTypeOrganizations();
            var typeOwnOrg = _controller.ShowTypeOwnerOrganizations();
            TypeOrganizationComboBox.Items.AddRange(typeOrg);
            TypeOwnerComboBox.Items.AddRange(typeOwnOrg);
            TypeOrgCheckedListBox.Items.AddRange(typeOrg);
            TypeOwnCheckedListBox.Items.AddRange(typeOwnOrg);
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            ChangeVisible();
            _state = State.Insert;
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void OrgDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == OrgDataGrid.Columns["Изменить"].Index)
            {
                FillFields(e);
                _state = State.Update;
                ChangeVisible();
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == OrgDataGrid.Columns["Удалить"].Index)
                DeleteItem();
        }

        private void DeleteItem()
        {
            _controller.DeleteOrganization(int.Parse(OrgDataGrid.CurrentRow.Cells[0].Value.ToString()));
            ShowOrganizations();
        }

        private void FillFields(DataGridViewCellEventArgs e)
        {
            var org = OrgDataGrid.CurrentRow.Cells;
            NameOrgTextBox.Text = org[1].Value.ToString();
            TaxIdenNumTextBox.Text = org[2].Value.ToString();
            KPPTextBox.Text = org[3].Value.ToString();
            AddressTextBox.Text = org[4].Value.ToString();
            TypeOrganizationComboBox.SelectedItem = org[5].Value.ToString();
            TypeOwnerComboBox.SelectedItem = org[6].Value.ToString();
        }

        private void ClearFields()
        {
            NameOrgTextBox.Clear();
            TaxIdenNumTextBox.Clear();
            KPPTextBox.Clear();
            AddressTextBox.Clear() ;
            TypeOrganizationComboBox.SelectedIndex = -1;
            TypeOwnerComboBox.SelectedIndex = - 1;
        }

        private void ChangeVisible()
        {
            bool value;
            if (_state == State.Insert || _state == State.Update)
                value = false;
            else
                value = true;
            
            InsertUpdateGroupBox.Visible = !value;
            OrgDataGrid.Visible = value;
            CreateOrgButton.Visible = value;
            NumberPageLabel.Visible = value;
            NumberOfPage.Visible = value;
            CountLabel.Visible = value;
            PagesSize.Visible = value;
            SelectPageButton.Visible = value;
            NextPageButton.Visible = value;
            PreviousPageButton.Visible = value;
            FiltrsButton.Visible = value;
            FiltrsGroupBox.Visible = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                if (_state == State.Insert)
                {
                    _controller.CreateOrganization(NameOrgTextBox.Text,
                        TaxIdenNumTextBox.Text,
                        KPPTextBox.Text,
                       AddressTextBox.Text,
                       TypeOrganizationComboBox.SelectedItem.ToString(),
                       TypeOwnerComboBox.SelectedItem.ToString());
                }
                else if (_state == State.Update)
                {
                    _controller.UpdateOrganization(int.Parse(OrgDataGrid.CurrentRow.Cells[0].Value.ToString()),
                        NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
                        AddressTextBox.Text,
                        TypeOrganizationComboBox.SelectedItem.ToString(),
                        TypeOwnerComboBox.SelectedItem.ToString());
                }
                _state = State.None;
                ShowOrganizations();
                ClearFields();
                ChangeVisible();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _state = State.None;
            ChangeVisible();
            ClearFields();
        }

        private void FiltrsButton_Click(object sender, EventArgs e)
        {
            FiltrsGroupBox.Visible = FiltrsGroupBox.Visible ? false : true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            FiltrsGroupBox.Visible = false;
            ShowOrganizations();
        }
    }
}
