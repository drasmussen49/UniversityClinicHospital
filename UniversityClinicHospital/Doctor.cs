using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public Doctor(string name, int ID, string specialty) : base(name, ID)
        {
            Specialty = specialty;
            Salary = 95000;
        }
        public void DrawBlood()
        {
           
        }
        public void CareForPatient()
        {

        }
    }
}
