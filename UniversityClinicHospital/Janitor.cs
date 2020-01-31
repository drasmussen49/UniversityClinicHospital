using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Janitor : Employee
    {
        public bool IsSweeping { get; set; }
        public Janitor(string name, int ID) : base(name, ID)
        {
            IsSweeping = false;
            Salary = 40000;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Position: Janitor  Name: {Name}  EmployeeID: {EmployeeID}  Salary:${Salary}  Is Sweeping?:{IsSweeping}  Been Paid?: {HasBeenPaid}");
        }
    }
}
