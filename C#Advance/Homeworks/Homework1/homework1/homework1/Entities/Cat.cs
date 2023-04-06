using System;
using homework1.Entities.Interfaces;

namespace homework1.Entities
{
	public class Cat : Animal,ICat
	{
		public Cat(string name, string breed, int age, string color) : base(name, breed, age, color)
		{
		}

        public override void PrintAnimal()
        {
            Console.WriteLine("Cat is Halle Barry");
        }

        public void Eat (string food)
        {
            Console.WriteLine($"The cats like to eat {food}");
        }
    }
}

