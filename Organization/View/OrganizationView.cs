using IS_5.Controler;
using IS_5.Model;
using IS_5.View;
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

        public OrganizationView()
        {
            InitializeComponent();
            _controller = new OrganizationController();
            InitializeForm();
            ShowOrganizations();
        }

        private void InitializeForm()
        {
            var typeOrg = _controller.ShowTypesOrganizations();
            var typeOwnOrg = _controller.ShowTypesOwnerOrganizations();
            var localitys = _controller.ShowLocalitys();
            TypeOrgCheckedListBox.Items.AddRange(typeOrg);
            TypeOwnCheckedListBox.Items.AddRange(typeOwnOrg);
            LocalitysCheckedListBox.Items.AddRange(localitys);
            var possibilites = UserSession.User.Privilege.Organizations.Item2;
            CreateOrgButton.Enabled = false;
            ChangeToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;
            if (possibilites == null) return;
            foreach (var poss in possibilites)
            {
                switch (poss)
                {
                    case Possibilities.Add:
                        CreateOrgButton.Enabled = true;
                        break;
                    case Possibilities.Change:
                        ChangeToolStripMenuItem.Visible = true;
                        break;
                    case Possibilities.Delete:
                        DeleteToolStripMenuItem.Visible = true;
                        break;
                    case Possibilities.AddFile:
                        break;
                    case Possibilities.DelFile:
                        break;
                    
                }
            }
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
            if(NumberOfPage.Minimum < NumberOfPage.Value)
            {
                NumberOfPage.Value--;
                ShowOrganizations();
            }
            
        }

        public void ShowOrganizations()
        {
            string[] filtrsType = TypeOrgCheckedListBox.CheckedItems.Count == 0 ?
                TypeOrgCheckedListBox.Items.Cast<string>().ToArray() : 
                TypeOrgCheckedListBox.CheckedItems.Cast<string>().ToArray();
            string[] filtrsTypeOwn = TypeOwnCheckedListBox.CheckedItems.Count == 0 ?
                TypeOwnCheckedListBox.Items.Cast<string>().ToArray() : 
                TypeOwnCheckedListBox.CheckedItems.Cast<string>().ToArray();
            string[] filtrsLocalitys = LocalitysCheckedListBox.CheckedItems.Count == 0 ?
                LocalitysCheckedListBox.Items.Cast<string>().ToArray() :
                LocalitysCheckedListBox.CheckedItems.Cast<string>().ToArray();
            (string, SortOrder) sortCol = OrgDataGrid.SortedColumn == null ? 
                (null, SortOrder.None) : (OrgDataGrid.SortedColumn.HeaderText, OrgDataGrid.SortOrder);
            var orgs = _controller.ShowOrganizations(
                (int)PagesSize.Value, 
                (int)NumberOfPage.Value, 
                filtrsType,
                filtrsTypeOwn,
                filtrsLocalitys,
                sortCol,
                out int maxPage);
            NumberOfPage.Maximum = maxPage;
            OrgDataGrid.Rows.Clear();
            foreach (var org in orgs)
                OrgDataGrid.Rows.Add(org);
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            new OrganizationEditView(_controller, State.Insert).ShowDialog();
            ShowOrganizations();
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void FiltrsButton_Click(object sender, EventArgs e)
        {
            FiltrsGroupBox.Visible = !FiltrsGroupBox.Visible;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            FiltrsGroupBox.Visible = false;
            ShowOrganizations();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string[] filtrsType = TypeOrgCheckedListBox.CheckedItems.Count == 0 ?
               TypeOrgCheckedListBox.Items.Cast<string>().ToArray() :
               TypeOrgCheckedListBox.CheckedItems.Cast<string>().ToArray();
            string[] filtrsTypeOwn = TypeOwnCheckedListBox.CheckedItems.Count == 0 ?
                TypeOwnCheckedListBox.Items.Cast<string>().ToArray() :
                TypeOwnCheckedListBox.CheckedItems.Cast<string>().ToArray();
            string[] filtrsLocalitys = LocalitysCheckedListBox.CheckedItems.Count == 0 ?
                LocalitysCheckedListBox.Items.Cast<string>().ToArray() :
                LocalitysCheckedListBox.CheckedItems.Cast<string>().ToArray();
            var columns = new string[OrgDataGrid.ColumnCount];
            for (var col = 0; col < columns.Length; col++)
                columns[col] = OrgDataGrid.Columns[col].HeaderText;
            _controller.ExportToExcel(filtrsType, filtrsTypeOwn, filtrsLocalitys, columns);
        }

        private void OrgDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowOrganizations();
        }
            
        
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            new OrganizationEditView(_controller, State.Update, 
                int.Parse(OrgDataGrid.Rows[selectedRow].Cells[0].Value.ToString())).ShowDialog();
            ShowOrganizations();
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            _controller.DeleteOrganization(int.Parse(OrgDataGrid.Rows[selectedRow].Cells[0].Value.ToString()));
            ShowOrganizations();
        }

        private void OrgDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = OrgDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    OrgDataGrid.ClearSelection();
                    OrgDataGrid.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void OrgDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = OrgDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new OrganizationEditView(_controller, State.None, selectedRow + 1).ShowDialog();
                }
            }
        }
    }
}