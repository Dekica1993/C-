// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int SumOfNumbers (int input1)
{
    string inputEx = Convert.ToString(input1);
    int sum = 0;
    for (int i = 0; i < inputEx.Length; i++)
        sum += Convert.ToInt32(inputEx.Substring(i, 1));
    return sum;

}

    void SumOfNumber()
    {
        int num;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of the digit of the number {0} is:{1}", num, SumOfNumbers(num));

    }

SumOfNumber();


