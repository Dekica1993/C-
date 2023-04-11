using System;
namespace Homework4.Entities
{
	public static class GenericDb<T> where T : BaseEntity
	{
		public static List<T> Db;
		
		public static void Insert(T car)
		{
			Db.Add(car);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"The car{car.GetType().Name} was added to the GenericDb.");
			Console.ResetColor();
		}

		public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);
	}
}
 
