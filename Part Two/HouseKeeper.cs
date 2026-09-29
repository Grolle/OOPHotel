using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Part_Two
{
    internal class HouseKeeper : Person
    {

        public void Work()
        {
            Console.WriteLine($"{Name} städar hotellrummen.");
        }
    }
}
