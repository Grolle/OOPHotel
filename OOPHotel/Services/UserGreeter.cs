using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Services
{
    internal class UserGreeter
    {


        #region Greet
        public void GreetUser() => Console.WriteLine("Welcome to OOP Hotel.");
        public void ConfirmBooking(string name, DateTime date, int id) => Console.WriteLine($"Thank you {name}! Your booking is confirmed for {date}, booking id {id}.");
        public void ConfirmRebook(string name, DateTime date) => Console.WriteLine($"Thank you {name}! You are rebooked for date {date}.");
        public void ConfirmCancel(string name, DateTime date) => Console.WriteLine($"Thank you {name}! Your reservation for date {date} is not cancelled.");
        public void ReadyForCancellingBooking() => Console.WriteLine("You are ready to cancel your stay at OOPHotel. Please verify information.");
        public void ReadyToYUpdateBooking() => Console.WriteLine("You are ready to update your booking. Please verify information.");
        public void GuestPresenter(Person person)
        {
            Console.WriteLine("kontaktinformation");
            Console.WriteLine($"Namn: {person.Name}");//name
            Console.WriteLine($"Email:{person.Email} ");//email
            Console.WriteLine($"phone number: {person.Phone}");// phonenumber

        }
        #endregion
    }
}
