using Akutmottagningen.Questions;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static OOPHotel.Services.BookingService;

namespace OOPHotel.Services
{
    internal class Questionnaire
    {
        private InputHander input;
        public Questionnaire() { input = new(); }

        #region Validators
        private bool DateTimeValid(DateTime date)
        {
            TimeSpan timeSpan = date - DateTime.Now;
            if (timeSpan.Days < 0) return false;
            else if (timeSpan.Days > 365) return false;
            else return true;
        }
        private bool UserReason(string reason)
        {
            string reasonTL = reason.ToLower();
            return (reasonTL == "rebook" || reasonTL == "cancel" || reasonTL == "book");
        }
        private bool ValidRoomNumber(int nr)
        {
            return (nr >= 0 && nr <= 30);
        }
        private bool ValidatePhoneNr(int nr)
        {
            int len = nr.ToString().Length;
            return len >= 8 && len <= 12;
        }
        private bool ValidateEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidateName(string name)
        {
            if (int.TryParse(name, out int i))//name cannot be int
                return false;
            else if (float.TryParse(name, out float f))//name cannot be float
                return false;

            return true;
        }
        private bool StayLengthValid(int length)
        {
            return (length > 0 && length <= 365);
        }
        private bool ValidYesNo(string str)
        {
            string strTL = str.ToLower();
            if (strTL == "yes" || strTL == "no") return true;
            else return false;
        }
        #endregion


        public string AskForUserName()
        {
            AskForName();
            string name = input.GetUserInput<string>(InputHander.InputData.String, ValidateName, "Please use only characters.");
            return name;
        }
        public UserBookingActions AskForUserReason()
        {
            AskForReason();
            string reason = input.GetUserInput<string>(InputHander.InputData.String, UserReason,"Please only use 'book' 'rebook' or 'cancel'");

            if (reason == "book")
                return UserBookingActions.Book;
            else if (reason == "rebook")
                return UserBookingActions.UpdateBooking;
            else
                return UserBookingActions.Cancel;
        }

        public DateTime AskForStartDate()
        {
            AskForDate();
            DateTime date = input.GetUserInput<DateTime>(InputHander.InputData.DateTime, DateTimeValid, "Please add correct formal 'yyyy-mm-dd");
            return date;
        }

        public int AskForRoomNumber()
        {
            AskRoomNumber();
            int number = input.GetUserInput<int>(InputHander.InputData.Int, ValidRoomNumber, "Please add number between 0-30");
            return number;
        }

        public int AskForLengthOfStay()
        {
            AskForLength();
            int length = input.GetUserInput<int>(InputHander.InputData.Int, StayLengthValid, "Add no negative number and maximum of 365 days.");
            return length;
        }

        public string GetUserEmail()
        {
            AskForEmail();
            string email = input.GetUserInput<string>(InputHander.InputData.String, ValidateEmail,"Please follow correct format 'nnn@nnn.nnn'");
            return email;
        }
        public int GetPhoneNumber()
        {
            AskForPhoneNumber();
            int nr = input.GetUserInput<int>(InputHander.InputData.Int, ValidatePhoneNr, "Please add a number with minimum length of 8 digits and maximum of 12 digits");
            return nr;
        }

        public bool GetBookingComplete()
        {
            AskForBookingComplete();
            string completeStr = input.GetUserInput<string>(InputHander.InputData.String, ValidYesNo, "Please use 'yes' or 'no'");
            return completeStr != "yes";
        }

        public int GetBookingNumber()
        {
            AskForBookingNumber();
            int bookingNumber = input.GetUserInput<int>(InputHander.InputData.Int, (int id)=> id > 0, "Please do not use negative numbers.");
            return bookingNumber;
        }

        public bool GetCancelCurrentAction()
        {
            AskUserToQuit();
            string completeStr = input.GetUserInput<string>(InputHander.InputData.String, ValidYesNo, "Please use 'yes' or 'no'");
            return completeStr == "yes";
        }

        #region Questions
        private void AskForReason() => Console.WriteLine("Do you want to book a new room, or cancel or rebook a room? (book/cancel/rebook)");
        private void AskForName() => Console.WriteLine("What is your name?");
        private void AskForDate() => Console.WriteLine("What date do you want to book (yyyy-mm-dd)");
        private void AskForLength() => Console.WriteLine("How long is your stay in days?");
        private void AskRoomNumber() => Console.WriteLine("What is your room nr?");
        private void AskForEmail() => Console.WriteLine("What is your email?");
        private void AskForPhoneNumber() => Console.WriteLine("What is your phone nr?");
        private void AskForBookingComplete() => Console.WriteLine("Do you want to make any changes? (yes/no)");
        private void AskUserToQuit() => Console.WriteLine("Do you want to cancel current action?");
        private void AskForBookingNumber() => Console.WriteLine("Please type in your booking number");
        #endregion
    }
}
