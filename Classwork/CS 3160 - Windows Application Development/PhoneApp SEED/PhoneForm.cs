using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    public partial class PhoneForm : Form
    {

        public Phone NewPhone;

        public PhoneForm(string name,string number)
        {
            InitializeComponent();
            txtName.Text = name;
            txtPhone.Text = number;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                NewPhone = new Phone(this.txtName.Text, this.txtPhone.Text);
            }
            catch (Exception exc)
            {
                // If there's an error, just return to the form and allow
                // the user to fix the problem.
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            NewPhone = null;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Phone.ValidateName(txtName.Text) == Phone.FormatError)
            {
                errorPhone.SetError(txtName, "Invalid Name.");
                txtPhone.Enabled = false;
            }
            else
            {
                errorPhone.SetError(txtName, null);
                txtPhone.Enabled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (Phone.ValidatePhoneNumber(txtPhone.Text) == Phone.FormatError)
            {
                errorPhone.SetError(txtPhone, "Invalid Phone Number.");
                btnOK.Enabled = false;
            }
            else
            {
                errorPhone.SetError(txtPhone, null);
                btnOK.Enabled = true;
            }
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
