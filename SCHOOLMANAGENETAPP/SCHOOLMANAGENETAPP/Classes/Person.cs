namespace SCHOOLMANAGENETAPP.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }

        // Full name property
        public string FullName =>
            $"{FirstName} {MiddleName} {LastName}".Trim();
        
        {
            Console.WriteLine("----- Person Info -----");
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToString("yyyy-MM-dd"));
        }
    }
}