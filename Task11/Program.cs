// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число -> {number} ");
int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Итог после удаления второй цифры -> {removeSecondDigit} ");


int RemoveSecondDigit(int num)  //num = number!!!!! 
{
  int firstDigit = num / 100;
  int thirdDigit = num % 10;
  int result = firstDigit * 10 + thirdDigit;
  return result;
}

