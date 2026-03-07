namespace Bank_Management_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Select Account Type: 1-Savings  2-Checking");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double bal = double.Parse(Console.ReadLine());

            BankAccount account;

            if (choice == 1)
                account = new SavingsAccount(accNo, name, bal);
            else
                account = new CheckingAccount(accNo, name, bal);

            Console.WriteLine("1-Deposit  2-Withdraw  3-Display  4-Interest");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Enter Amount: ");
                    account.Deposit(double.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Enter Amount: ");
                    account.Withdraw(double.Parse(Console.ReadLine()));
                    break;

                case 3:
                    account.Display();
                    break;

                case 4:
                    if (account is SavingsAccount sa)
                        sa.CalculateInterest();
                    else
                        Console.WriteLine("Interest not applicable");
                    break;
            }

            account.Display();
        }
    }
}
