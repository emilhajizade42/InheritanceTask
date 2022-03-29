using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    internal class Car
    {
        public string Brand, Model, Color;
        public int MaxSpeed;

        public virtual void Info()
        {
            Console.WriteLine($"___All informations___ \n  brand : {Brand}  \n  model : {Model}   \n  color : {Color}\n  maxSpeed : {MaxSpeed}  ");
        }

        public Car()
        {
            Console.WriteLine("Car Created");
        }
        public Car(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;


        }
        public Car(string brand, string model, string color, int maxSpeed) : this(brand, model)
        {

            Color = color;
            MaxSpeed = maxSpeed;

        }
    }
}
