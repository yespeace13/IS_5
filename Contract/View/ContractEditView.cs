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
    public partial class ContractEditView : Form
    {
        private ContractController _controller;
        private string[] _contract;
        private State _state;
        public ContractEditView(ContractController controller, State state, int id = -1)
        {
            InitializeComponent();
            _controller = controller;
            _state = state;

            //if (state == State.Update) 
            //{
            //    _contract = _controller.ShowContract(id);
            //    FillFields();

            //}
            //else if(state == State.None)
            //{
            //    _contract = _controller.ShowContract(id);
            //    FillFields();
            //    ChangeEnable();
            //}
        }

        private void ChangeEnable()
        {
            NumberTextBox.Enabled = false;
            TypeOrganizationComboBox.Enabled = false;
            OkButton.Visible = false;
            CancelButton.Text = "Закрыть";
        }

        //private bool CheckFilds()
        //{
        //var dialogRes = DialogResult.No;
        //if (string.IsNullOrEmpty(NumberTextBox.Text)) 
        //    dialogRes = ShowErrorMessage("Не заполнено название.");
        //else if (string.IsNullOrEmpty(TaxIdenNumTextBox.Text))
        //    dialogRes = ShowErrorMessage("Не заполнен ИНН.");
        //else if (string.IsNullOrEmpty(KPPTextBox.Text))
        //    dialogRes = ShowErrorMessage("Не заполнен КПП.");
        //else if (string.IsNullOrEmpty(AddressTextBox.Text))
        //    dialogRes = ShowErrorMessage("Не заполнен адрес.");
        //else if (TypeOrganizationComboBox.SelectedIndex == -1)
        //    dialogRes = ShowErrorMessage("Не выбран тип организации.");
        //else if (TypeOwnerComboBox.SelectedIndex == -1)
        //    dialogRes = ShowErrorMessage("Не выбран вид организации.");
        //else if (LocalityComboBox.SelectedIndex == -1)
        //    dialogRes = ShowErrorMessage("Не выбран муниципалитет.");
        //return dialogRes == DialogResult.No;
        //}

        private static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //if (CheckFilds())
            //{
            //    if (_state == State.Insert)
            //    {
            //        _controller.CreateContract(NameOrgTextBox.Text,
            //            TaxIdenNumTextBox.Text,
            //            KPPTextBox.Text,
            //            AddressTextBox.Text,
            //            TypeOrganizationComboBox.SelectedItem.ToString(),
            //            TypeOwnerComboBox.SelectedItem.ToString(),
            //            LocalityComboBox.SelectedItem.ToString());
            //    }
            //    else
            //    {
            //        _controller.UpdateContract(_contract[0],
            //            NameOrgTextBox.Text, TaxIdenNumTextBox.Text, KPPTextBox.Text,
            //            AddressTextBox.Text,
            //            TypeOrganizationComboBox.SelectedItem.ToString(),
            //            TypeOwnerComboBox.SelectedItem.ToString(),
            //            LocalityComboBox.SelectedItem.ToString());
            //    }
            //    Close();
            //}
        }

        private void FillFields()
        {
        //    NumberTextBox.Text = _contract[1];
        //    TaxIdenNumTextBox.Text = _contract[2];
        //    KPPTextBox.Text = _contract[3];
        //    AddressTextBox.Text = _contract[4];
        //    TypeOrganizationComboBox.SelectedItem = _contract[5];
        //    TypeOwnerComboBox.SelectedItem = _contract[6];
        //    LocalityComboBox.SelectedItem = _contract[7];
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();
        
    }
}
