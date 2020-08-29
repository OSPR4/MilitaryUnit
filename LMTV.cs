using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class LMTV : Vehicle
    {
        public int payloadCapacity { get; set; }

        public override void VehicleDetails()
        {
            Console.WriteLine($"Model: {model} \nTop Speed: {topSpeed} \nPersonnel Capacity: {personnelCapacity}\n" +
                $"Payload Capacity: {payloadCapacity}");
        }


    }
}
