using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Part_Two
{
    internal class Manager : Person
    {
  
        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} is holding a meeting at the hotel.");
        }

        public void PlanBudget() => Console.WriteLine("Jag planerar budgeten.");

    }
}
