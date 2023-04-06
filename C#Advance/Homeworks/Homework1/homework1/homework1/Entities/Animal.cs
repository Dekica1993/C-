using System;
using homework1.Entities.Interfaces;

namespace homework1.Entities
{
	public abstract  class Animal : IAnimal
	{
		public string Name { get; set; }
		public string Breed { get; set; }
		public int Age { get; set; }
		public string Color { get; set; }

        public abstract void PrintAnimal();

		public Animal (string name,string breed,int age,string color)
		{
			Name = name;
			Breed = breed;
			Age = age;
			Color = color;
		}

		

        

        
    }



	
    
}

