using System;
namespace Homework4.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public int MaxSpeed { get; set; }

		public int HorsePower { get; set; }

		public string FuelType { get; set; }

		public abstract void Drive(string destinationName);
	}


}

