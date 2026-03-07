using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Staff : Person
    {
        public string Department;

        public Staff(int id, string name, string dept) : base(id, name)
        {
            Department = dept;
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Role: Staff");
            Console.WriteLine($"Department: {Department}");
        }
    }
}
