using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Services
{
    internal class IDGenerator
    {
        private int id = 0;
        public int GenerateUniqueID() {return ++id; } 
    }
}
