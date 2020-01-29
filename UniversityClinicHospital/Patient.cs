using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public int BloodLevel { get; set; }
        public int HealthStatus { get; set; }
        public Patient()
        {
            BloodLevel = 20;
            HealthStatus = 10;
        }
    }
}
