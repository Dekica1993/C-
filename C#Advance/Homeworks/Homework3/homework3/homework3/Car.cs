using System;
namespace homework3
{
	public class Car : Vehicle
	{
		public int FuelTank { get; set; }

		public string Countries { get; set; } = string.Empty;

		public Car(int id,char type,int yearOfProduction, int batchNumber, int fueltank,string countries)
		{
			Id = id;
			Type = type;
			YearOfProduction = yearOfProduction;
			BatchNumber = batchNumber;
			FuelTank = fueltank;
			Countries = countries;

		}
		public string PrintVehicle(char type,string countries)
		{
			return $"This {type} is in this {countries}";
		}
	}
}

