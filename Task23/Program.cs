﻿// Задача 23. Напишите программу, которая 
// на вход принимает число (N) и
// выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите натуральное число -> ");
int num = Convert.ToInt32(Console.ReadLine());

CubeTable(num);


void CubeTable(int number)
{
  for (int i = 1; i <= number; i++)
  {
    int cube = i * i * i;
    Console.WriteLine($"{i,3} -> {cube,7}");
  }
}
