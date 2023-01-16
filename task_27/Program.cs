//task 27 . programm takes a number and shows the sum of its dogits 
// 452 -> 11;    82 -> 10;    9012 -> 12

int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int UserNumber = int.Parse(Console.ReadLine()!);
    return UserNumber;
}
int Number = GetUserNumber("Input Any Number");

int GetDigitSum (int Number)

{
    int Sum = 0;
    while (Number>=1)  
    {
    int Component  = Number%10;
    Number = Number/10;
    Sum = Sum + Component;
    }
    return Sum;
}
    int sum = GetDigitSum (Number);

Console.WriteLine ($"The sum of the digits in your number is {sum} ");