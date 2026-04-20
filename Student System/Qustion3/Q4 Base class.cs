using System;
using System.IO;

namespace StudentFileApp
{
    
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
        public void SaveToFile()
        {
            string path = "student.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(Name);
                writer.WriteLine(Age);
            }

            Console.WriteLine("Data saved successfully to student.txt\n");
        }

        // Method to Load Data from File
        public void LoadFromFile()
        {
            string path = "student.txt";

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    Name = reader.ReadLine();
                    Age = int.Parse(reader.ReadLine());
                }

                Console.WriteLine("Data loaded successfully from student.txt\n");
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }

        
        public void Display()
        {
            Console.WriteLine("----- Loaded Data -----");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            
            Console.Write("Enter Name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            person.Age = int.Parse(Console.ReadLine());

           
            person.SaveToFile();

            
            person.LoadFromFile();

            
            person.Display();

            Console.ReadKey();
        }
    }
}