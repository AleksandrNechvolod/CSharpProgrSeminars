// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

 Console.Clear();
// Первое решение

// int[] array = new int[8];
// CreateArray(array);
// PrintArray(array);

// void CreateArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 2);
//   }
// }

// void PrintArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
// }

// Второе решение (для любого размера массива)

Console.Write("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
  Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
  return ;
}

int[] arr = CreateArray(arraySize);

PrintArray(arr);

int[] CreateArray(int arrayLength)
{
  int[] newArray = new int[arrayLength];
  Random random = new Random();

  for (int i = 0; i < arrayLength; i++)
  {
    newArray[i] = random.Next(0, 2);
  }
  return newArray;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}