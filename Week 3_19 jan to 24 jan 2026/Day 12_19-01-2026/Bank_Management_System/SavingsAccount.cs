using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Management_System
{
    internal class SavingsAccount:BankAccount
    {
        private double interestRate = 0.05;

        public SavingsAccount(int accNo, string name, double bal)
            : base(accNo, name, bal) { }

        public void CalculateInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            Console.WriteLine($"Interest Added: {interest}");
        }
    }
}
