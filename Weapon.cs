using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        public string WeaponSystem { get; set; }

        public string Caliber { get; set; }
        public string RateOfFire { get; set; }

        public void WeaponDetails()
        {
            Console.WriteLine($"Weapon System: {WeaponSystem}  \nCaliber: {Caliber}\n" +
                $"RateOfFire: {RateOfFire}");
            Console.Write("Sound: ");
            Sound();
        }

        public virtual void Sound()
        {
            Console.WriteLine("Bang Bang");
        }
    }
}
