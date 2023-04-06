using System;
using Homework2.Entities.Interfaceses;

namespace Homework2.Entities
{
    public class CarCenter : ICarWash, IGusPump, IRepairService
    {
        public bool CheckVehicle(string Cars, string Trucks)
        {
           if(Cars == "Honda")
            {
                return true;
            }
           else if(Trucks == "Volvo")
            {
                return true;
            }
            return false;

        }

        public bool FixVehicle(string Cars, string Trucks)
        {
            if (Cars == "Honda")
            {
                return true;
            }
            else if (Trucks == "Volvo")
            {
                return true;
            }
            return false;
        }

        public void PumpGas(string Cars, string Trucks)
        {
            Console.WriteLine($"{Cars} and {Trucks} is Dakar!");

        }


        public string Truck(string Trucks)
        {
            return $"{Trucks} is very large";
        }

        

        public void WashCars(string Cars)
        {
            Console.WriteLine($"{Cars}  is like Honda , Mercedes is Elite");
        }
    }
}