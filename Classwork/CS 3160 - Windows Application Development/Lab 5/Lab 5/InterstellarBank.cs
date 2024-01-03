using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_5
{
    class InterstellarBank
    {
        private ArrayList accountList;

        //Constructor for new bank/accountlist
        public InterstellarBank()
        {
            accountList = new ArrayList();
        }

        //Adds a checking account to the arraylist
        public void AddChecking(string name, decimal amt, decimal fee)
        {
            accountList.Add(new CheckingAccount(name, amt, fee));
        }

        //Adds a savings account to the arraylist
        public void AddSavings(string name, decimal amt, decimal interest)
        {
            accountList.Add(new SavingsAccount(name, amt, interest));
        }

        //Returns each object from the arraylist using iteration
        public IEnumerator GetEnumerator()
        {
            foreach(object obj in accountList)
            {
                yield return obj;
            }
        }
    }
}
