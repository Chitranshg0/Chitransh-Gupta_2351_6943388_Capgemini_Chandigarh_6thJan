using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Doctor : Person
    {
        public string Specialization;

        public Doctor(int id, string name, string spec) : base(id, name)
        {
            Specialization = spec;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Doctor");
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}
