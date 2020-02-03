using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace UniversityClinicHospital
{
    class Program
    {
        public static void wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
        static void Main(string[] args)
        {


            List<Object> Info = new List<Object>();
            List<Employee> employeeList = new List<Employee>();
            //Doctor doctor = new Doctor();
            //Nurse nurse = new Nurse();
            //Receptionist receptionist = new Receptionist();
            //Janitor janitor = new Janitor();
            Console.WriteLine("Enter the Patient Name");
            string PatinetName = Console.ReadLine();
            Console.WriteLine("Enter the " + PatinetName + "'s photo ");
            string Patinetphoto = Console.ReadLine();

            Patient patient = new Patient(PatinetName);

            Console.WriteLine("Enter the Doctor  Name");
            string DrtName = Console.ReadLine();
            Console.WriteLine("Enter the " + DrtName + "'s photo ");
            string Drphoto = Console.ReadLine();

            employeeList.Add(new Doctor(DrtName, 1000, "Doctor"));
            employeeList.Add(new Nurse("Green", 1001, 10));
            employeeList.Add(new Receptionist("Blue", 1002));
            employeeList.Add(new Janitor("Clean", 1003));


            bool usingSoftware = false;

            do
            {

                Console.WriteLine("\nWelcome to University Clinic Hospital Software!");
                Console.WriteLine("\t");
                Console.WriteLine("Select a number from the list below to interact with the software.");

                Console.WriteLine("( 1 ). Print list of employees and their attributes.");
                wait(1);
                Console.WriteLine("( 2 ). Pay the employees.");
                wait(1);
                Console.WriteLine("( 3 ). Patient interactions.");
                wait(1);
                Console.WriteLine("( 4 ). Exit the program.");
                wait(1);
                Console.WriteLine("( 5 ). Export the Info.");

                Console.WriteLine("\t");

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
                                Console.WriteLine("-------------------------------");
                            }
                            else
                            {

                                Console.WriteLine("\nAll employees have already been paid!");
                                Console.WriteLine("---------------------------------------");
                            }

                            break;
                        }
                    case "3":
                        {
                            // Console.WriteLine("Would you like to interact with a patient?");
                            // Console.WriteLine($"Press '1' to call doctor to patient {patient.Name}'s room. Or press '2' to send the nurse to the patient {patient.Name}'s room. Press any other key to return to main menu.");
                            Console.WriteLine("Press( 1 ). to call doctor to patient " + patient.Name + " 's room.");
                            Console.WriteLine("Press( 2 ). to call nurse to patient " + patient.Name + " 's room.");


                            string newUserInput = Console.ReadLine();
                            switch (newUserInput)
                            {
                                case "1":
                                    {
                                        //  Console.WriteLine($"{patient.Name}'s blood level is {patient.BloodLevel} and their health status is {patient.HealthStatus}.");
                                        // Console.WriteLine("Now, press '1' to have the doctor draw blood, '2' to have the doctor care for patient, or any other key to return to main menu.");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                        Console.WriteLine("_________________________________________________________________________________");
                                        Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                        Console.WriteLine("----------------------------------------------------------------------------------");

                                        Console.WriteLine("\t");

                                        Console.WriteLine("Press( 1 ). to have the doctor draw blood ");
                                        Console.WriteLine("Press( 2 ).to have the doctor care for patient ");

                                        Console.WriteLine("\t");
                                        string doctorChoice = Console.ReadLine();
                                        if (doctorChoice == "1")
                                        {
                                            Console.WriteLine("\t");
                                            employeeList[0].DrawBlood(patient);
                                            Console.WriteLine($"{employeeList[0].Name} has drawn blood from {patient.Name}!");
                                            // Console.WriteLine($"{patient.Name}'s blood level is {patient.BloodLevel} and their health status is {patient.HealthStatus}.");
                                            Console.WriteLine("\t");
                                            Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                            Console.WriteLine("_________________________________________________________________________________");
                                            Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                            Console.WriteLine("----------------------------------------------------------------------------------");
                                            Console.WriteLine("\t");


                                        }
                                        else if (doctorChoice == "2")
                                        {
                                            employeeList[0].CareForPatient(patient);
                                            Console.WriteLine($"{employeeList[0].Name} has cared for {patient.Name}!");

                                            Console.WriteLine("\t");
                                            Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                            Console.WriteLine("_________________________________________________________________________________");
                                            Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                            Console.WriteLine("----------------------------------------------------------------------------------");

                                            Console.WriteLine("\t");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Returning to main menu.");
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        //Console.WriteLine($"{patient.Name}'s blood level is {patient.BloodLevel} and their health status is {patient.HealthStatus}.");
                                        //  Console.WriteLine("Now, press '1' to have the nurse draw blood, '2' to have the nurse care for patient, or any other key to return to main menu.");
                                        Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                        Console.WriteLine("_________________________________________________________________________________");
                                        Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                        Console.WriteLine("----------------------------------------------------------------------------------");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("Press( 1 ). to have the nurse draw blood ");
                                        Console.WriteLine("Press( 2 ).to have the nurse care for patient ");
                                        Console.WriteLine("\t");

                                        string nurseChoice = Console.ReadLine();
                                        if (nurseChoice == "1")
                                        {
                                            employeeList[1].DrawBlood(patient);
                                            Console.WriteLine($"{employeeList[1].Name} has drawn blood from {patient.Name}!");
                                            Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                            Console.WriteLine("_________________________________________________________________________________");
                                            Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                            Console.WriteLine("----------------------------------------------------------------------------------");
                                            Console.WriteLine("\t");

                                        }
                                        else if (nurseChoice == "2")
                                        {
                                            employeeList[1].CareForPatient(patient);
                                            Console.WriteLine($"{employeeList[1].Name} has cared for {patient.Name}!");
                                            Console.WriteLine("\t");

                                            Console.WriteLine("|  Patient Name   |               | Blood Level |                | HealthStatus |");
                                            Console.WriteLine("_________________________________________________________________________________");
                                            Console.WriteLine("      " + patient.Name + "                              " + patient.BloodLevel + "                            " + patient.HealthStatus);
                                            Console.WriteLine("----------------------------------------------------------------------------------");
                                            Console.WriteLine("\t");
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


                    case "5":
                        {
                            Console.WriteLine("Your informatiom is sent.");
                            if (patient.Name == "Ghassan" || patient.Name == "ghassan")
                            {
                                if (patient.BloodLevel >= 15)
                                {
                                    tools.createdatafile(patient.Name + ".html", new string[] { "<html><head><title>"+patient.Name+"</title><style>table {border-style: ridge;  border-width: 5px; border-color: " +
                                                "#ffffff; background-color: white;}"+
                                         " th  {border:1px solid #095484;}td {border:2px groove #1c87c9;}</style></head><body background='https://i.gifer.com/J4o.gif'> <object width='720' height='515'data='https://www.youtube.com//embed/A9pU0JvXCDc?autoplay=1'></object><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><table bgcolor='white' background ='https://media.giphy.com/media/dkQ1CRCVHUaBi/giphy.gif'><tr  style='background-color:steel' ><th>Patient Name</th><th>Patient Blood Level</th><th>Patient HealthStatus</th>" +
                                         "<th>Dr Name</th>"+
                                            "</tr><tr><th>"+patient.Name+"</th><th  style='background-color:red' >"+patient.BloodLevel+"</th><th  style='background-color:red' >"+patient.HealthStatus+"</th><th>"+ employeeList[0].Name+"</th></tr>" +
                                            "<tr  style='background-color:black' ><th><img src='"+Patinetphoto+"' width='200'></th><th><img src='as.gif' width='250' ></th><th><img src='heart.jpg' width='200' ></th>" +
                                         "<th><img src='"+Drphoto+"' width='200' ></th></table></body></html>"
                                                          });

                                }
                                else
                                {
                                    tools.createdatafile(patient.Name + ".html", new string[] { "<html><head><title>"+patient.Name+"</title><style>table {border-style: ridge;  border-width: 5px; border-color: " +
                                                "#ffffff; background-color: white;}"+
                                         " th  {border:1px solid #095484;}td {border:2px groove #1c87c9;}</style></head><body background='https://i.gifer.com/J4o.gif'> <object width='720' height='515'data='https://www.youtube.com//embed/A9pU0JvXCDc?autoplay=1'></object><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><table bgcolor='white' background ='https://media.giphy.com/media/dkQ1CRCVHUaBi/giphy.gif'><tr  style='background-color:steel' ><th>Patient Name</th><th>Patient Blood Level</th><th>Patient HealthStatus</th>" +
                                         "<th>Dr Name</th>"+
                                            "</tr><tr><th>"+patient.Name+"</th><th  style='background-color:green' >"+patient.BloodLevel+"</th><th  style='background-color:green' >"+patient.HealthStatus+"</th><th>"+ employeeList[0].Name+"</th></tr>" +
                                            "<tr  style='background-color:black' ><th><img src='"+Patinetphoto+"' width='200'></th><th><img src='as2.jpg' width='250' ></th><th><img src='heart.jpg' width='200' ></th>" +
                                         "<th><img src="+Drphoto+" width='200' ></th></table></body></html>"
                                                          });
                                }
                            }
                            else
                            {
                                if (patient.BloodLevel >= 15)
                                {
                                    tools.createdatafile(patient.Name + ".html", new string[] { "<html><head><title>"+patient.Name+"</title><style>table {border-style: ridge;  border-width: 5px; border-color: " +
                                                "#ffffff; background-color: white;}"+
                                         " th  {border:1px solid #095484;}td {border:2px groove #1c87c9;}</style></head><body background='https://i.gifer.com/J4o.gif'> <object width='720' height='515'data='https://www.youtube.com//embed/A9pU0JvXCDc?autoplay=1'></object><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><table bgcolor='white' background ='https://media.giphy.com/media/dkQ1CRCVHUaBi/giphy.gif'><tr  style='background-color:steel' ><th>Patient Name</th><th>Patient Blood Level</th><th>Patient HealthStatus</th>" +
                                         "<th>Dr Name</th>"+
                                            "</tr><tr><th>"+patient.Name+"</th><th  style='background-color:red' >"+patient.BloodLevel+"</th><th  style='background-color:red' >"+patient.HealthStatus+"</th><th>"+ employeeList[0].Name+"</th></tr>" +
                                            "<tr  style='background-color:black' ><th><img src='"+Patinetphoto+"' width='160'></th><th><img src='as.gif' width='250' ></th><th><img src='heart.jpg' width='200' ></th>" +
                                         "<th><img src="+Drphoto+" width='240' ></th></table></body></html>"
                                                          });

                                }
                                else
                                {
                                    tools.createdatafile(patient.Name + ".html", new string[] { "<html><head><title>"+patient.Name+"</title><style>table {border-style: ridge;  border-width: 5px; border-color: " +
                                                "#ffffff; background-color: white;}"+
                                         " th  {border:1px solid #095484;}td {border:2px groove #1c87c9;}</style></head><body background='https://i.gifer.com/J4o.gif'> <object width='720' height='515'data='https://www.youtube.com//embed/A9pU0JvXCDc?autoplay=1'></object><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><table bgcolor='white' background ='https://media.giphy.com/media/dkQ1CRCVHUaBi/giphy.gif'><tr  style='background-color:steel' ><th>Patient Name</th><th>Patient Blood Level</th><th>Patient HealthStatus</th>" +
                                         "<th>Dr Name</th>"+
                                            "</tr><tr><th>"+patient.Name+"</th><th  style='background-color:green' >"+patient.BloodLevel+"</th><th  style='background-color:green' >"+patient.HealthStatus+"</th><th>"+ employeeList[0].Name+"</th></tr>" +
                                            "<tr  style='background-color:black' ><th><img src='"+Patinetphoto+"' width='160'></th><th><img src='as2.jpg' width='250' ></th><th><img src='heart.jpg' width='200' ></th>" +
                                         "<th><img src="+Drphoto+" width='240' ></th></table></body></html>"
                                                          });
                                }
                            }






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
    class tools : Patient
    {
        public static void CreatEmpty(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public static void createdatafile(string path, string[] lines)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (string line in lines)
                sw.WriteLine(line);
            sw.Close();
        }


    }
}
