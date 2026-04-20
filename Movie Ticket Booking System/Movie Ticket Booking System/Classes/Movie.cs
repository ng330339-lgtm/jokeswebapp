using System;

namespace MovieBookingApp
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public double BasePrice { get; set; }

        public Movie(string title, string genre, int duration, double basePrice)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
            BasePrice = basePrice;
        }

        public void DisplayMovie()
        {
            Console.WriteLine($"{Title} | {Duration} mins | Base Price: {BasePrice} RWF");
        }
    }
}
