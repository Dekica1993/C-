using System;
using homework1.Entities.Interfaces;

namespace homework1.Entities
{
	public class Dog : Animal,IDog
	{
        public Dog(string name, string breed, int age, string color) : base(name, breed, age, color)
        {
        }

        public string Bark()
        {
            return "This days dogs at night are gangstaaas";
        }
		

        public override void PrintAnimal()
        {
            Console.WriteLine("All dogs are funny");
        }
    }

    
}

