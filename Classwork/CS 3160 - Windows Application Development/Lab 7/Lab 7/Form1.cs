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
using StdDialog;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        private Image appLogo; //stored image for display
        public Form1()
        {
            InitializeComponent();

            //Code from Dr. Carlson to get image from folder
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("Lab_7.Daftart.jpg");
            appLogo = Image.FromStream(myStream);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richText.Font = fontDialog.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new StdDialog.AboutBox(appLogo, "Simple Text Editor", "Copyright 2020", "Connor Caudill & Kody Williamson");
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On form load, splash screen is displayed to user for 5 seconds
            Form SplashScreen = new Splash(appLogo, "Simple Text Editor", "Copyright 2020", "Connor Caudill & Kody Williamson", 5000);
            SplashScreen.ShowDialog();
        }
    }
}
