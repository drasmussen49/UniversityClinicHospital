﻿using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            //Doctor doctor = new Doctor();
            //Nurse nurse = new Nurse();
            //Receptionist receptionist = new Receptionist();
            //Janitor janitor = new Janitor();
            Patient patient = new Patient("Bob");
            employeeList.Add(new Doctor("Dr. House", 1000, "Heart Specialty"));
            employeeList.Add(new Nurse());






            Console.WriteLine("Welcome to University Clinic Hospital Software!");
            Console.WriteLine("1. ");
        }
    }
}
