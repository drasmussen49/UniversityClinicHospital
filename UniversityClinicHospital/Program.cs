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
                Console.WriteLine("3. Patient interactions.");
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
                    case "3":
                        {
                            Console.WriteLine("Would you like to interact with a patient?");
                            Console.WriteLine($"Press '1' to call doctor to patient {patient.Name}'s room. Or press '2' to send the nurse to the patient {patient.Name}'s room. Press any other key to return to main menu.");
                            string newUserInput = Console.ReadLine();
                            switch (newUserInput)
                            {
                                case "1":
                                    {
                                        Console.WriteLine($"{patient.Name}'s blood level is {patient.BloodLevel} and their health status is {patient.HealthStatus}.");
                                        Console.WriteLine("Now, press '1' to have the doctor draw blood, '2' to have the doctor care for patient, or any other key to return to main menu.");
                                        string doctorChoice = Console.ReadLine();
                                        if (doctorChoice == "1")
                                        {
                                            employeeList[0].DrawBlood(patient);
                                            Console.WriteLine($"{employeeList[0].Name} has drawn blood from {patient.Name}!");
                                        }
                                        else if (doctorChoice == "2")
                                        {
                                            employeeList[0].CareForPatient(patient);
                                            Console.WriteLine($"{employeeList[0].Name} has cared for {patient.Name}!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Returning to main menu.");
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine($"{patient.Name}'s blood level is {patient.BloodLevel} and their health status is {patient.HealthStatus}.");
                                        Console.WriteLine("Now, press '1' to have the nurse draw blood, '2' to have the nurse care for patient, or any other key to return to main menu.");
                                        string nurseChoice = Console.ReadLine();
                                        if (nurseChoice == "1")
                                        {
                                            employeeList[1].DrawBlood(patient);
                                            Console.WriteLine($"{employeeList[1].Name} has drawn blood from {patient.Name}!");
                                        }
                                        else if (nurseChoice == "2")
                                        {
                                            employeeList[1].CareForPatient(patient);
                                            Console.WriteLine($"{employeeList[1].Name} has cared for {patient.Name}!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Returning to main menu.");
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Returning to main menu.");
                                        break;
                                    }
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
