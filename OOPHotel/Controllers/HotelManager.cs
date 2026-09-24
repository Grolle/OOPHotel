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
        Room[] Rooms = new Room[40];

        public HotelManager()
        {
            for (int i = 0; i < Rooms.Count(); i++)
            {
                Rooms[i] = new();
                Rooms[i].IDRoom = i + 1;
            }

        }

        public void AddBooking(HotelBooking hotelBooking)
        {
            HotelBookingList.Add(hotelBooking);
        }

        public bool IsDateAvailable(DateTime startDate, DateTime endDate)
        {
            for (int i = 0; i < Rooms.Count(); i++)
            {
                Person person = new Person("test", "Email", 943423);
                HotelBooking hotelBooking = new HotelBooking(person, startDate, endDate, 54);
                if (Rooms[i].IsRoomAvailabel(hotelBooking))
                {
                    return true;

                }
            }
            return false;
        }

        public HotelBooking FindBooking(int bookingID) => HotelBookingList.FirstOrDefault(x => x.BookingID == bookingID);

    }
}
