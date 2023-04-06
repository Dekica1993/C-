using System;
using Homework2.Entities.Interfaceses;

namespace Homework2.Entities
{
    public class Truck : Vehicle,IRepairService,IGusPump
    {
        public bool CheckVehicle(string Cars, string Trucks)
        {
            if (Cars == "honda")
            {
                return true;
            }
            else if (Trucks == "Volvo")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override void Drive()
        {
            Console.WriteLine("Truck is very expensive");
        }

        public bool FixVehicle(string Cars,string Trucks)
        {
            if (Cars == "honda")
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
            Console.WriteLine($"{Cars} and {Trucks} they can't compete with moto GP");
        }
    }
}

