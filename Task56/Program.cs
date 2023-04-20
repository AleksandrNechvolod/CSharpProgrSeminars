// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }

  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("|");
  }
}

int SumElementsRows(int[,] array, int i)
{
  int sum = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i, j];
  }
  return sum;
}

Console.Clear();
int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
int sumRow = SumElementsRows(array2d, 0);

int minSum = 1;
for (int i = 1; i < array2d.GetLength(0); i++)
{
  if (sumRow > SumElementsRows(array2d, i))
  {
    sumRow = SumElementsRows(array2d, i);
    minSum = i + 1;
  }
}
Console.WriteLine();
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");


