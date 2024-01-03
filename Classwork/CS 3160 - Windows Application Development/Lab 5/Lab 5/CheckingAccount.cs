using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    class CheckingAccount : Account, IAccount
    {
        //Varaible to hold specified fee
        public decimal Fee;

        //Constructor for checking account
        public CheckingAccount(string name, decimal amt, decimal feeamt)
        {
            this.owner = name;
            this.balance = amt;
            Fee = feeamt;
        }

        //Function credits money to specified checking account
        public void Credit(decimal amt)
        {
            this.balance += amt;
            this.balance -= Fee;
        }

        //Function debits money from specified checking account, checks if enough money available
        public bool Debit(decimal amt)
        {
            if ((amt + Fee) < this.balance)
            {
                this.balance -= amt;
                this.balance -= Fee;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Returns balance
        public decimal Balance { get { return balance; } }

        //ToString override function
        public override string ToString()
        {
            return ($"Checking: {this.owner, -37} {this.Balance, 10:C2}");
        }
    }
}
