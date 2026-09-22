using Akutmottagningen.Questions;
using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class HotelBooking
    {
        Person Person { get; set; }
        DateTime Starting { get; set; }
        int AddedDay { get; set; }

       public  HotelBooking(Person person,  DateTime starting, int addedDay)
        {
            Person = person;
            Starting = starting;
            AddedDay = addedDay;
        }

    }
}
