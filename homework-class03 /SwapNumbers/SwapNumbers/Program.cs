// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1, number2;
Console.WriteLine("The first input number is:");
 number1 = int.Parse(Console.ReadLine());
Console.WriteLine("The second input number is:");
 number2 = int.Parse(Console.ReadLine());
(number1, number2) = (number2, number1);
Console.WriteLine("After swaping" + " " + "First number is:"
 + " "  + number1 + " " + "Second number is:" +" " + number2);

