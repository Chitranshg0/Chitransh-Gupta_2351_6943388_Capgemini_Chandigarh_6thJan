using System;

namespace RupeeCount
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Amount ");
            int input = int.Parse(Console.ReadLine());
            Rupee obj = new Rupee();
            int output = obj.CountNotes(input);
            Console.WriteLine("Output ");
            Console.WriteLine(output);
        }
    }
}
