//File: Form2.cs
//Authors: Caudill, Connor; Williamson, Kody
//Class: CS 3160
//Instrcutor: Jadwiga Carlson
//Date: 23 March 2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form2 : Form
    {
        //From varibales that will be passed back to Form1
        string[] values = new string[8];
        int temp = 0;



        public string Year
        {
            get { return values[0]; }
        }

        public string Month
        {
            get { return values[1]; }
        }

        public string Day
        {
            get { return values[2]; }
        }

        public string StHour
        {
            get { return values[3]; }
        }

        public string StMin
        {
            get { return values[4]; }
        }

        public string EndHour
        {
            get { return values[5]; }
        }

        public string EndMin
        {
            get { return values[6]; }
        }

        public string Desc
        {
            get { return values[7]; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Seeting the max and min dates as the last day of the current year, and today, respectively.
            DateTime max = new DateTime(DateTime.Today.Year, 12, 31);
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxDate = max;

            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adding all the encessary data to an array so it can easily be accessed by Form1
            values[0] = monthCalendar1.SelectionStart.Year.ToString();
            values[1] = monthCalendar1.SelectionStart.Month.ToString();
            values[2] = monthCalendar1.SelectionStart.Day.ToString();
            if (cmbStartAM.Text == "PM")
            {
                //PM times need to have their difference from AM accounted for here
                temp = Int32.Parse(cmbStartHour.Text) + 12;
                values[3] = temp.ToString();
            }
            else
            {
                values[3] = cmbStartHour.Text;
            }
            values[4] = cmbStartMin.Text;
            if (cmbEndAM.Text == "PM")
            {
                temp = Int32.Parse(cmbEndHour.Text) + 12;
                values[5] = temp.ToString();
            }
            else
            {
                values[5] = cmbEndHour.Text;
            }
            values[6] = cmbEndMin.Text;
            values[7] = txtDesc.Text;
        }

        private void cmbStartHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
