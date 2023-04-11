using System;
namespace homework3
{
	public class Vehicle
	{
		public int Id { get; set; }

		public char Type { get; set; }

		public int YearOfProduction { get; set; }

		public int BatchNumber { get; set; }

        public string PrintVehicle(int id, char type, int yearOfProduction)
        {
            return $" with this id no. {id} and  type  {type} is made {yearOfProduction}";
        }
    }
	
}

