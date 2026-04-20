using System;
using System.IO;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Save data to file
    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(Name + "," + Age);
        }
    }

    // Load data from file
    public static List<Person> LoadFromFile(string filePath)
    {
        List<Person> people = new List<Person>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                Person p = new Person
                {
                    Name = data[0],
                    Age = Convert.ToInt32(data[1])
                };

                people.Add(p);
            }
        }

        return people;
    }
}

class Program
{
    static void Main()
    {
        string filePath = "student.txt";

        // Create object
        Person person1 = new Person();

        Console.Write("Enter Name: ");
        person1.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        person1.Age = Convert.ToInt32(Console.ReadLine());

        // Save to file
        person1.SaveToFile(filePath);
        Console.WriteLine("\nData saved successfully!\n");

        // Load and display data
        Console.WriteLine("---- Loaded Data ----");
        List<Person> people = Person.LoadFromFile(filePath);

        foreach (Person p in people)
        {
            Console.WriteLine("Name: " + p.Name + " | Age: " + p.Age);
        }
    }
}