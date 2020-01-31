using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Receptionist : Employee
    {
        public bool OnPhone { get; set; }
        public Receptionist(string name, int ID) : base(name, ID)
        {
            OnPhone = false;
            Salary = 45000;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Position: Receptionist  Name: {Name}  EmployeeID: {EmployeeID}  Salary:${Salary}  On Phone?: {OnPhone}  Been Paid?: {HasBeenPaid}");
        }
    }
}
