using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Professor :Person
    {
        public List<Course> TeachingCourses = new List<Course>();

        public Professor(int id, string name) : base(id, name) { }

        public void AssignCourse(Course c)
        {
            TeachingCourses.Add(c);
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Role: Professor");
            Console.WriteLine("Teaching Courses:");
            foreach (var c in TeachingCourses)
                Console.WriteLine(c.CourseName);
        }
    }
}
