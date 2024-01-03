using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        // This (app) refers to the object that contains the application
        // logic.
        private PhoneApp app = new PhoneApp();
        ArrayList phones;
        private string fileName;
        bool change = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Try to add a new phone number to the list
            try
            {
                PhoneForm frm = new PhoneForm("","");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    app.NewPhone(frm.NewPhone);
                    this.lstNames.Items.Add(frm.NewPhone);
                    this.lstNames.SelectedIndex = 0;
                    change = true;
                    app.Modified();
                    phones = app.getList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.  This will generate the Closing event
            // to write out the data.
            this.Close();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the phone number for the selected name.
            this.txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.errorFlag = false;

            // This presentation tier maintains phone information in
            // the list box.  The ArrayList is needed temporarily to
            // copy the phones from the business tier.
            phones = app.getList();
            // Add each phone in the array list to the list box
            foreach (Phone ph in phones)
                lstNames.Items.Add(ph);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This is called whenever the main form is closed
            // and causes the file to be written.
            if (change == true)
            {
                string message = "You have unsaved changes. Do you want to save these changes?";
                string title = "Unsaved Changes";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, title, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!Program.errorFlag) app.WritePhones(fileName);
                }
            }
        }

        private void mnuMerge_Click(object sender, EventArgs e)
        {
            this.fileName = "";
            // Set the filter for the open file dialog
            this.dlgOpenFile.Filter = DataAccess.FileFilter;
            // Get the name of the input file
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
                this.fileName = this.dlgOpenFile.FileName;
            else
            {
                Program.errorFlag = true;
                this.Close();
            }
            phones = app.ReadPhones(this.fileName);

            foreach (Phone p in phones)
            {
                this.lstNames.Items.Add(p);
            }
            if (this.lstNames.Items.Count > 0)
                this.lstNames.SelectedIndex = 0;

            //Enabling buttons
            mnuRemove.Enabled = true;
            mnuSave.Enabled = true;
            mnuEdit.Enabled = true;
            change = true;
            app.Modified();
            phones = app.getList();
            updateList();
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Phone remove = (Phone)lstNames.SelectedItem;
                app.RemovePhone(remove);
                change = true;
                app.Modified();
                phones = app.getList();
                updateList();

            }

        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            // Try to add a new phone number to the list
            try
            {
                PhoneForm frm = new PhoneForm("","");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    app.NewPhone(frm.NewPhone);
                    this.lstNames.Items.Add(frm.NewPhone);
                    this.lstNames.SelectedIndex = 0;
                } 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            change = true;
            app.Modified();
            //Enabling buttons
            mnuSave.Enabled = true;
            mnuEdit.Enabled = true;
            mnuRemove.Enabled = true;
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            Phone edit = (Phone)lstNames.SelectedItem;
            app.EditPhone(edit);
            phones = app.getList();
            updateList();
            change = true;
            app.Modified();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            this.fileName = "";
            // Set the filter for the open file dialog
            this.dlgOpenFile.Filter = DataAccess.FileFilter;
            // Get the name of the input file
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
                this.fileName = this.dlgOpenFile.FileName;
            else
            {
                Program.errorFlag = true;
                this.Close();
            }

            app.WritePhones(this.fileName);
            change = false;
            app.Saved();
        }

        private void PhoneNumberDisplay()
        {
            txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumber;
        }

        private void lstNames_SelectedValueChanged(object sender, EventArgs e)
        {
            PhoneNumberDisplay();
        }

        private void updateList()
        {
            //Clears listbox and repopulates it
            lstNames.Items.Clear();
            foreach (Phone ph in phones)
                lstNames.Items.Add(ph);
        }
    }
}
