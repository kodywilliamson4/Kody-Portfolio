using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    class SavingsAccount : Account, IAccount
    {
        //Varaible to hold specified interest rate
        public decimal interestRate;

        //Constructor for savings account
        public SavingsAccount(string name, decimal amt, decimal interest)
        {
            this.owner = name;
            interestRate = interest;
            this.balance = amt;
        }

        //Function credits money to specified savings account
        public void Credit(decimal amt)
        {
            this.balance += amt;
        }

        //Function debits money from specified savings account, checks if enough money available
        public bool Debit(decimal amt)
        {
            if (amt < this.balance)
            {
                this.balance -= amt;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Returns account balance
        public decimal Balance { get { return balance; } }

        //ToString override function
        public override string ToString()
        {
            return ($"Savings:   {this.owner, -37} {this.Balance, 10:C2}");
        }

        //Function calculates the interest on an account
        public decimal CalculateInterest()
        {
            decimal dailyint = interestRate / 360;

            return dailyint * balance;
        }
    }
}
