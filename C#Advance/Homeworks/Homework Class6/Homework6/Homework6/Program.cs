
using Homework6.Entities;

List<Person> firstNamesWithR = db.Persons.OrderBy(x => x.Name == "R" && x.Age > 30).ToList();

firstNamesWithR.PrintInfo();

Console.WriteLine("\n");

List<Dog> findAllDogsOlderThen3 = db.Dogs.OrderBy(x => x.Age > 3).ToList();

findAllDogsOlderThen3.PrintInfo();

Console.WriteLine("\n");

List<Dog> printNamesOfDogs = db.Dogs.OrderBy(x => x.Name).ToList();


printNamesOfDogs.PrintInfo();

Console.WriteLine("\n");


List<Person> printAllPersonMoreThan2Dogs = db.Persons.OrderByDescending(x => x.Name).ToList();

printAllPersonMoreThan2Dogs.PrintInfo();

Console.WriteLine("\n");

List<Dog> findAllFreddiesOlder = db.Dogs.Where(x => x.Age > 1).ToList();

findAllFreddiesOlder.PrintInfo();

Console.WriteLine("\n");

List<Person> findAllDejanFirstDog = db.Persons.Where(x => x.Name == "brki").ToList();

findAllDejanFirstDog.PrintInfo();


List<Dog> findAllDogsNames = db.Dogs.OrderBy(x => x.Name).ToList();

findAllDogsNames.PrintInfo();














