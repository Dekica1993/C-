using System;
namespace Homework2.Entities
{
    public class Car : Vehicle,ICarWash
    {
        public override void Drive()
        {
            Console.WriteLine("My dream is to drive Ferarri!");
        }

        public string Truck(string Trucks)
        {
            return $"The {Trucks} is very powerfull";
        }

        public void WashCars(string Cars)
        {
            Console.WriteLine($"{Cars} nowdays is very expensive good LOOOORD!");
        }
    }
}

