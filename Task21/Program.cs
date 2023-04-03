// Задача 21. Напишите программу, которая
// принимает на вход координаты даух точек и
// находит расстояние между ними в 3D пространстве.
// А (3,6,8); В (2,1,-7) -> 15.84;
// A (7,-5,0); B (1,-1,9) -> 11.53;

Console.Clear();
Console.Write("Введите координату x первой точки: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z третьей точки: ");
double xC = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z третьей точки: ");
double yC = Convert.ToDouble(Console.ReadLine());

double result = Distance(xA, yA, xB, yB, xC, yC);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между данными точками в 3D пространстве = {resultRound}");


double Distance(double x1, double y1, double x2, double y2, double z1, double z2)
{
  double x = x2 - x1;
  double y = y2 - y1;
  double z = z2 - z1;
  double distance = Math.Sqrt(x * x + y * y + z * z);
  return distance;
}