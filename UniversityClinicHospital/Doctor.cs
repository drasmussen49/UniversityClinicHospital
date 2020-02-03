using System;
using System.Collections.Generic;
using System.IO;
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
        public override void PrintInfo()
        {
            int s = 9988888;
            // Console.WriteLine($"Position: {Specialty} Doctor  Name: {Name}  EmployeeID: {EmployeeID}  Salary:${Salary}  Been Paid?: {HasBeenPaid}");

            Console.WriteLine("\t\t");
            Console.WriteLine("___________________________________________________________________________________________________________________________________");
            Console.WriteLine("|   Position   |               | Employee Name |                | EmployeeID |               | Salary |               | Been Paid |");
            Console.WriteLine("___________________________________________________________________________________________________________________________________");

            Console.WriteLine("    " + Specialty + "                          " + Name + "                            " + EmployeeID + "                        " + Salary + "                      " + HasBeenPaid);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

        }

        public static void createdatafile(string path, string[] lines)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (string line in lines)
                sw.WriteLine(line);
            sw.Close();
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
