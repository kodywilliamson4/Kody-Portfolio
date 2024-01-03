//Authors: Connor Caudill & Kody Williamson
//Class: CS 3160
//Date: 5/15/2020
//Instructor: Jadwiga Carlson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdDialog
{
    public partial class AboutBox : Form
    {
        public AboutBox(Image img, string title, string copy, string name)
        {
            //Constructor gets image to display and strings to display
            InitializeComponent();
            picImg.Image = img;
            lblTitle.Text = title;
            lblCopy.Text = copy;
            lblName.Text = name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
