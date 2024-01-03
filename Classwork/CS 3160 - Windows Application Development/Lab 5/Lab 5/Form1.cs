//Authors: Caudill, Connor; Williamson, Kody
//Class: CS3160
//Date: 25 April 2020
//Instructor: Prof. Carlson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        InterstellarBank bank;
        public Form1()
        {
            InitializeComponent();
        }

        //Button to allow interest to be calculated and added/check if interest can be added
        private void btnInterest_Click(object sender, EventArgs e)
        {
            if(lstAcc.SelectedItem is SavingsAccount)
            {
                SavingsAccount holder = (SavingsAccount)lstAcc.SelectedItem;
                holder.Credit(holder.CalculateInterest());
            }
            else
            {
                txtMess.Text = "Cannot add interest to CheckingAccount";
            }
            UpdateBox();
            btnInterest.Enabled = false;
        }

        //Loads the form while also populating the bank arraylist
        private void Form1_Load(object sender, EventArgs e)
        {
            bank = new InterstellarBank();
            bank.AddChecking("Smith", 1000, 1.0M);
            bank.AddSavings("Smith", 23456, 0.03M);
            bank.AddChecking("Jones", 234, 1.0M);
            bank.AddSavings("Jones", 10000, 0.02M);
            bank.AddChecking("Doe", 124, 1.0M);
            UpdateBox();
        }

        //Updates the account selected if correct inputs are given to update the account
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal amt;
            if (!decimal.TryParse(txtAmount.Text, out amt))
            {
                txtMess.Text = "Must input valid number in Amount box";
            }
            else
            {
                if (lstAcc.SelectedItem is SavingsAccount)
                {
                    SavingsAccount holder = (SavingsAccount)lstAcc.SelectedItem;
                    if (cmbTrans.Text == "Credit")
                    {
                        holder.Credit(amt);
                        txtMess.Text = $"{amt} credited to account";
                    }
                    else
                    {
                        if (!holder.Debit(amt))
                        {
                            txtMess.Text = "Insufficient funds, no money debited";
                        }
                        else
                        {
                            txtMess.Text = $"{amt} debited from account";
                        }
                    }
                }
                else if (lstAcc.SelectedItem is CheckingAccount)
                {
                    CheckingAccount holder = (CheckingAccount)lstAcc.SelectedItem;
                    if (cmbTrans.Text == "Credit")
                    {
                        holder.Credit(amt);
                        txtMess.Text = $"{amt} credited to account";
                    }
                    else
                    {
                        if (!holder.Debit(amt))
                        {
                            txtMess.Text = "Insufficient funds, no money debited";
                        }
                        else
                        {
                            txtMess.Text = $"{amt} debited from account";
                        }
                    }
                }
            }
            UpdateBox();
            btnUpdate.Enabled = false;
            cmbTrans.Text = "";
            txtAmount.Text = "";
        }

        //Exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Function to update listbox after changes are made
        private void UpdateBox()
        {
            btnUpdate.Enabled = false;
            btnInterest.Enabled = false;
            lstAcc.Items.Clear();
            var iter = bank.GetEnumerator();
            while (iter.MoveNext())
            {
                lstAcc.Items.Add(iter.Current);
            }
        }

        //If listbox selection changes, this triggers to update the form
        private void lstAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnInterest.Enabled = true;
            txtMess.Text = "";
        }
    }
}
