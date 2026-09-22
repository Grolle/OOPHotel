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
            HotelBooking booking;
            bool complete;

            while (true)
            {
                UserBookingActions action = questionnaire.AskForUserReason();
                switch (action)
                {
                    case UserBookingActions.Book:
                        booking = OpenNewBooking();
                        greeter.ConfirmBooking(booking.Person.Name, booking.Starting);

                        break;
                    case UserBookingActions.UpdateBooking:
                        booking = UpdateBooking();
                        greeter.ConfirmRebook(booking.Person.Name, booking.Starting);

                        break;
                    case UserBookingActions.Cancel:
                        booking = CancelBooking();
                        greeter.ConfirmCancel(booking.Person.Name, booking.Starting);
                        break;
                }

                complete = questionnaire.GetBookingComplete();

                if (complete)
                    break;
            }
        }

        public HotelBooking OpenNewBooking()
        {
            string name = questionnaire.AskForUserName();
            string email = questionnaire.GetUserEmail();
            int phone = questionnaire.GetPhoneNumber();
            DateTime bookingDate = questionnaire.AskForStartDate();
            int lenghtOfStay = questionnaire.AskForLengthOfStay();
            Person guest = new(name, email, phone);
            HotelBooking booking = new(guest, bookingDate, lenghtOfStay);
            return booking;
        }

        public HotelBooking CancelBooking()
        {
            return null;   
        }

        public HotelBooking UpdateBooking()
        {
            return null;
        }

    }
}
