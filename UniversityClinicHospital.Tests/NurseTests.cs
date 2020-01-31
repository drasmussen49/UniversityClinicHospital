using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Does_DrawBlood_Reduce_Patient_BloodLevel_By_1()
        {
            //arrange
            Nurse myNurse = new Nurse();
            Patient myPatient = new Patient();
            myPatient.BloodLevel = 10;

            //act
            myNurse.DrawBlood(myPatient);

            //assert
            Assert.Equal(9, myPatient.BloodLevel);
        }
        [Fact]
        public void Does_CareForPatient_Increase_Patient_HealthStatus_By_10()
        {
            //arrange
            Nurse myNurse = new Nurse();
            Patient myPatient = new Patient();
            myPatient.HealthStatus = 20;

            //act
            myNurse.CareForPatient(myPatient);

            //assert
            Assert.Equal(30, myPatient.HealthStatus);
        }
    }
}
