using System;

class Student
{
    public string Name;
    public int Age;
    public string Course;

    public void DisplayInfo()
    {
        Console.WriteLine("\n--- Student Information ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        Console.Write("Enter Student Name: ");
        student1.Name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        student1.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Course: ");
        student1.Course = Console.ReadLine();

        student1.DisplayInfo();
    }
}