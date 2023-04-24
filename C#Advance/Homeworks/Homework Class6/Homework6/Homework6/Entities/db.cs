using System;
namespace Homework6.Entities
{
	public static class db
	{
		public static List<Person> Persons = new List<Person>()
		{
		new Person("Dejan",30),
        new Person("Elena",26),
        new Person("Biljana",19),
        new Person("Ana",23),
        new Person("Bojan",25),
        new Person("Marija",23),
        new Person("Teo",25),

        };

		public static List<Dog> Dogs = new List<Dog>()
		{
		new Dog	("Brzi",3),
		new Dog	("Rex",1),
		new Dog	("Flufy",2),
		new Dog	("Ms. Gorgeous",5),
		new Dog	("Dog the III",3),
		new Dog	("Aron",4),
		new Dog ("Krki",2),
        new Dog ("Brki",6),
        new Dog ("Svrki",1),


        };

		

		public static void PrintInfo<T>(this List<T> list) where T : Person
		{
			Console.WriteLine($"Printing {list.Count} names");
			foreach (T name in list)
			{
				name.PrintInfo();
			}
		}
	}
}

