using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public bool HasBeenPaid { get; set; }

        public Employee(string name, int employeeID, int salary, bool hasBeenPaid = false)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
            HasBeenPaid = hasBeenPaid;
        }
        public void PaySalary()
        {
            HasBeenPaid = true;
        }
    }
}
