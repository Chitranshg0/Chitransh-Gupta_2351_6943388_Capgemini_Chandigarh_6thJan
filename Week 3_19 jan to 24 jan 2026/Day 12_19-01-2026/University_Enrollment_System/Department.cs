using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Department
    {
        public string DeptName;
        public List<Course> Courses = new List<Course>();

        public Department(string name)
        {
            DeptName = name;
        }
    }
}
