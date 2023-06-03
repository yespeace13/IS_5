using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class LocalPriceView : Form
    {
        private ContractController _controller;
        public string Locality { get; set; }
        public decimal Price { get; set; }
        public LocalPriceView(ContractController controller, string name, decimal price)
        {
            InitializeComponent();
            _controller = controller;
            FillLocalitys();
            LocalityComboBox.SelectedItem = name;
            PriceNumericUpDown.Value = price;
            Locality = name;
            Price = price;
        }

        private void FillLocalitys()
        {
            LocalityComboBox.Items.AddRange(_controller.ShowLocalitys());
        }

        public LocalPriceView(ContractController controller)
        {
            InitializeComponent();
            _controller = controller;
            FillLocalitys();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (LocalityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран муниципальный район.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            else
            {
                Locality = LocalityComboBox.SelectedItem.ToString();
                Price = PriceNumericUpDown.Value;
                Close();
            }
        }
    }
}
