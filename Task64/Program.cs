﻿// Задача 64: 
// 1. Задайте значение N. 
// 2.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine($"Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("-> ");
NuturalNumbers(number);
Console.Write(".");

void NuturalNumbers(int num)
{
  if (num == 0) return;
  Console.Write($"{num}, ");
  NuturalNumbers(num - 1);
}
