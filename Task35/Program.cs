﻿// Задача 35: 
// 1. Задайте одномерный массив из 123 случайных чисел.
// 2. Найдите количество элементов массива, 
//    значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123.

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int CountElements(int[] arr, int min, int max)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= min && arr[i] <= max)
    {
      count++;
    }

  }
  return count;
}

Console.Clear();
int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);
int count = (CountElements(array, 10, 99));
Console.WriteLine( );
Console.WriteLine($"Количество элементов в диапазоне 10-99 = {count}.");
