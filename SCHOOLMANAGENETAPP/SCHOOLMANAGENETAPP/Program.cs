using SCHOOLMANAGENETAPP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class School
{
    static string studentFile = "students.json";
    static string lecturerFile = "lecturers.json";

    static void Main()
    {
        List<Student> students = LoadFromFile<Student>(studentFile);
        List<Teacher> lecturers = LoadFromFile<Teacher>(lecturerFile);

        int choice = 0;

        while (choice != 12)
        {
            Console.WriteLine("\n=== School Management System ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Add Lecturer");
            Console.WriteLine("4. View Lecturers");
            Console.WriteLine("5. Search Student");
            Console.WriteLine("6. Delete Student");
            Console.WriteLine("7. Update Student");
            Console.WriteLine("8. Search Lecturer");
            Console.WriteLine("9. Delete Lecturer");
            Console.WriteLine("10. Update Lecturer");
            Console.WriteLine("11. Save Data");
            Console.WriteLine("12. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            // Student operations
            if (choice == 1) AddStudent(students);
            else if (choice == 2) ViewStudents(students);
            else if (choice == 5) SearchStudent(students);
            else if (choice == 6) DeleteStudent(students);
            else if (choice == 7) UpdateStudent(students);

            // Lecturer operations
            else if (choice == 3) AddLecturer(lecturers);
            else if (choice == 4) ViewLecturers(lecturers);
            else if (choice == 8) SearchLecturer(lecturers);
            else if (choice == 9) DeleteLecturer(lecturers);
            else if (choice == 10) UpdateLecturer(lecturers);

            // Save data
            else if (choice == 11)
            {
                SaveToFile(students, studentFile);
                SaveToFile(lecturers, lecturerFile);
                Console.WriteLine("Data saved successfully.");
            }

            else if (choice == 12) Console.WriteLine("Exiting system...");
        }
    }

    // Student methods
    static void AddStudent(List<Student> students)
    {
        Student s = new Student();
        Console.Write("Enter Registration No: ");
        s.RegistrationNumber = Console.ReadLine();
        Console.Write("Enter Roll Number: ");
        s.RollNumber = Console.ReadLine();
        Console.Write("Enter First Name: ");
        s.FirstName = Console.ReadLine();
        Console.Write("Enter Middle Name: ");
        s.MiddleName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        s.LastName = Console.ReadLine();
        Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
        if (DateOnly.TryParse(Console.ReadLine(), out DateOnly dob)) s.DateOfBirth = dob;
        Console.Write("Enter Nationality: ");
        s.Nationality = Console.ReadLine();
        Console.Write("Enter Department: ");
        s.Department = Console.ReadLine();
        Console.Write("Enter Course: ");
        s.Course = Console.ReadLine();
        Console.Write("Enter GPA: ");
        if (double.TryParse(Console.ReadLine(), out double gpa)) s.GPA = gpa;

        students.Add(s);
        Console.WriteLine("Student added successfully.");
    }

    static void ViewStudents(List<Student> students)
    {
        if (students.Count == 0) Console.WriteLine("No students available.");
        else foreach (Student s in students) s.DisplayInfo();
    }

    static void SearchStudent(List<Student> students)
    {
        Console.Write("Enter Roll Number: ");
        string id = Console.ReadLine();
        Student s = students.Find(st => st.RollNumber == id);
        if (s != null) s.DisplayInfo();
        else Console.WriteLine("Student not found.");
    }

    static void DeleteStudent(List<Student> students)
    {
        Console.Write("Enter Roll Number: ");
        string id = Console.ReadLine();
        Student s = students.Find(st => st.RollNumber == id);
        if (s != null)
        {
            students.Remove(s);
            Console.WriteLine("Student deleted.");
        }
        else Console.WriteLine("Student not found.");
    }

    static void UpdateStudent(List<Student> students)
    {
        Console.Write("Enter Roll Number: ");
        string id = Console.ReadLine();
        Student s = students.Find(st => st.RollNumber == id);
        if (s != null)
        {
            Console.Write("Enter new Course: ");
            s.Course = Console.ReadLine();
            Console.Write("Enter new GPA: ");
            if (double.TryParse(Console.ReadLine(), out double gpa)) s.GPA = gpa;
            Console.WriteLine("Student updated.");
        }
        else Console.WriteLine("Student not found.");
    }

    // Lecturer methods
    static void AddLecturer(List<Teacher> lecturers)
    {
        Teacher l = new Teacher();
        Console.Write("Enter Lecturer ID: ");
        l.LecturerId = Console.ReadLine();
        Console.Write("Enter Employee Number: ");
        l.EmployeeNumber = Console.ReadLine();
        Console.Write("Enter First Name: ");
        l.FirstName = Console.ReadLine();
        Console.Write("Enter Middle Name:) ");
    }
}   
   