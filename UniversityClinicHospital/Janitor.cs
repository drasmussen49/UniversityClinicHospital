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
    }
}
