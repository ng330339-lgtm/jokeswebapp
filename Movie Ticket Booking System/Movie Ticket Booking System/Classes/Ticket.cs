using System;

namespace MovieBookingApp
{
    class Ticket
    {
        public string HolderName { get; set; }
        public string SeatNumber { get; set; }
        public TicketType Type { get; set; }
        public double FinalPrice { get; private set; }

        public Ticket(string name, string seat, TicketType type, double basePrice)
        {
            HolderName = name;
            SeatNumber = seat;
            Type = type;
            FinalPrice = CalculatePrice(basePrice);
        }

        private double CalculatePrice(double basePrice)
        {
            switch (Type)
            {
                case TicketType.Ordinary:
                    return basePrice;

                case TicketType.VIP:
                    return basePrice + 5000;

                case TicketType.VVIP:
                    return basePrice + 10000;

                default:
                    return basePrice;
            }
        }

        public void DisplayTicket()
        {
            Console.WriteLine($"Name        : {HolderName}");
            Console.WriteLine($"Seat        : {SeatNumber}");
            Console.WriteLine($"Ticket Type : {Type}");
            Console.WriteLine($"Price       : {FinalPrice} RWF");
        }
    }
}
