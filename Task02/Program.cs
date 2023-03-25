// Задача 2. Напишите программу, которая 
// на вход принимает два числа и 
// выдаёт, какое число большее, а какое маньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите перое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
  Console.WriteLine($"Max = {a}");
}
else if (a < b)
{
  Console.WriteLine($"Min = {a}");
}
if (b > a)
{
  Console.WriteLine($"Max = {b}");
}
else if (b < a)
{
  Console.WriteLine($"Min = {b}");
}
