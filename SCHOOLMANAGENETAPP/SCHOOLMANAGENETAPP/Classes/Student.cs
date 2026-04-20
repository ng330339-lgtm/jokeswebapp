using System;

namespace SCHOOLMANAGENETAPP.Classes
{
    public class Student : Person
    {
        public string RegistrationNumber { get; set; } = string.Empty;
        public string RollNumber { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public double GPA { get; set; }

        public void Update(string course, double gpa)
        {
            if (!string.IsNullOrWhiteSpace(course)) Course = course;
            GPA = gpa;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Student Info -----");
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToString("yyyy-MM-dd"));
            Console.WriteLine("GPA: " + GPA);
        }
    }
}