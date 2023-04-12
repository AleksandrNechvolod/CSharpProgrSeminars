// Задача 42:
//  Напишите программу, которая 
//  1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecToBin(int decimalNumber)
{
  string dec = string.Empty;
  while (decimalNumber > 0)
  {
    dec = decimalNumber % 2 + dec;
    decimalNumber /= 2;
  }
  return dec;
}

Console.Clear();
int decimalNum = 2;
string result = DecToBin(decimalNum);
Console.WriteLine(result);