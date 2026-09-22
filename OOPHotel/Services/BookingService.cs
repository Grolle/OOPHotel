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
        private HotelManager hotelManager;
        private IDGenerator idgenrator;

        public BookingService() { questionnaire = new(); greeter = new(); hotelManager = new(); idgenrator = new(); }


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
                        greeter.ConfirmBooking(booking.Person.Name, booking.Starting, booking.BookingID);
                        hotelManager.AddBooking(booking);
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
            int id = idgenrator.GenerateUniqueID();
            HotelBooking booking = new(guest, bookingDate, bookingDate.AddDays(lenghtOfStay), id);
            return booking;
        }

        public HotelBooking CancelBooking()
        {
            return null;   
        }

        public HotelBooking UpdateBooking()
        {
            if (TryFindBookingByID(out HotelBooking booking))
            {
                DateTime startDate = questionnaire.AskForStartDate();
                int days = questionnaire.AskForLengthOfStay();
                DateTime endDate = startDate.AddDays(days);
                booking.Starting = startDate;
                return booking;
            }
            else
            {
                Console.WriteLine("Could not retrieve booking, jumping to base options.");
                return null;
            }
        }

        private bool TryFindBookingByID(out HotelBooking booking)
        {
            while (true)
            {
                int bookingID = questionnaire.GetBookingNumber();
                booking = hotelManager.GetBookingByID(bookingID);

                if (booking != null)
                    return true;

                Console.WriteLine("Could not find your booking, please try again.");

                if (questionnaire.GetCancelCurrentAction())
                    return false;
            }
        }

    }
}
