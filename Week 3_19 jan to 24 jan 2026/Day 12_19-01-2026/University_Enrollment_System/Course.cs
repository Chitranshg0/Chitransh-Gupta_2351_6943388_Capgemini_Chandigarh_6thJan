using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Course
    {
        public int CourseId;
        public string CourseName;

        public Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }
    }
}
