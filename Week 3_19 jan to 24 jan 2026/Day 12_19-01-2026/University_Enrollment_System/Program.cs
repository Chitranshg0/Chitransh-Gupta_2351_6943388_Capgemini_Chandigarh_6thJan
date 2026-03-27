namespace University_Enrollment_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1-Student  2-Professor  3-Staff");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Person person = null;

            Course c1 = new Course(101, "C# Programming");

            if (choice == 1)
            {
                Student s = new Student(id, name);
                s.Enroll(c1);
                person = s;
            }
            else if (choice == 2)
            {
                Professor p = new Professor(id, name);
                p.AssignCourse(c1);
                person = p;
            }
            else if (choice == 3)
            {
                Console.Write("Enter Department: ");
                string dept = Console.ReadLine();
                person = new Staff(id, name, dept);
            }

            Console.WriteLine("\nProfile Details:");
            person.DisplayProfile();
        }
    }
}
