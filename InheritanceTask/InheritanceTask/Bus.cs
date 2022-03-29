using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    internal class Bus:Car
    {
       int PassengerCount ;

        public override void Info()
        {
            Console.WriteLine($"___All informations___ \n  brand : {Brand}  \n  model : {Model}   \n  color : {Color}\n  maxSpeed : {MaxSpeed}\n  PassengerCount : {PassengerCount}   ");
        }
        public Bus(string brand, string model, string color, int maxSpeed,int passengerCount) :base(brand, model, color, maxSpeed)
        {
            PassengerCount = passengerCount;
        }
    }
}
