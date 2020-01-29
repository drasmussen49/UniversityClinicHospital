using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void Does_PaySalary_Make_HasBeenPayed_True()
        {
            
            Employee myEmployee = new Employee();
            
            myEmployee.PaySalary();
            
            Assert.True(myEmployee.HasBeenPaid);
        }
    }
}
