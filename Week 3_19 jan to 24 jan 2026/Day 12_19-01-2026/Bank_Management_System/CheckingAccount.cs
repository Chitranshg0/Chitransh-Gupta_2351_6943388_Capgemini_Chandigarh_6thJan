using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Management_System
{
    internal class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accNo, string name, double bal)
       : base(accNo, name, bal) { }
    }
}
