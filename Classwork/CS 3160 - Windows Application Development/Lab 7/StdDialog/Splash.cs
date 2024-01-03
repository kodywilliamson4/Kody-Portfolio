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
    public partial class Splash : Form
    {
        public Splash(Image img, string title, string copy, string name, int time)
        {
            //Constructor for form gets image to display,
            //strings to display, and time for timer interval used to close form
            InitializeComponent();
            picImg.Image = img;
            lblTitle.Text = title;
            lblCopy.Text = copy;
            lblName.Text = name;
            tmeSplash.Interval = time;
        }

        private void tmeSplash_Tick(object sender, EventArgs e)
        {
            //Form lasts 5 seconds, then closes
            this.Close();
        }
    }
}
