using System;
namespace homework3
{
	public class Bike : Vehicle
	{
        public string Color { get; set; }

		public Bike(int id, char type, int yearOfProduction, int batchNumber,string color)
		{
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
            Color = color;
        }
        public void PrintVehicle (int yearOfProduction,string color)
        {
            Console.WriteLine($"Scot is mountingBike  made in {yearOfProduction} witht that {color}");
        }
	}
}

