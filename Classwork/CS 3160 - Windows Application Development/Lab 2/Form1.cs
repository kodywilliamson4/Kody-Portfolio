//Created by: Connor Caudill, Kody Williamson
//Class: CS3160
//Date: 2/28/2019
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

namespace Lab_2
{

    public partial class Form1 : Form

    {
        private int formItem;
        private int formSize;
        private decimal formCharge = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Creates menu item group box
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public class PurchasedItem
        {
            //Creating initial variables for the item purchased
            private string[] itemStr = { "Sandwich", "Fries", "Soft Drink", "Water" };
            private string[] itemSize = { "S", "M", "L" };
            private int Item;
            private int Size;
            private int Quantity;
            private static decimal[,] itemCost;
            private static string format;

            //Creating the constructor for the purchased item, takes three integers as arguments
            public PurchasedItem(int i, int s, int q)
            {
                Item = i;
                Size = s;
                Quantity = q;
            }

            //Creating matrix with item prices
            static PurchasedItem()
            {
                format = "{0,2} {1,1} {2,-15} {3,10:C}";
                itemCost = new decimal[4, 3]
                {
                     {2.50M, 3.00M, 3.50M},
                     {0.99M, 1.29M, 1.49M},
                     {1.29M, 1.40M, 1.60M},
                     {0.00M, 0.00M, 0.00M}
                };
            }

            //Function calculates cost of the items ordered in on instance, returns cost
            public decimal Cost
            {
                get { return (itemCost[Item, Size] * Quantity); }
            }

            //Overrides ToString to return the quantity of this item, the size, the item, and then the cost of the item(s)
            public override string ToString()
            {
                return String.Format(format, Quantity.ToString(), itemSize[Size], itemStr[Item], Cost);
            }
        }

        //Function automatically selects small when water is selected, disables other sizes, and allows quantity input as well as ordering
        private void radWater_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Enabled = true;
            radMedium.Enabled = false;
            radLarge.Enabled = false;
            radSmall.Checked = true;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
            formItem = 3;
            formSize = 0;
            this.cmbQuant.SelectedIndex = 0;
        }

        //Function enables the list of sizes and sets all of the boxes to unchecked
        private void enableSizes()
        {
            radSmall.Enabled = true;
            radMedium.Enabled = true;
            radLarge.Enabled = true;
            radSmall.Checked = false;
            radMedium.Checked = false;
            radLarge.Checked = false;
        }

        //Function disables quantity box and order button when sandwich is selected but allows size selection
        private void radSandwich_CheckedChanged(object sender, EventArgs e)
        {
            //Calls enableSizes function to allow size selection
            enableSizes();

            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 0;
        }

        //Function disables quantity box and order button when fries are selected but allows size selection
        private void radFries_CheckedChanged(object sender, EventArgs e)
        {
            //Calls enableSizes function to allow size selection
            enableSizes();

            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 1;
        }

        //Function disables quantity box and order button when soft drink is selected but allows size selection
        private void radSoft_CheckedChanged(object sender, EventArgs e)
        {
            //Calls enableSizes function to allow size selection
            enableSizes();

            cmbQuant.Enabled = false;
            btnOrder.Enabled = false;
            formItem = 2;
        }

        //Function enables quantity box and order button when size small is selected, sets quantity to one
        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 0;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
            this.cmbQuant.SelectedIndex = 0;
        }

        //Function enables quantity box and order button when size medium is selected, sets quantity to one
        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 1;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
            this.cmbQuant.SelectedIndex = 0;
        }

        //Function enables quantity box and order button when size large is selected, sets quantity to one
        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            formSize = 2;
            cmbQuant.Enabled = true;
            btnOrder.Enabled = true;
            this.cmbQuant.SelectedIndex = 0;
        }

        //Function enables the delete button when the first order has been created
        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        //Function creates a new order from given values input by user and updates quantities
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Creates new purchased item
            PurchasedItem order = new PurchasedItem(formItem, formSize, cmbQuant.SelectedIndex+1);

            //Updates total cost of orders
            formCharge += order.Cost;

            //Adds order description to the text box of total orders
            lblTotal.Text = formCharge.ToString("C");
            lstOrder.Items.Add(order.ToString());
        }

        //Deletes the selected order from the text box as well as the total cost, then disables delete button again
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = 0;
            string chargeChange = "";
            string hold = lstOrder.SelectedItem.ToString();
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex);
            hold = hold.Substring(20);
            length = hold.Length;
            for (int i = 0; i < length; i++)
            {
                if (Char.IsDigit(hold[i]) || hold[i] == '.')
                {
                    chargeChange += hold[i];
                } 
            }
            formCharge -= Convert.ToDecimal(chargeChange);
            lblTotal.Text = formCharge.ToString("C");
            btnDelete.Enabled = false;
        }
    }
}
