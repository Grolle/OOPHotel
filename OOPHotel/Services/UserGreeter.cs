using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Services
{
    internal class UserGreeter
    {


        #region Greet
        public void GreetUser() => Console.WriteLine("Welcome to OOP Hotel.");
        public void ConfirmBooking() => Console.WriteLine("Your booking is confirmed");
        public void ReadyForCancellingBooking() => Console.WriteLine("You are ready to cancel your stay at OOPHotel. Please verify information.");
        public void ReadyToYUpdateBooking() => Console.WriteLine("You are ready to update your booking. Please verify information.");
        #endregion
    }
}
