using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Part_Two
{
    internal class Employee : Person
    {


        public string JobTitle { get; set; }


   

        public void Work()
        {
            Console.WriteLine($"{Name} is doing they job as {JobTitle}, they keep the hotel running.");
        }
    }
}
