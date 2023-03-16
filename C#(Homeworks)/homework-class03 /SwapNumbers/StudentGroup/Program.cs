// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] G1 = { "Dejan", "Elena", "Biljana", "Ana", "Bojan" };
string[] G2 = { "Marija", "Monika", "Tamara", "Ema", "Teo" };
Console.WriteLine("Enter student group:(There are 1 or 2)");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber == 1)
{
    foreach (string groupName in G1)
    {
        Console.WriteLine(groupName);

    }
    
}
 else if (inputNumber == 2)
{
    foreach (string groupName in G2)
    {
        Console.WriteLine(groupName);

    }


}

