using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{

    public class DoctorTests
    {
        [Fact]
        public void Does_DrawBlood_Reduce_Patient_BloodLevel_By_2()
        {
            //arrange
            Doctor myDoctor = new Doctor();
            Patient myPatient = new Patient();
            myPatient.BloodLevel = 12;

            //act
            myDoctor.DrawBlood(myPatient);

            //assert
            Assert.Equal(10, myPatient.BloodLevel);
        }
        [Fact]
        public void Does_CareForPatient_Increase_Patient_HealthStatus_By_15()
        {
            //arrange
            Doctor myDoctor = new Doctor();
            Patient myPatient = new Patient();
            myPatient.HealthStatus = 20;

            //act
            myDoctor.CareForPatient(myPatient);

            //assert
            Assert.Equal(35, myPatient.HealthStatus);
        }
    }
}
