using System;

class Program
{
    static void Main()
    {
        string name, course;
        int age;
        
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Course: ");
        course = Console.ReadLine();

        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Course: " + course);
    }
}