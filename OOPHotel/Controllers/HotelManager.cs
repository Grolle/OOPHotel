using Akutmottagningen.Questions;
using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class HotelManager
    {

        List<HotelBooking> HotelBookingList = new List<HotelBooking>();
        InputHander[] rums = new InputHander[40];


       public void AddBooking(HotelBooking hotelBooking)
        {
            HotelBookingList.Add(hotelBooking);
        }




    }
}
