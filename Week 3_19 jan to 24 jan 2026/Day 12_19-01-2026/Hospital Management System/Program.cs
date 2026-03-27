namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Register Patient");
            Console.Write("Patient ID: ");
            int pid = int.Parse(Console.ReadLine());
            Console.Write("Patient Name: ");
            string pname = Console.ReadLine();

            Patient patient = new Patient(pid, pname);

            Console.WriteLine("Register Doctor");
            Console.Write("Doctor ID: ");
            int did = int.Parse(Console.ReadLine());
            Console.Write("Doctor Name: ");
            string dname = Console.ReadLine();
            Console.Write("Specialization: ");
            string spec = Console.ReadLine();

            Doctor doctor = new Doctor(did, dname, spec);

            Console.WriteLine("Schedule Appointment (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Appointment app = new Appointment(patient, doctor, date);
            app.Display();

            Console.WriteLine("Add Medical Record");
            Console.Write("Diagnosis: ");
            string diag = Console.ReadLine();
            Console.Write("Treatment: ");
            string treat = Console.ReadLine();

            patient.AddRecord(new MedicalRecord(diag, treat));

            Console.WriteLine("\nPatient Details:");
            patient.Display();
        }
    }
}
