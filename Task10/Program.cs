// Задача 10: Напишите программу, которая
// принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int TernaryCheck(string phrase)
{
  Console.Write(phrase);
  string num = Console.ReadLine();
  int result = Convert.ToInt32(num);
  return result;
}

int ShowSecondDigit(int num)
{
  int secondDigit = num / 10 % 10;
  return secondDigit;
}
Console.Clear();
int number = TernaryCheck("Трехзначное число -> ");
if (number < 100 || number > 999)
{
  Console.Write($"Это не трехзначное число. Введите трехзначное");
  return;
}
int result = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа ->{result}");



