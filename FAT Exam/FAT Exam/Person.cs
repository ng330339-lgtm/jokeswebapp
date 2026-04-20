using System;

class Person
{
    public string Name;
    public int Age;
    public double Weight;
    public double Height;

    public void EnterInformation()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        // Age validation
        while (true)
        {
            try
            {
                Console.Write("Enter Age: ");
                Age = int.Parse(Console.ReadLine());

                if (Age > 0)
                    break;
                else
                    Console.WriteLine("Age must be greater than 0.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }

        // Weight validation
        while (true)
        {
            try
            {
                Console.Write("Enter Weight (kg): ");
                Weight = double.Parse(Console.ReadLine());

                if (Weight > 0)
                    break;
                else
                    Console.WriteLine("Weight must be greater than 0.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }

        // Height validation
        while (true)
        {
            try
            {
                Console.Write("Enter Height (meters): ");
                Height = double.Parse(Console.ReadLine());

                if (Height > 0)
                    break;
                else
                    Console.WriteLine("Height must be greater than 0.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }
    }
}