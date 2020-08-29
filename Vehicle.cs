using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Vehicle
    {
        public string model { get; set; }
        public double topSpeed { get; set; }
        public int personnelCapacity { get; set; }

        public virtual void VehicleDetails()
        {
            Console.WriteLine($"Model: {model} \nTop Speed: {topSpeed} \nPersonnel Capacity: {personnelCapacity}");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting Engine...Engine On");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping Engine...Engine Off");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }

        public void Decelerate()
        {
            Console.WriteLine("Decelerating...");
        }

        public void Brake()
        {
            Console.WriteLine("Braking...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping...Stopped");
        }


    }
}
