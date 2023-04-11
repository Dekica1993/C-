using System;
namespace homework3
{
	public static class DB 
	{
        public static List<Vehicle> Vehicles;

        public static List<Car> Cars;

        public static List<Bike> Bikes;

        static DB()
        {
            Cars = new List<Car>()
            {
                new Car (1,'+',2010,33,85,"Germany"),
                new Car (2,'-',2015,30,75,"Italy"),
                new Car (3,'?',2018,88,35,"France"),
                new Car (4,'>',2020,101,45,"Slovenia"),
                new Car (5,'<',2023,44,60,"Macedonia")
            };

            Bikes = new List<Bike>()
            {
                new Bike (6,'&',2009,10,"Red"),
                new Bike (7,')',2012,20,"Yellow"),
                new Bike (8,'(',2021,40,"Black"),
                new Bike (9,'{',2019,444,"Purpole"),
                new Bike (10,'}',2017,375,"Pink")
            };

            
             
        }

        
    }

   
}

