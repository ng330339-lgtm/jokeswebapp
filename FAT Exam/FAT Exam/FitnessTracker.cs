using System;
using System.IO;

class FitnessTracker
{
    public string Goal;

    public double CalculateBMI(Person p)
    {
        return p.Weight / (p.Height * p.Height);
    }

    public void SetGoal()
    {
        Console.Write("Enter Fitness Goal: ");
        Goal = Console.ReadLine();
    }

    public void DisplayInfo(Person p)
    {
        Console.WriteLine("\nUser Information");
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Age: " + p.Age);
        Console.WriteLine("Weight: " + p.Weight + " kg");
        Console.WriteLine("Height: " + p.Height + " m");
        Console.WriteLine("BMI: " + CalculateBMI(p));
        Console.WriteLine("Goal: " + Goal);
    }

    public void SaveToFile(Person p)
    {
        try
        {
            StreamWriter writer = new StreamWriter("fitness.txt", true);

            writer.WriteLine("Name: " + p.Name);
            writer.WriteLine("Age: " + p.Age);
            writer.WriteLine("Weight: " + p.Weight);
            writer.WriteLine("Height: " + p.Height);
            writer.WriteLine("BMI: " + CalculateBMI(p));
            writer.WriteLine("Goal: " + Goal);
            writer.WriteLine("----------------------");

            writer.Close();

            Console.WriteLine("Data saved to fitness.txt");
        }
        catch
        {
            Console.WriteLine("Error saving file.");
        }
    }
}