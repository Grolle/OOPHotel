using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{

    public class Room
    {

        public int IDRoom { get; set; } = 0;


        Person person;
        DateTime CheckIn;
        DateTime CheckOut;

        bool hasBooking = false;

        public bool IsRoomAvailabel(HotelBooking hotelBooking)
        {

            if (hasBooking == false)
            {
                person = hotelBooking.Person;
                CheckIn = hotelBooking.Starting;
                CheckOut = hotelBooking.LastDay;

                hasBooking = true;

                return true;
            }

            bool datesOverlap = hotelBooking.Starting < CheckOut && hotelBooking.LastDay > CheckIn;

            if (datesOverlap)
            {
                return false;
            }

            person = hotelBooking.Person;
            CheckIn = hotelBooking.Starting;
            CheckOut = hotelBooking.LastDay;

            return true;

        }
    }
}