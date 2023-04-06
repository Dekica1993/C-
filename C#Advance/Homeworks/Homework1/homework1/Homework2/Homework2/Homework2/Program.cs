using Homework2.Entities;

CarCenter honda = new CarCenter();
honda.WashCars("Bugatti");
Console.WriteLine(honda.Truck("Lada")); 

Truck lada = new Truck();
Console.WriteLine(lada.CheckVehicle("Ferari", "Fiat"));
Console.WriteLine(lada.FixVehicle("Honda", "Volvo")); 