using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Part_Two
{
    internal abstract class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public float Salary { get; set; }
        public string Department { get; set; }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name : {Name} Age : {Age}");
        }

        public virtual void Introduction(string introText)
        {
            Console.WriteLine(introText);
        }

    }
}
