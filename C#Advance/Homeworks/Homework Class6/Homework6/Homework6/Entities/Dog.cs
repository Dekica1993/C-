using System;
namespace Homework6.Entities
{
	public class Dog : Person
	{
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

		public int Age { get; set; }

		

       

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Age} is years old is with dog's {Name}");
        }
    }
}

