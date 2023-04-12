// Задача 42:
//  Напишите программу, которая 
//  1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecToBinString(int decimalNumber) // Решение через строковый метод
{
  if (decimalNumber == 0 || decimalNumber == 1)
  {
    return decimalNumber.ToString();
  }
  string dec = string.Empty;
  while (decimalNumber > 0)
  {
    dec = decimalNumber % 2 + dec;
    decimalNumber /= 2;
  }
  return dec;
}

int DecToBinInt(int decimalNumber) // Решение через числовой метод
{
  if (decimalNumber == 0 || decimalNumber == 1)
  {
    return decimalNumber;
  }
  int dec = 0;
  int i = 1;
  while (decimalNumber > 0)
  {
    dec = dec + decimalNumber % 2 * i;
    decimalNumber /= 2;
    i *= 10;
  }
  return dec;
}

Console.Clear();
int decimalNum = 45;
string result = DecToBinString(decimalNum); 
int result1 = DecToBinInt(decimalNum);
Console.WriteLine(result);
Console.WriteLine(result1);