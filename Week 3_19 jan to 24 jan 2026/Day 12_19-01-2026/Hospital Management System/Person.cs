using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Person
    {
        private int id;
        private string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id => id;
        public string Name => name;

        public virtual void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }
}
