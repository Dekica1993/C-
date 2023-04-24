using System;
namespace Homework6.Entities
{
    public class Person 
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }
}

