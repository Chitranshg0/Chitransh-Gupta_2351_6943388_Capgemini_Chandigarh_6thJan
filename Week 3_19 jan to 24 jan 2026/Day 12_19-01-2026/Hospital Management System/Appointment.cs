using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Appointment
    {
        public Patient Patient;
        public Doctor Doctor;
        public DateTime Date;

        public Appointment(Patient p, Doctor d, DateTime date)
        {
            Patient = p;
            Doctor = d;
            Date = date;
        }

        public void Display()
        {
            Console.WriteLine($"Appointment on {Date} - Patient:{Patient.Name} Doctor:{Doctor.Name}");
        }
    }
}
