﻿// Задача 45: 
// 1. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArray(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = arr[i];
  }
  return newArr;
}

Console.Clear();
int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.Write("  ->  ");
int[] newArray = CopyArray(array);
// newArray[0]=11;  средство для проверки нового массива.
PrintArray(newArray);

// bool Equal(int[] arr, int[] newwArr) //Возможный метод для проверки значений массивов.
// {
//   if (arr.Length != newwArr.Length)
//   {
//     return false;
//   }
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if (arr[i] != newArr[i])
//     {
//       return false;
//     }
//   }
//   return true;
// }

// bool result = Equal(array, newArray); // Вывод метода проверки, расположенного выше
// Console.WriteLine(result ? "Равны" : "Не равны");