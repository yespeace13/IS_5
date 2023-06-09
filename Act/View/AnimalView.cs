using IS_5.Model;
using Microsoft.Vbe.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class AnimalView : Form
    {
        private ActController _controller;
        private int _currentScan;
        private State _state;
        public int Id { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }
        public string Breed { get; set; }
        public double Size { get; set; }
        public string Wool { get; set; }
        public string Color { get; set; }
        public string Ears { get; set; }
        public string Tail { get; set; }
        public string SpecialSigns { get; set; }
        public string IdentificationLabel { get; set; }
        public string ChipNumber { get; set; }
        public string Locality { get; set; }
        public List<string> Scans { get; set; }

        public AnimalView(ActController controller, State state, string[] animal, List<string> scans)
        {
            InitializeComponent();
            _controller = controller;
            FillComboBoxes();
            FillData(animal, scans);
            PrevScanButton.Enabled = false;
            _state = state;
            if (state == State.None) EnableControls();
        }
        public AnimalView(ActController controller)
        {
            InitializeComponent();
            _controller = controller;
            FillComboBoxes();
            PrevScanButton.Enabled = false;
            _state = State.Insert;
            Scans = new List<string>();
        }

        private void FillComboBoxes()
        {
            LocalityComboBox.Items.AddRange(_controller.GetLocalitys());
        }

        private void EnableControls()
        {
            CategoryTextBox.Enabled = false;
            SexGroupBox.Enabled = false;
            BreedTextBox.Enabled = false;
            SizeNumericUpDown.Enabled = false;
            WoolTextBox.Enabled = false;
            ColorTextBox.Enabled = false;
            EarsTextBox.Enabled = false;
            TailTextBox.Enabled = false;
            SpecialSignsTextBox.Enabled = false;
            IdenLabelTextBox.Enabled = false;
            ChipNumTextBox.Enabled = false;
            LocalityComboBox.Enabled = false;
            AddFileButton.Enabled = false;
            OkButton.Visible = false;
            CancelButton.Text = "Закрыть";
        }

        private void FillData(string[] animal, List<string> scans)
        {
            Id = int.Parse(animal[0]);
            CategoryTextBox.Text = animal[1];
            if (animal[2] == "Самка") FemaleRadioButton.Checked = true;
            else MaleRadioButton.Checked = true;
            BreedTextBox.Text = animal[3];
            SizeNumericUpDown.Value = decimal.Parse(animal[4]);
            WoolTextBox.Text = animal[5];
            ColorTextBox.Text = animal[6];
            EarsTextBox.Text = animal[7];
            TailTextBox.Text = animal[8];
            SpecialSignsTextBox.Text = animal[9];
            IdenLabelTextBox.Text = animal[10];
            ChipNumTextBox.Text = animal[11];
            LocalityComboBox.SelectedItem = animal[12];
            Scans = scans;
            _currentScan = 0;
            if(Scans.Count != 0) ChangeScan();
        }

        

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Scans.Add(openFileDialog1.FileName);
                _currentScan = Scans.Count - 1;
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

        private void ChangeScan()
        {
            if (File.Exists(Scans[_currentScan]))
            {
                var bitmap = new Bitmap(Scans[_currentScan]);
                var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
                var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
                ScanPictureBox.Image = i;
            }
            else
            {
                ShowErrorMessage("Не все файлы были загружены.");
            }
        }

        private static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrevScanButton_Click(object sender, EventArgs e)
        {
            if (_currentScan > 0)
            {
                _currentScan--;
                PrevScanButton.Enabled = _currentScan == 0 ? false : true;
                NextScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void NextScanButton_Click(object sender, EventArgs e)
        {
            if (_currentScan < Scans.Count - 1)
            {
                _currentScan++;
                NextScanButton.Enabled = _currentScan == Scans.Count - 1 ? false : true;
                PrevScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                Category =  CategoryTextBox.Text;
                Sex = FemaleRadioButton.Checked ? "Caмка" : "Самец";
                Breed =  BreedTextBox.Text;
                Size = (double)SizeNumericUpDown.Value;
                Wool = WoolTextBox.Text;
                Color = ColorTextBox.Text;
                Ears = EarsTextBox.Text;
                Tail =  TailTextBox.Text;
                SpecialSigns = SpecialSignsTextBox.Text;
                IdentificationLabel = IdenLabelTextBox.Text;
                ChipNumber =  ChipNumTextBox.Text;
                Locality =  LocalityComboBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool CheckFields()
        {
            var dialogRes = DialogResult.No;
            if (LocalityComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран населенный пункт.");
            return dialogRes == DialogResult.No;
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Scans.Count > 0)
            {
                Scans.RemoveAt(_currentScan);
                if (Scans.Count == 0)
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

        private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
        {
            new ScanView(new Bitmap(Scans[_currentScan])).ShowDialog();
        }
    }
}
