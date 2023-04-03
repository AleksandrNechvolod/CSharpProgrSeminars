// Задача 19. Напишите программу, которая
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да

// int FiveDigitNumber(string message)
// {
//   Console.WriteLine(message);
//   string number = Console.ReadLine();
//   int result = Convert.ToInt32(number);
//   return result;
// }

bool Palindrome(int num)
{

  return num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10;
}


Console.Clear();
Console.Write("Введите пятизначное число -> ");

int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number <= 9999 || number > 99999)
Console.WriteLine("Это не пятизначное число. Введите пятизначное.");

bool result = Palindrome(number);

if (number > 9999 || number <= 99999)
{
  Console.WriteLine(result ? "Число является палиндромом." : "Число не является палиндромом.");
}

