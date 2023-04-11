using System;
namespace Homework4.Entities
{
	public class AmericanCar : BaseEntity
	{
        public AmericanCar(int id, string brand, string model, int maxSpeed, int horsePower, string fueltype)
        {
            Id = id;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            FuelType = fueltype;
        }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"You're arrive at your {destinationName}");
        }
    }
}

