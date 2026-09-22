using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Containers
{
    public class Person
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        //Person guest = new Person(name, email, phone);
        public Person(string name, string email, int phone)
        {
            Name = name;
            Email = email;
            Phone = phone;

        }

    }
}

