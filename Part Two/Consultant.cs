using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel.Part_Two
{
    internal class Consultant : Person
    {
        public float HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; } = "ingen expertis";


        public void GiveAdvice() => Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner. Min expertis är {Expertise}");

    }
}
