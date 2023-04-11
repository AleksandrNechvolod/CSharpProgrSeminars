// Задача 40:
//  Напишите программу, которая 
//  1. принимает на вход три числа и 
//  2. проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsExistTriangle(int n1, int n2, int n3)
{
  return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2;
}

Console.Clear();
Console.Write("Введите первую сторону треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());
bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Существет" : "Не существует");