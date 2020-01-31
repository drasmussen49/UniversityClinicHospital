using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public Doctor()
        {

        }
        public Doctor(string name, int ID, string specialty) : base(name, ID)
        {
            Specialty = specialty;
            Salary = 95000;
        }
        public override void DrawBlood(Patient myPatient)
        {
            if (myPatient.BloodLevel > 2)
            {
                myPatient.BloodLevel -= 2;
            }
            else
            {
                Console.WriteLine("The patient doesn't have enough blood to draw!");
            }
        }
        public override void CareForPatient(Patient myPatient)
        {
            if (myPatient.HealthStatus < 85)
            {
                myPatient.HealthStatus += 15;
            }
            else
            {
                myPatient.HealthStatus = 100;
                Console.WriteLine("The patient is perfectly healthy!");

            }
        }
    }
}
