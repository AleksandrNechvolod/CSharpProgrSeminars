// Задача 36.
// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечетных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);
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

int SumOddIndexes(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i += 2)
  {
    sum = sum + arr[i];
  }
  return sum;
}

Console.Clear();
int[] array = CreateArrayRndInt(4, -50, 50);
PrintArray(array);
int sumIndexes = SumOddIndexes(array);
Console.WriteLine($" -> {sumIndexes}");