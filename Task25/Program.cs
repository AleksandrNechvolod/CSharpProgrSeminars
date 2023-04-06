// Задача 25. Напишите цикл, который
// принимает на вход два числа (А и В) и
// возводит число А в натуральную степерь В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 <= 0)
{
  Console.WriteLine
  ($"Данное число {num2} не является натуральной степенью. Введите натуральное число.");
  return;
}

 int exponentiation = Exponentiation(num1, num2);

Console.WriteLine($"Число {num1} в степени {num2} = {exponentiation}");   

int Exponentiation(int number1, int number2)
{
  int exponent = 1;
  for (int i = 0; i < number2; i++)
  {
    exponent = exponent * number1;
  }
  return exponent;
}