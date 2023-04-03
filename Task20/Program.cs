// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//  ТАКЖЕ МОЖНО РЕШАТЬ С ВВОДНЫМИ АРГУМЕНТАМИ int!!!!
Console.Clear();
Console.WriteLine("Введите координату x первой точки:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:");
double yB = Convert.ToDouble(Console.ReadLine());

double result = Distance(xA, yA, xB, yB);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между данными точками = {resultRound}");


double Distance(double x1, double y1, double x2, double y2)
{
  double x = x1 - x2;
  double y = y1 - y2;
  double distance = Math.Sqrt(x * x + y * y);
  return distance;
}

// double d = Math.Sqrt(5);
// double res = 5.0999564;
// double resRound = Math.Round(res, 2, MidpodoubleRounding.ToZero);
// Console.WriteLine(resRound);