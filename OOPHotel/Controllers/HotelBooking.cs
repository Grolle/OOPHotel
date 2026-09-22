using Akutmottagningen.Questions;
using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class HotelBooking
    {
        public Person Person { get; set; }
        public DateTime Starting { get; set; }
        public int AddedDay { get; set; }

        int IDRoom { get; set; } = -1;

       public  HotelBooking(Person person,  DateTime starting, int addedDay)
        {
            Person = person;
            Starting = starting;
            AddedDay = addedDay;
        }

    }
}
