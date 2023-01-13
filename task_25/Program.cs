// Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) 2, 4 -> 16

int ExtendedNumber(int numberA, int numberB)
{
  int result = 1;
  for(int countExtend= 1; countExtend <= numberB; countExtend++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = int.Parse(Console.ReadLine()!);
  Console.Write("Введите число B: ");
  int numberB = int.Parse(Console.ReadLine()!);

  int Extended = ExtendedNumber(numberA, numberB);
  Console.WriteLine("A raised to the power B is " + Extended);
