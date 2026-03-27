using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Nurse : Person
    {
        public string Ward;

        public Nurse(int id, string name, string ward) : base(id, name)
        {
            Ward = ward;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Nurse");
            Console.WriteLine($"Ward: {Ward}");
        }
    }
}
