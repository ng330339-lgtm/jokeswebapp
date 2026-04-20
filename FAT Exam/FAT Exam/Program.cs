

using System;
using System.IO;
class Program
{
    static void Main()
    {
        Person user = new Person();
        FitnessTracker tracker = new FitnessTracker();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nFitness Tracker System");
            Console.WriteLine("------------------------");
            Console.WriteLine("1.Enter user Information");
            Console.WriteLine("2.Calculate BMI");
            Console.WriteLine("3.Set Fitness Goal");
            Console.WriteLine("4.Display User information");
            Console.WriteLine("5.Save Data to File");
            Console.WriteLine("6.Exit");

            try
            {
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        user.EnterInformation();
                        break;

                    case 2:
                        Console.WriteLine("BMI: " + tracker.CalculateBMI(user));
                        break;

                    case 3:
                        tracker.SetGoal();
                        break;

                    case 4:
                        tracker.DisplayInfo(user);
                        break;

                    case 5:
                        tracker.SaveToFile(user);
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}