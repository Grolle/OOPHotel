using OOPHotel.Containers;
using OOPHotel.Controllers;
using OOPHotel.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Services
{
    internal class BookingService
    {

        private struct DateData
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }
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

        public BookingService() { questionnaire = new(); greeter = new(); hotelManager = new(); idgenrator = new();}


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
                        if(booking != null)
                        {
                            greeter.UserPresenter(booking.Person);
                            greeter.ConfirmBooking(booking.Person.Name, booking.StartingDay, booking.BookingID);
                            hotelManager.AddBooking(booking);
                        }
                        break;
                    case UserBookingActions.UpdateBooking:
                        booking = UpdateBooking();
                        if(booking != null)
                            greeter.ConfirmRebook(booking.Person.Name, booking.StartingDay);
                        break;
                    case UserBookingActions.Cancel:
                        booking = CancelBooking();
                        if(booking != null)
                            greeter.ConfirmCancel(booking.Person.Name, booking.StartingDay);
                        break;
                }

                complete = questionnaire.GetBookingComplete();

                if (complete)
                    break;
            }
        }

        private HotelBooking OpenNewBooking()
        {
            if (TryGetBookingDate(out DateData dates))
            {
                string name = questionnaire.AskForUserName();
                string email = questionnaire.GetUserEmail();
                int phone = questionnaire.GetPhoneNumber();
                Person guest = new(name, email, phone);
                int id = idgenrator.GenerateUniqueID();
                HotelBooking booking = new(guest, dates.Start, dates.End, id);
                return booking;
            }
            else
                return null;

        }

        private HotelBooking CancelBooking()
        {
            if (TryFindBookingByID(out HotelBooking booking))
            {
                hotelManager.CancelBooking(booking);
                return booking;
            }
            else
                return null;
        }

        private HotelBooking UpdateBooking()
        {
            if (TryFindBookingByID(out HotelBooking booking))
            {
                if(TryGetBookingDate(out DateData dates))
                {
                    booking.StartingDay = dates.Start;
                    booking.EndDay = dates.End;
                    return booking;
                }
                else
                {
                    Console.WriteLine("Rebooking cancelled, returning to base options.");
                    return null;
                }
            }else
            {

                Console.WriteLine("Could not retrieve booking, jumping to base options.");
                return null;
            }
        }

        private bool TryGetBookingDate(out DateData data)
        {
            data = new();
            while(true)
            {
                DateTime startDate = questionnaire.AskForStartDate();
                int days = questionnaire.AskForLengthOfStay();
                DateTime endDate = startDate.AddDays(days);

                if (hotelManager.IsDateAvailable(startDate, endDate))
                {
                    data = new DateData { Start = startDate, End = endDate };
                    return true;
                }
                else
                {
                    if (!questionnaire.GetUserContinueOrCancel())
                        return false;
                }
            }
        }

        private bool TryFindBookingByID(out HotelBooking booking)
        {
            while (true)
            {
                int bookingID = questionnaire.GetBookingNumber();
                booking = hotelManager.FindBooking(bookingID);

                if (booking != null)
                    return true;

                Console.WriteLine("Could not find your booking, please try again.");

                if (questionnaire.GetCancelCurrentAction())
                    return false;
            }
        }

    }
}
