// Задача 28: Напишите программу, которая
// принимает на вход число N и
//  выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите целое положительное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
  Console.Write
  ($"Это не натуральное число {number}. Введите натуральное положительное число.");
  return;
}

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
  int product = 1;
  for (int i = 2; i <= num; i++)
  {
    checked // оператор ограничивает выисление, чтобы не было переполнения типа.
    {
      product = product * i;
    }
  }
  return product;
}
