using System;
using System.Collections.Generic;


namespace MovieBookingApp
{
    class Booking
    {
        public Movie SelectedMovie { get; set; }
        private List<Ticket> tickets = new List<Ticket>();

        public Booking(Movie movie)
        {
            SelectedMovie = movie;
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        // VIEW ALL TICKETS
        public void ViewTickets()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("No tickets booked yet.");
                return;
            }

            Console.WriteLine("\n===== ALL BOOKED TICKETS =====");
            foreach (var ticket in tickets)
            {
                ticket.DisplayTicket();
                Console.WriteLine("----------------------------");
            }
        }

        // SEARCH TICKET
        public void SearchTicket(string name)
        {
            var ticket = tickets.FirstOrDefault(t => t.HolderName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (ticket != null)
            {
                Console.WriteLine("\nTicket Found:");
                ticket.DisplayTicket();
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }
        }

        // DELETE TICKET
        public void DeleteTicket(string seatNumber)
        {
            var ticket = tickets.FirstOrDefault(t => t.SeatNumber.Equals(seatNumber, StringComparison.OrdinalIgnoreCase));

            if (ticket != null)
            {
                tickets.Remove(ticket);
                Console.WriteLine($"Ticket at seat {seatNumber} deleted successfully!");
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }
        }

        // DISPLAY RECEIPT
        public void DisplayReceipt()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Console.WriteLine("\n========= BOOKING RECEIPT =========");
            Console.WriteLine($"Movie: {SelectedMovie.Title}");
            Console.WriteLine("===================================");

            double total = 0;

            foreach (var ticket in tickets)
            {
                ticket.DisplayTicket();
                Console.WriteLine("----------------------------");
                total += ticket.FinalPrice;
            }

            Console.WriteLine($"\nTOTAL AMOUNT: {total} RWF");
        }
    }
}
