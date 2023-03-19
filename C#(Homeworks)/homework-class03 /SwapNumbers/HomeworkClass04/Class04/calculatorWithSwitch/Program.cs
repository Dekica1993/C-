// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int SumOfTwoNumbers (int Number1, int Number2)
{

    int ResultSum = Number1 + Number2;
    return ResultSum;
}

int SubStractTwoNumbers (int Number1, int Number2)
{
    int ResultSubStract = Number1 - Number2;
    return ResultSubStract;

}

int MultiplyTwoNumbers (int Number1, int Number2)
{
    int ResultMultiplyTwoNumbers = Number1 * Number2;
    return ResultMultiplyTwoNumbers;

}

int DivideTwoNumbers (int Number1, int Number2)
{
    int ResultDivideTwoNumbers = Number1 / Number2;
    return ResultDivideTwoNumbers;

}

Console.WriteLine("Input Operator");
char operation = char.Parse(Console.ReadLine());


int FinalOperator (int input1, int input2)
{

    int result = 0;
    switch(operation)
    {

        case '+':
            result = SumOfTwoNumbers(input1, input2);
                break;

        case '-':
            result = SubStractTwoNumbers(input1, input2);
                break;

        case '*':
            result = MultiplyTwoNumbers(input1, input2);
                break;

        case '/':
            result = DivideTwoNumbers(input1, input2);
            break;
         
    }

    return result;


}
Console.WriteLine("Input number 1");
int InputNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int InputNumber2 = Convert.ToInt32(Console.ReadLine());
int UserInput = FinalOperator(InputNumber1, InputNumber2);
Console.WriteLine("The result is" +" "+ UserInput);



