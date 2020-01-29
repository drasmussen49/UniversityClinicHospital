using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Janitor : Employee
    {
        public bool IsSweeping { get; set; }
        public Janitor() : base("Mr.Clean", 1003, 40000)
        {
            IsSweeping = false;
        }
    }
}
