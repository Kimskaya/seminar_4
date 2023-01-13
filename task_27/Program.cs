//Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11;    82 -> 10;    9012 -> 12

int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int AnyNumber = int.Parse(Console.ReadLine()!);
    return AnyNumber;
}
int Number = GetUserNumber("Input Any Number");

int GetSum (int Number);
{
    int Sum = 0;
    while (Number>=1/10)
    {
    int Component  = Number%10;
    int Result = Sum + Component;
    }
    return Result;
}
int sum = GetSum(Number);
Console.WriteLine ($"The sum of the digits in your number is {sum} ");


