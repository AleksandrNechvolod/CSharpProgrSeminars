// Задача 67: Напишите программу, которая 
// будет принимать на вход число и 
// возвращать сумму его цифр. 
// 453 -> 12 45 -> 9 

Console.Clear();
Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр данного числа -> {SumDigits(x)}");

int SumDigits(int n)
{
  if (n == 0) return 0;
  else return n % 10 + SumDigits(n / 10);
}
