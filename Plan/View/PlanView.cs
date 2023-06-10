using Microsoft.Office.Interop.Excel;
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
    public partial class PlanView : Form
    {
        private IEnumerable<Plan> plan;
        private int lastId;
        public PlanController _planController;
        List<System.Windows.Forms.Button> buttons;
        public PlanView()
        {
            InitializeComponent();
            _planController = new PlanController();
            for (int i = DateTime.Now.Year+2; i > DateTime.Now.Year-20; i--)
            {
                comboBox1.Items.Add(i);
            }
            buttons = new List<System.Windows.Forms.Button> {button1,button2,button3,button4,button5,button6,
            button7,button8,button9,button10,button11,button12};
            comboBox1.SelectedIndex = 2;
            ShowPlans();
        }
        private void ShowPlans()
        {
            plan = _planController.GetPlans(int.Parse(comboBox1.Text));
            lastId = _planController.GetId().Last();
            foreach (var item in plan)
            {
                buttons[item.Month-1].BackColor = Color.SkyBlue;
            }
        }

        private void ClearColors()
        {
            foreach (var item in buttons)
            {
                item.BackColor = SystemColors.Control;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearColors();
            ShowPlans();
        }

        private void ButtonClick(int index)
        {
            ContentPlanView content;

            int daysInMonth = DateTime.DaysInMonth(int.Parse(comboBox1.Text), index);
            if (buttons[index-1].BackColor==SystemColors.Control)
            {
                content = new ContentPlanView(buttons[index-1].Text, daysInMonth, _planController);
                if (content.ShowDialog() == DialogResult.OK)
                {
                    _planController.CreatePlan(lastId + 1, index, int.Parse(comboBox1.Text));
                }
                ShowPlans();
            }
            else
            {
                var singlePlan = plan.Where(p => p.Month == index).ElementAt(0);
                content = new ContentPlanView(singlePlan.ContentsPlan, buttons[index - 1].Text, daysInMonth, _planController);
                content.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClick(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClick(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonClick(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonClick(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonClick(12);
        }
    }
}
