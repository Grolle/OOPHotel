using Akutmottagningen.Questions;
using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    public class HotelBooking
    {
        public Person Person { get; set; }
        public DateTime StartingDay { get; set; }

        public DateTime EndDay { get; set; }

        public int IDRoom { get; set; } = -1;
        public int BookingID { get; set; } = 0;

        public HotelBooking(Person person, DateTime starting, DateTime lastday, int bookingID)
        {
            Person = person;
            StartingDay = starting;
            EndDay = lastday;
            BookingID = bookingID;

        }

    }
}
