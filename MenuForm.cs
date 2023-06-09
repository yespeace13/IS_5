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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OrganizationView().ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Contractview().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Actview().ShowDialog();
        }
    }
}
