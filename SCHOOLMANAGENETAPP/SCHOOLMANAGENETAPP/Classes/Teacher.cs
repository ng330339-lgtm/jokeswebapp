namespace SCHOOLMANAGENETAPP.Classes
{
    public class Teacher : Person
    {
        public string LecturerId { get; set; } = string.Empty;
        public string EmployeeNumber { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;

        public void Update(string subject, string department)
        {
            if (!string.IsNullOrWhiteSpace(subject)) Subject = subject;
            if (!string.IsNullOrWhiteSpace(department)) Department = department;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Teacher Info -----");
            Console.WriteLine("Lecturer ID: " + LecturerId);
            Console.WriteLine("Employee No: " + EmployeeNumber);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToString("yyyy-MM-dd"));
        }
    }
}