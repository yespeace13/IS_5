using IS_5.Model;
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
    public partial class ContentPlanView : Form
    {
        PlanController _planController;
        List<ContentPlan> content;
        List<TextBox> textboxes;
        List<ComboBox> comboboxes;
        List<CheckBox> checkboxes;
        List<Label> labels;
        List<TableLayoutPanel> tabs;
        int days;
        bool neww;
        public ContentPlanView(string month, int days, PlanController _planController)
        {
            InitializeComponent();
            this.Text = month;
            this.days = days;
            this._planController = _planController;
            neww = true;
            MakeLists();
            FillComboLabel(comboboxes, labels);
        }
        public ContentPlanView(List<ContentPlan> content, string month, int days, PlanController _planController)
        {
            InitializeComponent();
            this.Text = month;
            this.days = days;
            this._planController = _planController;
            this.content = content;
            neww = false;
            MakeLists();
            FillComboLabel(comboboxes, labels);
            FillTextCheck(textboxes, checkboxes);
        }

        private void MakeLists()
        {
            textboxes = new List<TextBox>()
            { textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8,
              textBox9,textBox10,textBox11,textBox12,textBox13,
              textBox14,textBox15,textBox16,textBox17,textBox18,
              textBox19,textBox20,textBox21,textBox22,textBox23,
              textBox24,textBox25,textBox26,textBox27,textBox28,
              textBox29,textBox30,textBox31
            };
            comboboxes = new List<ComboBox>()
            {
                comboBox1,comboBox2,comboBox3,comboBox4,comboBox5,comboBox6,
                comboBox7,comboBox8,comboBox9,comboBox10,comboBox11,
                comboBox12,comboBox13,
                comboBox14,comboBox15,comboBox16,comboBox17,comboBox18,
                comboBox19,comboBox20,comboBox21,comboBox22,
                comboBox23, comboBox24,comboBox25,comboBox26,
                comboBox27,comboBox28,comboBox29,comboBox30,comboBox31
            };
            checkboxes = new List<CheckBox>()
            {
                checkBox1,checkBox2,checkBox3,checkBox4,
                checkBox5,checkBox6,checkBox7,checkBox8,checkBox9,
                checkBox10,checkBox11,checkBox12,checkBox13,
                checkBox14,checkBox15,checkBox16,checkBox17,checkBox18,
                checkBox19,checkBox20,checkBox21,checkBox22,
                checkBox23, checkBox24, checkBox25,checkBox26,
                checkBox27,checkBox28,checkBox29,checkBox30, checkBox31
            };
            labels = new List<Label>()
            {
                label1, label2, label3, label4, label5, label6,
                label7, label8, label9, label10, label11,
                label12, label13, label14, label15, label16,
                label17, label18, label19, label20, label21, label22,
                label23, label24, label25, label26,
                label27, label28, label29, label30, label31
            };
            tabs = new List<TableLayoutPanel>()
            {
                tableLayoutPanel30, tableLayoutPanel31, tableLayoutPanel32
            };
        }
        private void FillTextCheck(List<TextBox> text, List<CheckBox> check)
        {
            foreach (var item in content)
            {
                textboxes[item.Day - 1].Text = item.Address;
                checkboxes[item.Day - 1].Checked = item.Check;
                comboboxes[item.Day - 1].Text = item.Locality.Name;
            }
        }

        private void FillComboLabel(List<ComboBox> combo, List<Label> label)
        {
            var locs = _planController.ShowLocalitys();

            for (int i = 0; i < combo.Count; i++)
            {
                combo[i].Items.Insert(0, "-");
                combo[i].SelectedIndex = 0;
                combo[i].DropDownStyle = ComboBoxStyle.DropDownList;
                foreach (var item in locs)
                {
                    combo[i].Items.Insert(item.Id, item.Name);
                }
                label[i].Text = (i + 1).ToString();
            }
            for (int i = 0; i < (31 - days); i++)
            {
                tabs[2-i].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ContentPlan> contentPlans = new List<ContentPlan>();
            for (int i = 0; i < days; i++)
            {
                if (neww)
                {
                    
                    if (comboboxes[i].Text != "-" && textboxes[i].Text != string.Empty)
                    {
                        var loc = new Locality(comboboxes[i].SelectedIndex, comboboxes[i].Text);
                        contentPlans.Add(new ContentPlan(int.Parse(labels[i].Text), loc, textboxes[i].Text,
                            checkboxes[i].Checked));
                    }
                }
                else
                {
                    if (comboboxes[i].Text != "-" && textboxes[i].Text != string.Empty)
                    {
                        var loc = new Locality(comboboxes[i].SelectedIndex, comboboxes[i].Text);
                        content.Add(new ContentPlan(int.Parse(labels[i].Text), loc, textboxes[i].Text,
                            checkboxes[i].Checked));
                    }
                }
            }
            if (contentPlans.Count > 0)
            {
                _planController.CreateUpdateContent(contentPlans);
                DialogResult = DialogResult.OK;
            }
            this.Close();
                
        }
    }
}