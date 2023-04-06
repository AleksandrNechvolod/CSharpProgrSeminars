// Задача 29. Напишите программу, которая
// задаёт мвссив из 8 элементов, заполненный 
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

Console.Write("Введите min число массива из 8 элементов: ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max число массива из 8 элементов: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(8, minDigit, maxDigit);

PrintArray(array);

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random random = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = random.Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write("]");
}



