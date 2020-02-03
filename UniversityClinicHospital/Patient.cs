using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public string Name { get; set; }
        public int BloodLevel { get; set; }
        public int HealthStatus { get; set; }
        public Patient()
        {

        }

        public Patient(string name)
        {
            Name = name;
            BloodLevel = 20;
            HealthStatus = 10;
        }
    }
}
