/*
Class:       ISTA 220 Programming Fundamentals in C#
Student:     Osee Pierre
Instructor:  Christine Lee
Date:        08/25/20
Description: Implementing a military unit using inheritance
Revised:     
Revised by:  
Revision:   
*/
using System;


namespace MilitaryUnit
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Unit();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Unit()
        {
            LogisticsSoldier soldier = new LogisticsSoldier()
            {
                LastName = "Rogers",
                FistName = "Steven",
                Rank = "SPC/E4",
                DOD_ID = 12345676

            };
            LMTV LMTV1 = new LMTV()
            {
                model = "M1078 A1P2 LMTV",
                topSpeed = 70,
                personnelCapacity = 20,
                payloadCapacity = 2000

            };

            HUMVEE HQ6 = new HUMVEE()
            {
                model = "M1025A2 HMMWV",
                topSpeed = 80,
                personnelCapacity = 4,
                weaponPlatform = "M2 .50 Caliber Machine Gun"
            };
            SmallArms M41 = new SmallArms()
            {
                WeaponSystem = "M4A1 Carbine",
                Caliber = "5.56mm",
                RateOfFire = "Automatic"

            };
            soldier.SMDetails();
            Console.WriteLine();
            LMTV1.VehicleDetails();
            Console.WriteLine();
            HQ6.VehicleDetails();
            Console.WriteLine();
            M41.WeaponDetails();

        }
    }
}
