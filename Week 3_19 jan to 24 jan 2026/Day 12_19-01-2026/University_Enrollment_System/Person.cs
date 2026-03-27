using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
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

        public int Id { get { return id; } }
        public string Name { get { return name; } }

        public virtual void DisplayProfile()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }
}
