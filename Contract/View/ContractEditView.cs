﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IS_5.View
{
    public partial class ContractEditView : Form
    {
        private ContractController _controller;
        private string[] _contract;
        private List<string[]> _localprice;
        private List<string> _scans;
        private State _state;
        private int _currentScan;
        public ContractEditView(ContractController controller, State state, int id)
        {
            InitializeComponent();
            _controller = controller;
            _state = state;
            PrevScanButton.Enabled = false;
            if (state == State.Update)
            {
                (_contract, _localprice, _scans) = _controller.ShowContract(id);
                FillOrganizations();
                FillFields();
            }
            else if (state == State.None)
            {
                (_contract, _localprice, _scans) = _controller.ShowContract(id);
                FillOrganizations();
                FillFields();
                ChangeEnable();
            }
        }

        private void FillOrganizations()
        {
            var organizations = _controller
                            .ShowOrganizations()
                            .Select(o => o[1])
                            .ToArray();
            ClientComboBox.Items.AddRange(organizations);
            ExecutorComboBox.Items.AddRange(organizations);
        }

        public ContractEditView(ContractController controller)
        {
            InitializeComponent();
            _controller = controller;
            FillOrganizations();
            _scans = new List<string>();
            _state = State.Insert;
            _localprice = new List<string[]>();
            PrevScanButton.Enabled = false;
            NextScanButton.Enabled = false;
        }

        private void ChangeEnable()
        {
            NumberTextBox.Enabled = false;
            ClientComboBox.Enabled = false;
            OkButton.Visible = false;
            DateOfConclusionDateTimePicker.Enabled = false;
            DateValidDateTimePicker.Enabled = false;
            ExecutorComboBox.Enabled = false;
            LocalsPricesDataGridView.Enabled = false;
            CancelButton.Text = "Закрыть";
            AddLocalPriceButton.Visible = false;
            AddFileButton.Visible = false;
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NumberTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен номер контракта.");
            else if (DateOfConclusionDateTimePicker.Value > DateValidDateTimePicker.Value)
                dialogRes = ShowErrorMessage("Дата заключения позже даты действия");
            else if (ExecutorComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран исполнитель");
            else if (ClientComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран заказчик");
            else if (LocalsPricesDataGridView.Rows.Count == 0)
                dialogRes = ShowErrorMessage("Не созданы муниципальные районы");
            else if (ClientComboBox.SelectedItem == ExecutorComboBox.SelectedItem)
                dialogRes = ShowErrorMessage("Организации одинаковые");
            return dialogRes == DialogResult.No;
        }

        private static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                if (_state == State.Insert)
                {
                    _controller.CreateContract(NumberTextBox.Text, 
                        DateOfConclusionDateTimePicker.Value, DateValidDateTimePicker.Value,
                        ExecutorComboBox.SelectedItem.ToString(), ClientComboBox.SelectedItem.ToString(),
                        _localprice, _scans);
                }
                else
                {
                    _controller.UpdateContract(int.Parse(_contract[0].ToString()), NumberTextBox.Text,
                        DateOfConclusionDateTimePicker.Value, DateValidDateTimePicker.Value,
                        ExecutorComboBox.SelectedItem.ToString(), ClientComboBox.SelectedItem.ToString(),
                        _localprice, _scans);
                }
                Close();
            }
        }

        private void FillFields()
        {
            NumberTextBox.Text = _contract[1];
            DateOfConclusionDateTimePicker.Value = DateTime.Parse(_contract[2]);
            DateValidDateTimePicker.Value = DateTime.Parse(_contract[3]);
            ExecutorComboBox.SelectedItem = _contract[4];
            ClientComboBox.SelectedItem = _contract[5];
            ShowLocals();
            _currentScan = 0;
            if(_scans.Count > 0)
                ChangeScan();
            else
                NextScanButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void LocalsPricesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hti = LocalsPricesDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    LocalsPricesDataGridView.ClearSelection();
                    LocalsPricesDataGridView.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        
        private void PrevScanButton_Click(object sender, EventArgs e)
        {
            if(_currentScan > 0)
            {
                _currentScan--;
                PrevScanButton.Enabled = _currentScan == 0 ? false : true;
                NextScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void ChangeScan()
        {
            if (File.Exists(_scans[_currentScan]))
            {
                var bitmap = new Bitmap(_scans[_currentScan]);
                var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
                var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
                ScanPictureBox.Image = i;
            }
            else
            {
                ShowErrorMessage("Не все файлы были загружены.");
            }
        }

        private void NextScanButton_Click(object sender, EventArgs e)
        {
            if(_currentScan < _scans.Count-1)
            {
                _currentScan++;
                NextScanButton.Enabled = _currentScan == _scans.Count -1 ? false : true;
                PrevScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
        {
            new ScanView(new Bitmap(_scans[_currentScan])).ShowDialog();
        }

        private void DeleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_scans.Count > 0)
            {
                _scans.RemoveAt(_currentScan);
                if(_scans.Count == 0)
                {
                    _currentScan = 0;
                    ScanPictureBox.Image = null;
                }
                else
                {
                    _currentScan = _currentScan == 0 ? 0 : --_currentScan;
                    ChangeScan();
                }
            }
            else
            {
                ScanPictureBox.Image = null;
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = LocalsPricesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var localForm = new LocalPriceView(_controller,
                LocalsPricesDataGridView.Rows[selectedRow].Cells[0].Value.ToString(),
                decimal.Parse(LocalsPricesDataGridView.Rows[selectedRow].Cells[1].Value.ToString()));
            if (localForm.ShowDialog() == DialogResult.OK)
            {
                _localprice[selectedRow][0] = localForm.Locality;
                _localprice[selectedRow][1] = localForm.Price.ToString();
                ShowLocals();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = LocalsPricesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            LocalsPricesDataGridView.Rows.RemoveAt(selectedRow);
        }

        private void AddLocalPriceButton_Click(object sender, EventArgs e)
        {
            var localForm = new LocalPriceView(_controller);
            if(localForm.ShowDialog() == DialogResult.OK)
            {
                _localprice.Add(new string[] { localForm.Locality, localForm.Price.ToString() });
                ShowLocals();
            };
        }

        private void ShowLocals()
        {
            LocalsPricesDataGridView.Rows.Clear();
            foreach (var local in _localprice)
                LocalsPricesDataGridView.Rows.Add(local[0], local[1]);

        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _scans.Add(openFileDialog1.FileName);
                _currentScan = _scans.Count - 1;
                if (_currentScan == 0)
                {
                    PrevScanButton.Enabled = false;
                    NextScanButton.Enabled = false;
                }
                else
                {
                    PrevScanButton.Enabled = true;
                    NextScanButton.Enabled = false;
                }
                ChangeScan();
            }
        }
    }
}
