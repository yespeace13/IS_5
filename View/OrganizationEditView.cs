using IS_5.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.View
{
    public partial class OrganizationEditView : Form
    {
        private OrganizationController _controller;
        private string[] _organization;
        private State _state;
        public OrganizationEditView(OrganizationController controller, State state, int id = -1)
        {
            InitializeComponent();
            _controller = controller;
            _state = state;

            var typeOrg = _controller.ShowTypesOrganizations();
            var typeOwnOrg = _controller.ShowTypesOwnerOrganizations();
            var localitys = _controller.ShowLocalitys();
            TypeOrganizationComboBox.Items.AddRange(typeOrg);
            TypeOwnerComboBox.Items.AddRange(typeOwnOrg);
            LocalityComboBox.Items.AddRange(localitys);
            if (state == State.Update) 
            {
                _organization = _controller.ShowOrganization(id);
                FillFields();

            }
            else if(state == State.None)
            {
                _organization = _controller.ShowOrganization(id);
                FillFields();
                ChangeEnable();
            }
        }

        private void ChangeEnable()
        {
            NameOrgTextBox.Enabled = false;
            TaxIdenNumTextBox.Enabled = false;
            KPPTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            TypeOrganizationComboBox.Enabled = false;
            TypeOwnerComboBox.Enabled = false;
            LocalityComboBox.Enabled = false;
            OkButton.Visible = false;
            CancelButton.Text = "Закрыть";
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NameOrgTextBox.Text)) 
                dialogRes = ShowErrorMessage("Не заполнено название.");
            else if (string.IsNullOrEmpty(TaxIdenNumTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен ИНН.");
            else if (string.IsNullOrEmpty(KPPTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен КПП.");
            else if (string.IsNullOrEmpty(AddressTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен адрес.");
            else if (TypeOrganizationComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран тип организации.");
            else if (TypeOwnerComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран вид организации.");
            else if (LocalityComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран муниципалитет.");
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
                    _controller.CreateOrganization(NameOrgTextBox.Text,
                        TaxIdenNumTextBox.Text,
                        KPPTextBox.Text,
                        AddressTextBox.Text,
                        TypeOrganizationComboBox.SelectedItem.ToString(),
                        TypeOwnerComboBox.SelectedItem.ToString(),
                        LocalityComboBox.SelectedItem.ToString());
                }
                else
                {
                    _controller.UpdateOrganization(_organization[0],
                        NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
                        AddressTextBox.Text,
                        TypeOrganizationComboBox.SelectedItem.ToString(),
                        TypeOwnerComboBox.SelectedItem.ToString(),
                        LocalityComboBox.SelectedItem.ToString());
                }
                Close();
            }
        }

        private void FillFields()
        {
            NameOrgTextBox.Text = _organization[1];
            TaxIdenNumTextBox.Text = _organization[2];
            KPPTextBox.Text = _organization[3];
            AddressTextBox.Text = _organization[4];
            TypeOrganizationComboBox.SelectedItem = _organization[5];
            TypeOwnerComboBox.SelectedItem = _organization[6];
            LocalityComboBox.SelectedItem = _organization[7];
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();
        
    }
}
