using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class HUMVEE : Vehicle
    {
        public string weaponPlatform { get; set; }
        public override void VehicleDetails()
        {
            Console.WriteLine($"Model: {model} \nTop Speed: {topSpeed} \nPersonnel Capacity: {personnelCapacity}\n" +
                $"Weapon Platform: {weaponPlatform}");
        }

    }
}
