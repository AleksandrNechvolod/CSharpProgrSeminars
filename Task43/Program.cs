// Задача 43: 
// 1. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double XCoordinate(double b1point, double k1point, double b2point, double k2point)
{
  double x = (b1point - b2point) / (k2point - k1point);
  return x;
}

double YCoordinate(double b1point, double k1point, double b2point, double k2point)
{
  double y = k1point * ((b2point - b1point) / (k1point - k2point)) + b1point;

  return y;
}

Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double xcoord = XCoordinate(b1, k1, b2, k2);
double ycoord = YCoordinate(b1, k1, b2, k2);
xcoord = Math.Round(xcoord, 1);
ycoord = Math.Round(ycoord, 1);
Console.WriteLine($"Точка пересечения двух прямых: координата X -> {xcoord}, координата Y -> {ycoord}.");
