using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class SmallArms : Weapon
    {

        public override void Sound()
        {
            Console.WriteLine("Pew... Pew... Pew...");
        }
    }
}
