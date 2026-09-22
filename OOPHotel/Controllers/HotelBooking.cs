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
        public DateTime Starting { get; set; }

        public DateTime LastDay { get; set; }
        public int AddedDay { get; set; }

        public int IDRoom { get; set; } = -1;
        public int BookingID { get; set; } = 0;

       public  HotelBooking(Person person,  DateTime starting, DateTime lastday, int bookingID)
        {
            Person = person;
            Starting = starting;
            LastDay = lastday;
            BookingID = bookingID;

        }

    }
}
