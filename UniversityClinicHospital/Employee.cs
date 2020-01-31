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

        public Employee()
        {

        }
        public Employee(string name, int employeeID)
        {
            Name = name;
            EmployeeID = employeeID;
            HasBeenPaid = false;
        }
        public void PaySalary()
        {
            HasBeenPaid = true;
        }
        public virtual void PrintInfo()
        {

        }
        public virtual void DrawBlood(Patient myPatient)
        {

        }
        public virtual void CareForPatient(Patient myPatient)
        {

        }
    }
}
