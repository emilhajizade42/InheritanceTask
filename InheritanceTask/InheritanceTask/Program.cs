using System;

namespace InheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Car("Nissan" ,"A4" ,"Black",140);
            a.Info();
            var b = new Bus("Toyota", "81", "red", 80, 40);
            b.Info();   
        }
    }
}
