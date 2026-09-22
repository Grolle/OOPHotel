using Akutmottagningen.Questions;
using OOPHotel.Containers;
using OOPHotel.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class HotelManager
    {

        List<HotelBooking> HotelBookingList = new List<HotelBooking>();
        //RoomManager[] rums = new RoomManager[40];

        public HotelManager() { }

        public void AddBooking(HotelBooking hotelBooking)
        {
            HotelBookingList.Add(hotelBooking);
        }

        public bool IsDateAvailable(DateTime startDate, DateTime dateTime)
        {

            return true;
        }

        public HotelBooking FindBooking(int bookingID) => HotelBookingList.FirstOrDefault(x => x.BookingID == bookingID);

    }
}
