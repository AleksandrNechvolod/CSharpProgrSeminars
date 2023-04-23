// Задача 66: 
// 1.Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма значений в промежутке от {m} до {n} = {SumNuturalElements(m, n)}");
// Console.WriteLine();
// Console.Write($"Сумма значений в промежутке от {m} до {n} = {SumNuturalElem(m, n)}");

int SumNuturalElements(int num1, int num2)
{
  int x = num1;
  int y = num2;
  if (num1 > num2)
  {
    x = num2;
    y = num1;
  }
  return (num2 + num1) * (num2 - num1 + 1) / 2;
}

// int SumNuturalElem(int num1, int num2)
// {
//   if (num1 == num2)
//     return num2;
//   else return num1 + SumNuturalElem(num1 + 1, num2);
// }