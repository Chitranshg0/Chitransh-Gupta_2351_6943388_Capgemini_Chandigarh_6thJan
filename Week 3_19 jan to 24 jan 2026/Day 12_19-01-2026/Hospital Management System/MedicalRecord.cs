using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class MedicalRecord
    {
        private string diagnosis;
        private string treatment;

        public MedicalRecord(string diag, string treat)
        {
            diagnosis = diag;
            treatment = treat;
        }

        public string Diagnosis => diagnosis;
    }
}
