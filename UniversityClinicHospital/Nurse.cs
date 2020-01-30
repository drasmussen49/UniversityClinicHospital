using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse(string name, int ID, int numOfPatients) : base(name, ID)
        {
            numOfPatients = NumberOfPatients;
            Salary = 50000;
        }
        public void DrawBlood()
        {

        }
        public void CareForPatient()
        {

        }
    }
}
