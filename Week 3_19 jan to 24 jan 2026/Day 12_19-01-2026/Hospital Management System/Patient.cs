using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Patient :Person 
    {
        private List<MedicalRecord> records = new List<MedicalRecord>();

        public Patient(int id, string name) : base(id, name) { }

        public void AddRecord(MedicalRecord record)
        {
            records.Add(record);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Patient");
            foreach (var r in records)
                Console.WriteLine($"Diagnosis: {r.Diagnosis}");
        }
    }
}
