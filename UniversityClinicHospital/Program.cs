using System;
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
            employeeList.Add(new Doctor("Dr. House", 1000, "Heart"));
            employeeList.Add(new Nurse("Ms. Green", 1001, 10));
            employeeList.Add(new Receptionist("Mr. Blue", 1002));
            employeeList.Add(new Janitor("Mr. Clean", 1003));
            bool usingSoftware = false;

            do
            {
                Console.WriteLine("\nWelcome to University Clinic Hospital Software!");
                Console.WriteLine("Select a number from the list below to interact with the software.");
                Console.WriteLine("1. Print list of employees and their attributes.");
                Console.WriteLine("2. Pay the employees.");
                Console.WriteLine("3. Perform medical procedures.");
                Console.WriteLine("4. Exit the program.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            foreach (Employee myEmp in employeeList)
                            {
                                myEmp.PrintInfo();
                            }
                            break;
                        }
                    case "2":
                        {
                            if (employeeList[0].HasBeenPaid == false)
                            {
                                foreach (Employee myEmp in employeeList)
                                {
                                    myEmp.PaySalary();
                                }
                                Console.WriteLine("\nAll employees have been paid!");
                            }
                            else
                            {
                                Console.WriteLine("\nAll employees have already been paid!");
                            }
                            break;
                        }
                    case "4":
                        {
                    Console.WriteLine("You will now exit the program.");
                    usingSoftware = true;
                    break;
                }
                default:
                        {
                    break;
                }
            }
            } while (usingSoftware == false);

        }
}
}
