using System;
using System.Collections.Generic;

namespace MovieBookingApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("      WELCOME TO ULK GRAND CINEMA ");
            Console.WriteLine("===============================================\n");

            List<Movie> movies = new List<Movie>
            {
                new Movie("Avengers", "Action", 120, 5000),
                new Movie("John Wick", "Action", 110, 5000),
                new Movie("Titanic", "Romance", 130, 4000),
                new Movie("The Conjuring", "Horror", 100, 4500)
            };

            Console.WriteLine("Select Genre:");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Romance");
            Console.WriteLine("3. Horror");

            int genreChoice = GetValidNumber("Enter choice: ", 1, 3);

            string selectedGenre = genreChoice == 1 ? "Action" :
                                   genreChoice == 2 ? "Romance" : "Horror";

            var genreMovies = movies.FindAll(m => m.Genre == selectedGenre);

            Console.WriteLine($"\nAvailable {selectedGenre} Movies:");
            for (int i = 0; i < genreMovies.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                genreMovies[i].DisplayMovie();
            }

            int movieChoice = GetValidNumber("Select Movie: ", 1, genreMovies.Count);
            Movie selectedMovie = genreMovies[movieChoice - 1];

            Booking booking = new Booking(selectedMovie);

            int ticketCount = GetValidNumber("How many tickets? ", 1, 10);

            for (int i = 0; i < ticketCount; i++)
            {
                Console.WriteLine($"\n=== Ticket {i + 1} ===");

                string name = GetValidString("Enter Name: ");
                string seat = GetValidString("Enter Seat Number: ");

                Console.WriteLine("\nSelect Ticket Type:");
                Console.WriteLine($"1. Ordinary - {selectedMovie.BasePrice} RWF");
                Console.WriteLine($"2. VIP - {selectedMovie.BasePrice + 5000} RWF");
                Console.WriteLine($"3. VVIP - {selectedMovie.BasePrice + 10000} RWF");

                int typeChoice = GetValidNumber("Select Ticket Type (1-3): ", 1, 3);
                TicketType type = (TicketType)typeChoice;

                Ticket ticket = new Ticket(name, seat, type, selectedMovie.BasePrice);
                booking.AddTicket(ticket);
            }

            booking.DisplayReceipt();

            // MANAGEMENT MENU
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== TICKET MANAGEMENT =====");
                Console.WriteLine("1. View All Tickets");
                Console.WriteLine("2. Search Ticket by Name");
                Console.WriteLine("3. Delete Ticket by Seat");
                Console.WriteLine("4. Exit");

                int choice = GetValidNumber("Enter choice (1-4): ", 1, 4);

                switch (choice)
                {
                    case 1:
                        booking.ViewTickets();
                        break;

                    case 2:
                        string searchName = GetValidString("Enter name to search: ");
                        booking.SearchTicket(searchName);
                        break;

                    case 3:
                        string seatToDelete = GetValidString("Enter seat number to delete: ");
                        booking.DeleteTicket(seatToDelete);
                        break;

                    case 4:
                        running = false;
                        break;
                }
            }

            Console.WriteLine("\nThank you for booking with ULK Grand Cinema!");
            Console.ReadLine();
        }

       
        static int GetValidNumber(string message, int min, int max)
        {
            int number;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number >= min && number <= max)
                {
                    return number;
                }

                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
        }

        
        static string GetValidString(string message)
        {
            string input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        }
    }
}
