using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Management_System
{
    internal class BankAccount
    {
        protected int accountNumber;
        protected string accountHolder;
        protected double balance;

        public BankAccount(int accNo, string name, double bal)
        {
            accountNumber = accNo;
            accountHolder = name;
            balance = bal;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient Balance");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Account No: {accountNumber}");
            Console.WriteLine($"Name: {accountHolder}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
