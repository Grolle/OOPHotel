using OOPHotel.Part_Two;
using OOPHotel.Services;

namespace OOPHotel
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Tryck 1 för booking. Tryck 2 för Personal.");
            string val = Console.ReadLine();
            if(int.TryParse(val, out int intVal))
            {
                if(intVal == 1)
                {
                    BookingService bookingService = new();
                    bookingService.BookingLoop();
                }
                else if(intVal == 2)
                {
                    // Skapa en Manager
                    Manager manager = new Manager
                    {
                        Name = "Lisa Ledarsson",
                        Age = 40,
                        EmployeeID = "M001",
                        StartDate = new DateTime(2020, 1, 1),
                        Salary = 50000,
                        Department = "Administration"
                    };

                    // Skapa en Employee
                    Employee employee = new Employee
                    {
                        Name = "Erik Eriksson",
                        Age = 30,
                        EmployeeID = "E001",
                        StartDate = new DateTime(2022, 3, 15),
                        Salary = 30000,
                        JobTitle = "Receptionist",
                        Department = "Front Desk"
                    };

                    // Anropa metoder för att testa
                    Console.WriteLine("Manager:");
                    manager.PrintInfo();
                    manager.Introduction($"Hej jag heter {manager.Name} och är {manager.Age} gammal.");
                    manager.HoldMeeting();

                    Console.WriteLine("\nEmployee:");
                    employee.PrintInfo();
                    employee.Introduction($"Hej, jag heter {employee.Name} och är {employee.Age} gammal.");
                    employee.Work();

                    Consultant consultant = new Consultant
                    {
                        Name = "Eva Expert",
                        Age = 35,
                        EmployeeID = "C001",
                        Expertise = "Ventilations kontroller.",
                        StartDate = new DateTime(2023, 1, 1),
                        Salary = 0, // Konsulter har ofta inte fast lön
                        HourlyRate = 1000,
                        ConsultingFirm = "Hotell Experterna AB"
                    };

                    Console.WriteLine("Consultant:");
                    consultant.PrintInfo();
                    consultant.Introduction($"Hej, jag heter {consultant.Name} och är 35 år gammal.");
                    consultant.GiveAdvice();
                    Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
                    Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");


                    // Skapa ett Housekeeper-objekt
                    HouseKeeper anna = new HouseKeeper
                    {
                        Name = "Anna Clean",
                        Age = 32,
                        Salary = 100000,
                    };
                    anna.PrintInfo(); // Skriver ut namn och ålder
                    anna.Work(); // Skriver ut att Anna städar hotellrummen
                }
            }

        }
    }
}
