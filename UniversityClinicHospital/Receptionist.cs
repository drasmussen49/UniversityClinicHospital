using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Receptionist : Employee
    {
        public bool OnPhone { get; set; }
        public Receptionist() : base("Mr. Blue", 1002, 45000)
        {
            OnPhone = false;
        }
    }
}
