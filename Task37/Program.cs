// Задача 37.
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. 
// 2. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductPairNumbers(int[] arr)
{
  int size = arr.Length % 2 > 0 ? arr.Length / 2 + 1 : arr.Length / 2;
  int[] newArr = new int[size];
  for (int i = 0; i < arr.Length / 2; i++)
  {
    int number = arr[i] * arr[arr.Length - 1 - i];
    newArr[i] = number;
  }

  if(arr.Length % 2 > 0)
  {
    int indexMedium = arr.Length / 2;
    newArr[size - 1] = arr[indexMedium];
  }
  return newArr;
}

void PrintNewArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
}

Console.Clear();
int[] array = CreateArrayRndInt(6, -2, 4); // для получения разных массивов меняем первый элемент в скобках.
PrintArray(array);
int[] newArray = ProductPairNumbers(array);
Console.WriteLine();
Console.WriteLine(" -> ");
PrintNewArray(newArray);