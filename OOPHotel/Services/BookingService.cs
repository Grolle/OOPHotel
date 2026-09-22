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
        private Questionnaire questionnaire;
        private UserGreeter greeter;

        public BookingService() { questionnaire = new(); greeter = new(); }


        public void BookingLoop()
        {
            greeter.GreetUser();

            while (true)
            {
                UserBookingActions action = questionnaire.AskForUserReason();

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

                bool complete = questionnaire.GetBookingComplete();

                if(complete)
                {
                    greeter.ConfirmBooking();
                    break;
                }
            }
        }

        public void OpenNewBooking()
        {
            string name = questionnaire.AskForUserName();
            string email = questionnaire.GetUserEmail();
            int phone = questionnaire.GetPhoneNumber();
            DateTime bookingDate = questionnaire.AskForStartDate();
            int lenghtOfStay = questionnaire.AskForLengthOfStay();
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
