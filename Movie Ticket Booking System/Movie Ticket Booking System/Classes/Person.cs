using MovieBookingApp;

class Ticket : Person
{
    public string SeatNumber { get; set; }
    public TicketType Type { get; set; }
    public double FinalPrice { get; private set; }

    public Ticket(string name, string seat, TicketType type, double basePrice)
        : base(name) 
    {
        SeatNumber = seat;
        Type = type;
        FinalPrice = CalculatePrice(basePrice);
    }

    private double CalculatePrice(double basePrice)
    {
        throw new NotImplementedException();
    }
}
