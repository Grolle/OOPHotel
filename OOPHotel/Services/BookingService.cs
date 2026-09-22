using OOPHotel.Containers;
using OOPHotel.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Services
{
    internal class BookingService
    {

        public enum UserBookingActions
        {
            Book,
            Cancel,
            UpdateBooking
        }
        private Questionnaire questionnarie;
        private UserGreeter greeter;

        public BookingService() { questionnarie = new(); greeter = new(); }


        public void BookingLoop()
        {
            greeter.GreetUser();
            while (true)
            {
                UserBookingActions action = questionnarie.AskForUserReason();

                switch(action)
                {
                    case UserBookingActions.Book:
                        OpenNewBooking();
                        break;
                    case UserBookingActions.UpdateBooking:
                        UpdateBooking();
                        break;
                    case UserBookingActions.Cancel:
                        CancelBooking();
                        break;
                }

                bool complete = questionnarie.GetBookingComplete();

                if(complete)
                {
                    greeter.ConfirmBooking();
                    break;
                }
            }
        }

        public void OpenNewBooking()
        {
            string name = questionnarie.AskForUserName();
            string email = questionnarie.GetUserEmail();
            int phone = questionnarie.GetPhoneNumber();
            DateTime bookingDate = questionnarie.AskForStartDate();
            int lenghtOfStay = questionnarie.AskForLengthOfStay();
            Person guest = new(name, email, phone);
            HotelBooking booking = new(guest, bookingDate, lenghtOfStay);
            greeter.ConfirmBooking();
        }

        public void CancelBooking()
        {
            
        }

        public void UpdateBooking()
        {

        }

    }
}
