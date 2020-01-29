using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor myDoc = new Doctor();
            myDoc.EmployeeID = 1555;
            Console.WriteLine(myDoc.EmployeeID);
        }
    }
}
