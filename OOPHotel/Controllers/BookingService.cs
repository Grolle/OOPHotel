using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class BookingService
    {
        private Questionnaire questionnarie;

        public BookingService() { questionnarie = new(); }

        public void OpenNewBooking()
        {
            string name = questionnarie.AskForUserName();
            string email = questionnarie.GetUserEmail();
            int phoneNr = questionnarie.GetPhoneNumber();
            DateTime bookingDate = questionnarie.AskForStartDate();
            int lenghtOfStay = questionnarie.AskForLengthOfStay();
            HotelBooking booking = new(name, bookingDate, lenghtOfStay);
        }

        public void CancelBooking()
        {
            
        }
    }
}
