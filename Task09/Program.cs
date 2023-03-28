// // Задача 9. Напишите программу, которая
//  выводит случайное число из отрезка [10, 99] и 
//  показывает наибольшую цифру числа.

// // 78 -> 8 // 78 / 10 = 7
// // 12-> 2
// // 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// Первое решение через условный оператор

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) // при равных, например 88, вывод else
  Console.WriteLine($"Наибольшая цифоа числа -> {firstDigit}");
else
  Console.WriteLine($"Наибольшая цифоа числа -> {secondDigit}");

// Второе решение-через тернарного оператора.
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// Третье решение - через метод

int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");

int MaxDigit(int num)  //num = number!!!!! = 78
{
  int firstDigit = num / 10;
  int secondDigit = num % 10;
  int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
  return maxDigit;
}
