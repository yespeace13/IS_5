using IS_5.Model;
using IS_5.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IS_5
{
    public partial class Contractview : Form
    {
        private ContractController _controller;
        private Dictionary<string, string> _filtres;
        private string _columnName;
        public Contractview()
        {
            InitializeComponent();
            _controller = new ContractController();
            InitializeForm();
            InitializeFiltrsDictionary();
            ShowContracts();
        }
        private void InitializeFiltrsDictionary()
        {
            _filtres = new Dictionary<string, string>();
            foreach (DataGridViewColumn col in ConDataGrid.Columns)
                _filtres.Add(col.Name, "");
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
                        ChangeToolStripMenuItem.Enabled = true;
                        break;
                    case Possibilities.Delete:
                        DeleteToolStripMenuItem.Enabled = true;
                        break;
                }
            }
        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            ShowContracts();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if(NumberOfPage.Maximum > NumberOfPage.Value)
            {
                NumberOfPage.Value++;
                ShowContracts();
            }
            
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
            ShowContracts();
        }

        public void ShowContracts()
        {
            (string, SortOrder) sortCol = ConDataGrid.SortedColumn == null ? 
                (null, SortOrder.None) : (ConDataGrid.SortedColumn.HeaderText, ConDataGrid.SortOrder);
            var orgs = _controller.ShowContracts(
                (int)PagesSize.Value, 
                (int)NumberOfPage.Value,
                _filtres,
                sortCol,
                out int maxPage);
            NumberOfPage.Maximum = maxPage;
            ConDataGrid.Rows.Clear();
            foreach (var org in orgs)
                ConDataGrid.Rows.Add(org);
        }

        private void CreateContractButton_Click(object sender, EventArgs e)
        {
            new ContractEditView(_controller).ShowDialog();
            ShowContracts();
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e)
        {
            ShowContracts();
        }


        private void AcceptButton_Click(object sender, EventArgs e)
        {
            ShowContracts();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var columns = new string[ConDataGrid.ColumnCount];
            for (var col = 0; col < columns.Length; col++)
                columns[col] = ConDataGrid.Columns[col].HeaderText;
            _controller.ExportToExcel(columns, _filtres);
        }

        private void ConDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) => 
            ShowContracts();
        
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            new ContractEditView(_controller, State.Update,
                int.Parse(ConDataGrid.Rows[selectedRow].Cells[0].Value.ToString())).ShowDialog();
            ShowContracts();
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            _controller.DeleteContract(int.Parse(ConDataGrid.Rows[selectedRow].Cells[0].Value.ToString()));
            ShowContracts();
        }

        private void ConDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            FiltrGroupBox.Visible = false;
            if (e.Button == MouseButtons.Right)
            {
                var hti = ConDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    ConDataGrid.ClearSelection();
                    ConDataGrid.Rows[hti.RowIndex].Selected = true;
                    ContractContextMenuStrip.Show(ConDataGrid, e.Location);
                }
                else if (hti.ColumnIndex > -1)
                {
                    FiltrTextBox.Text = _filtres[ConDataGrid.Columns[hti.ColumnIndex].Name];
                    if (hti.ColumnIndex == 2 || hti.ColumnIndex == 3)
                    {
                        FiltrTextBox.Visible = false;
                        FiltrStartDateTimePicker.Visible = true;
                        FiltrStartDateTimePicker.Location = FiltrTextBox.Location;
                        if(_filtres.ElementAt(hti.ColumnIndex).Value != "")
                            FiltrStartDateTimePicker.Value = DateTime.Parse(_filtres.ElementAt(hti.ColumnIndex).Value);
                    }
                    else
                    {
                        FiltrTextBox.Visible = true;
                        FiltrStartDateTimePicker.Visible = false;
                    }
                    FiltrGroupBox.Visible = true;
                    if (hti.ColumnIndex == ConDataGrid.ColumnCount - 1)
                        FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 60);
                    else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 60);
                    _columnName = ConDataGrid.Columns[hti.ColumnIndex].Name;
                }
            }
            
        }

        private void ConDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = ConDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new ContractEditView(_controller, State.None,
                        int.Parse(ConDataGrid.Rows[selectedRow].Cells[0].Value.ToString())).ShowDialog();
                }
            }
        }

        private void AcceptFiltrButton_Click(object sender, EventArgs e)
        {
            if(_columnName == "DateOfConclusion" || _columnName == "DateValidation")
            {
                _filtres[_columnName] = FiltrStartDateTimePicker.Value.ToShortDateString();
                FiltrStartDateTimePicker.Value = DateTime.Now;
                FiltrGroupBox.Visible = false;
                ShowContracts();
            }
            else if(FiltrTextBox.Text.Length != 0)
            {
                _filtres[_columnName] = FiltrTextBox.Text;
                FiltrTextBox.Clear();
                FiltrGroupBox.Visible = false;
                ShowContracts();
            }
                
        }

        private void ClearFiltrsButton_Click(object sender, EventArgs e)
        {
            InitializeFiltrsDictionary();
            FiltrTextBox.Clear();
            ShowContracts();
            FiltrGroupBox.Visible = false;
        }
    }
}
