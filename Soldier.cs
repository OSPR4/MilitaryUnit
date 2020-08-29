using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Soldier
    {
        public string LastName { get; set; }

        public string FistName { get; set; }
        public string Rank { get; set; }
        public int DOD_ID { get; set; }

        public virtual void Duty()
        {
            Console.WriteLine("Stand at Attention");
        }
        public void SMDetails()
        {
            Console.WriteLine($"Name: {Rank} {LastName}, {FistName} \nDoD ID: {DOD_ID}");
            Console.Write("Duty: ");
            Duty();
        }
    }
}
