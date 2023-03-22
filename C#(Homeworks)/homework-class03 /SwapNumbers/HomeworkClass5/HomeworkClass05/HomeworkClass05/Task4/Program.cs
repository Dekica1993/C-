// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("When is your birthdate?");
string inputBirthdate = Console.ReadLine();

string   AgeCalculator ( string inputBirthdate)
{
    DateTime birthDate = Convert.ToDateTime(inputBirthdate);
    int age = DateTime.Now.Year - birthDate.Year;
    return $"You're {age} years old";
}

Console.WriteLine(AgeCalculator(inputBirthdate));











