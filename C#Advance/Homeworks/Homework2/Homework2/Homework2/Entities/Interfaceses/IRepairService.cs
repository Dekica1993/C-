using System;
namespace Homework2.Entities.Interfaceses
{
	public interface IRepairService
	{
		bool CheckVehicle(string Cars,string Trucks);

		bool FixVehicle(string Cars, string Trucks);
	}
}

