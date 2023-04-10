// Задача 38.
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и
// минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
  double[] arr = new double[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    double num = rnd.NextDouble() * (max - min) + min;
    arr[i] = Math.Round(num, 1);
  }
  return arr;
}

void PrintArray(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}. ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write("]");
}

double MaxValue(double[] arr)
{
  double max = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max)
      max = arr[i];
  }
  return max;
}

double MinValue(double[] arr)
{
  double min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min)
      min = arr[i];
  }
  return min;
}

double Difference(double max, double min)
{
  double difference = max - min;
  return difference;
}

Console.Clear();
double[] array = CreateArrayRndDouble(5, 0, 50);
PrintArray(array);
Console.WriteLine();
double maxValue = MaxValue(array);
Console.WriteLine();
Console.WriteLine($"Максимальное значение массива -> {maxValue}");
double minValue = MinValue(array);
Console.WriteLine();
Console.WriteLine($"Минимальное значение массива -> {minValue}");
double result = Difference(maxValue, minValue);
result = Math.Round(result, 1);
Console.WriteLine();
Console.WriteLine($"Разница между макс. и мин. значениями массива = {result}");
