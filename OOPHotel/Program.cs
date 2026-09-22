using OOPHotel.Services;

namespace OOPHotel
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            BookingService bookingService = new();
            bookingService.BookingLoop();
        }
    }
}
