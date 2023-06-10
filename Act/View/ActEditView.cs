using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class ActEditView : Form
    {
        private string[] _act;
        Dictionary<string[], List<string>> _animals;
        private List<string> _scans;
        private State _state;
        private int _currentScan;
        ActController _controller;
        public ActEditView(ActController controller, State state, int id)
        {
            InitializeComponent();
            _controller = controller;
            _state = state;
            PrevScanButton.Enabled = false;
            FillComboBoxes();
            FillFields(id);
            _state = state;
            if (state == State.None)
               ChangeEnable();
        }

        public ActEditView(ActController controller)
        {
            InitializeComponent();
            _controller = controller;
            PrevScanButton.Enabled = false;
            FillComboBoxes();
            _state = State.Insert;
            _scans = new List<string>();
            _animals = new Dictionary<string[], List<string>>();
        }

        private void ChangeEnable()
        {
            ContractsComboBox.Enabled = false;
            OrgsComboBox.Enabled = false;
            DateOfCapDateTimePicker.Enabled = false;
            CancelButton.Text = "Закрыть";
            AddAnimalButton.Visible = false;
            AddFileButton.Visible = false;
            OkButton.Visible = false;
        }

        private void FillFields(int id)
        {
            (_act, _scans) = _controller.GetAct(id);
            _animals = _controller.GetAnimals(id);
            ContractsComboBox.SelectedItem = _act[3];
            OrgsComboBox.SelectedItem = _act[1];
            DateOfCapDateTimePicker.Value = DateTime.Parse(_act[2]);
            if(_scans.Count != 0) ChangeScan();
            ShowAnimals();
        }

        private void FillComboBoxes()
        {
            OrgsComboBox.Items.AddRange(_controller.GetOrganizations());
            ContractsComboBox.Items.AddRange(_controller.GetContracts());
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
            if (_currentScan < _scans.Count - 1)
            {
                _currentScan++;
                NextScanButton.Enabled = _currentScan == _scans.Count - 1 ? false : true;
                PrevScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
        private static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void AnimalsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = AnimalsDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1 && _state != State.None)
                {
                    AnimalsDataGridView.ClearSelection();
                    AnimalsDataGridView.Rows[hti.RowIndex].Selected = true;
                    DataContextMenuStrip.Show(AnimalsDataGridView, e.Location);
                }
            }
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            var animalView = new AnimalView(_controller);
            if (animalView.ShowDialog() == DialogResult.OK)
            {
                var id = 1;
                if(_animals.Count != 0)
                    id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString()) + 1;
                AddAnimal(animalView, id);
                ShowAnimals();
            }
        }

        private void ShowAnimals()
        {
            AnimalsDataGridView.Rows.Clear();
            foreach (var animal in _animals)
                AnimalsDataGridView.Rows.Add(animal.Key[0], animal.Key[10], animal.Key[11], animal.Key[12]);
        }

        private void AnimalsDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = AnimalsDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
                    var animal = _animals.Keys.Where(k => int.Parse(k[0]) == id).FirstOrDefault();
                    new AnimalView(_controller, State.None, animal, _animals[animal]).ShowDialog();
                }
            }
        }

        private void ChangeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
            var animal = _animals.Keys.Where(k => int.Parse(k[0]) == id).FirstOrDefault();
            var animalView = new AnimalView(_controller, State.Update, animal, _animals[animal]);
            if (animalView.ShowDialog() == DialogResult.OK)
            {
                _animals.Remove(animal);
                AddAnimal(animalView, id);
                ShowAnimals();
            }
        }

        private void AddAnimal(AnimalView animalView, int id)
        {
            _animals.Add(new string[] {
                    id.ToString(),
                    animalView.Category,
                    animalView.Sex,
                    animalView.Breed,
                    animalView.Size.ToString(),
                    animalView.Wool,
                    animalView.Color,
                    animalView.Ears,
                    animalView.Tail,
                    animalView.SpecialSigns,
                    animalView.IdentificationLabel,
                    animalView.ChipNumber,
                    animalView.Locality
                }, animalView.Scans);
        }

        private void DeleteAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
            var animal = _animals.Keys.Where(k => int.Parse(k[0]) == id).FirstOrDefault();
            _animals.Remove(animal);
            ShowAnimals();
        }

        private void DelScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_scans.Count > 0)
            {
                _scans.RemoveAt(_currentScan);
                if (_scans.Count == 0)
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ChectFields())
            {
                var act = new string[] {
                        ContractsComboBox.SelectedItem.ToString(),
                        OrgsComboBox.SelectedItem.ToString(),
                        DateOfCapDateTimePicker.Value.ToString()
                    };
                if (_state == State.Insert)
                {
                    _controller.CreateAct(act, _scans, _animals);
                    Close();
                }
                else if(_state == State.Update)
                {
                    _controller.UpdateAct(int.Parse(_act[0]), act, _scans, _animals);
                    Close();
                }
            }
        }

        private bool ChectFields()
        {
            var dialogRes = DialogResult.No;
            if (ContractsComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран кнотракт.");
            else if (OrgsComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбрана организация.");
            else if(AnimalsDataGridView.RowCount == 0)
                dialogRes = ShowErrorMessage("Не добавлены животные.");
            return dialogRes == DialogResult.No;
        }
    }
}
