using Akutmottagningen.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Controllers
{
    internal class HotelBooking
    {
        string Name { get; set; }
        DateTime Starting { get; set; }
        int AddedDay { get; set; }

       public  HotelBooking(string name,  DateTime starting, int addedDay)
        {
            Name = name;
            Starting = starting;
            AddedDay = addedDay;
        }

    }
}
