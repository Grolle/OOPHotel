using OOPHotel.Containers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOPHotel.Presentation
{
    internal class GuestPresenter
    {
        public void Presenter(Person person)
        {

            Console.WriteLine("kontaktinformation");
            Console.WriteLine($"Namn: {person.Name}");//name
            Console.WriteLine($"Email:{person.Email} ");//email
            Console.WriteLine($"phone number: {person. Phone}");// phonenumber



        }





    }
    }

}
