// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int[] arrays = new int[6];
int sum = 0;

for (int i = 0; i < 6;   i ++)
{
    Console.WriteLine("enter number");
    arrays[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int num in arrays)
{
    if (num % 2 == 0)
        sum += num;

}




Console.WriteLine($"The result is: {sum}");