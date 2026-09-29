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

        public void AddPerson(Person person1, DateTime checkIn, DateTime checkOut)
        {
            person = person1;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public bool IsRoomAvailabel(DateTime startDate, DateTime endDate)
        {


            bool datesOverlap = startDate < CheckOut && endDate > CheckIn;

            if (datesOverlap)
            {
                return false;
            }

            return true;

        }

        public void RemoveBooking()
        {
            person = null;
            CheckIn.Subtract(CheckIn);
            CheckOut.Subtract(CheckOut);
        }
    }
}