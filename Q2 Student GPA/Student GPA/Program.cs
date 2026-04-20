using System;

class Program
{
    static void Main()
    {
        double gpa;

        do
        {
            Console.Write("Enter GPA (0 - 4): ");
            gpa = Convert.ToDouble(Console.ReadLine());

            if (gpa < 0 || gpa > 4)
            {
                Console.WriteLine("Invalid GPA! Please enter a value between 0 and 4.\n");
            }

        } while (gpa < 0 || gpa > 4);

        Console.WriteLine("Valid GPA entered: " + gpa);
    }
}