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
        InputHander[] rums = new InputHander[40];

        public HotelManager() {  }

       public void AddBooking(HotelBooking hotelBooking)
        {
            int j;
            for (int i = 0; i < rums.Length; i++)
            {
               j = CheckIfPersonExistReturnI(hotelBooking);

                if (j != -1)
                {
                    break;
                }
            }

            HotelBookingList.Add(hotelBooking);
        }

        private int CheckIfPersonExistReturnI(HotelBooking hotelBooking)
        {
            for (int i = 0; i < HotelBookingList.Count; i++)
            {
                //HotelBookingList.

            }


            return -1;
        }

        public HotelBooking FindBooking(int bookingID) => HotelBookingList.FirstOrDefault(x => x.BookingID == bookingID);
   



    }
}
