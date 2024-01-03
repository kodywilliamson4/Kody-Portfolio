using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FieldExceptionForm : Form
    {
        public FieldExceptionForm(MyFieldException exception)
        {
            txtMsg.Text = exception.Message;
            txtField.Text = exception.GetField();
            txtVal.Text = exception.GetVal();
            InitializeComponent();
        }

        private void FieldExceptionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
