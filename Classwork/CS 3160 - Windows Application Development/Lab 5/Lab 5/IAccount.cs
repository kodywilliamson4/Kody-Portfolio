using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    interface IAccount
    {
        void Credit(decimal amt);
        bool Debit(decimal amt);
        decimal Balance { get; }
    }
}
