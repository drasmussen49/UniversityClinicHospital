using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse()
        {

        }
        public Nurse(string name, int ID, int numOfPatients) : base(name, ID)
        {
            numOfPatients = NumberOfPatients;
            Salary = 50000;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Position: Nurse  Name: {Name}  EmployeeID: {EmployeeID}  Salary:${Salary}  Been Paid? {HasBeenPaid}");
        }
        public override void DrawBlood(Patient myPatient)
        {
            if (myPatient.BloodLevel > 1)
            {
                myPatient.BloodLevel -= 1;
            }
            else
            {
                Console.WriteLine("The patient doesn't have enough blood to draw!");
            }
        }
        public override void CareForPatient(Patient myPatient)
        {
            if (myPatient.HealthStatus < 90)
            {
                myPatient.HealthStatus += 10;
            }
            else
            {
                myPatient.HealthStatus = 100;
                Console.WriteLine("The patient is perfectly healthy!");
            }
        }
    }
}
