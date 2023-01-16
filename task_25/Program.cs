// task 25 . a cycle wich takes two numbers  A and B and raises it into the power of B  
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
