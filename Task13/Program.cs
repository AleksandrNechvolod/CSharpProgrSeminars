// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int ThirdDigit(int num)
{
  int result = -1;
  if (num >= 100)
  {
    while (num > 999)
    {
      num = num / 10;
    }
    result = num % 10;
  }
  return result;
}

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number) == -1)
  Console.WriteLine("третьей цифры нет");
else
  Console.WriteLine($"Третья цифра числа: {ThirdDigit(number)}");