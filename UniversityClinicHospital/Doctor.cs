using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public Doctor() : base("Dr. House", 1000, 90000)
        {
            Specialty = "Heart Specialist";
        }
        public void DrawBlood()
        {
           
        }
        public void CareForPatient()
        {

        }
    }
}
