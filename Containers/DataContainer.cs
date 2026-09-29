using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Containers
{
    public struct DataContainer
    {
        public DataContainer()
        {
            IsAvailable = false;
            IDRoom = 0;
        }
        public bool IsAvailable { get; set; }
        public int IDRoom { get; set; }
    }
}
