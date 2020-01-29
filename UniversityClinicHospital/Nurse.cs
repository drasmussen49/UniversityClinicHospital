using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse() : base("Ms. Green", 1001, 50000)
        {
            NumberOfPatients = 10;
        }
        public void DrawBlood()
        {

        }
        public void CareForPatient()
        {

        }
    }
}
