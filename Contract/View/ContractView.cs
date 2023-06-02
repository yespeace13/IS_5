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
    public partial class Contractview : Form
    {
        private ContractController _controller;

        public Contractview()
        {
            InitializeComponent();
            _controller = new ContractController();
            InitializeForm();
            ShowOrganizations();
        }

        private void InitializeForm()
        {
            var possibilites = UserSession.User.Privilege.Contracts.Item2;
            CreateButton.Enabled = false;
            ChangeToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;
            if (possibilites == null) return;
            foreach (var poss in possibilites)
            {
                switch (poss)
                {
                    case Possibilities.Add:
                        CreateButton.Enabled = true;
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
            NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
            ShowOrganizations();
        }

        public void ShowOrganizations()
        {
            (string, SortOrder) sortCol = ConDataGrid.SortedColumn == null ? 
                (null, SortOrder.None) : (ConDataGrid.SortedColumn.HeaderText, ConDataGrid.SortOrder);
            var orgs = _controller.ShowContracts(
                (int)PagesSize.Value, 
                (int)NumberOfPage.Value,
                sortCol,
                out int maxPage);
            NumberOfPage.Maximum = maxPage;
            ConDataGrid.Rows.Clear();
            foreach (var org in orgs)
                ConDataGrid.Rows.Add(org);
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            new ContractEditView(_controller, State.Insert).ShowDialog();
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
            //var columns = new string[ConDataGrid.ColumnCount];
            //for (var col = 0; col < columns.Length; col++)
            //    columns[col] = ConDataGrid.Columns[col].HeaderText;
            //_controller.ExportToExcel(columns);
        }

        private void ConDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) => 
            ShowOrganizations();
        
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            new ContractEditView(_controller, State.Update, selectedRow + 1).ShowDialog();
            ShowOrganizations();
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            _controller.DeleteContract(selectedRow + 1);
            ShowOrganizations();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            new ContractEditView(_controller, State.None, selectedRow + 1).ShowDialog();
        }

        private void ConDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = ConDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    ConDataGrid.ClearSelection();
                    ConDataGrid.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
    }
}