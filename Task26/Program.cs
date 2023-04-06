// Задача 26: Напишите программу, которая
//  принимает на вход число и 
//  выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите целое число-> ");

int number = Convert.ToInt32(Console.ReadLine());
int count = CountDigit(number);

Console.WriteLine($"Количество цифр в числе {number} = {count}");

int CountDigit(int num)
{
  int countDigit = 0;
  while (num != 0)
  {
    countDigit++;
    num /= 10;

  }
  return countDigit;
}
