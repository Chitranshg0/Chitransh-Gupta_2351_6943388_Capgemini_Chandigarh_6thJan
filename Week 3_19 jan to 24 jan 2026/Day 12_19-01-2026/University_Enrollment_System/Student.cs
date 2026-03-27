using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Student :Person
    {
        public List<Course> Courses = new List<Course>();

        public Student(int id, string name) : base(id, name) { }

        public void Enroll(Course c)
        {
            Courses.Add(c);
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Role: Student");
            Console.WriteLine("Courses:");
            foreach (var c in Courses)
                Console.WriteLine(c.CourseName);
        }
    }
}
