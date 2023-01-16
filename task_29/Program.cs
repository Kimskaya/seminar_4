//task 29: Program which makes an array of 8 components

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] GetRandomArray (int Length)
{
    int [] arr = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         arr [i] = new Random().Next();
    }
    return arr;
}
int [] Array = GetRandomArray (8);

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);
