// Задача 58: 
// 1. Задайте две матрицы. 
// 2. Напишите программу, которая 
// будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Console.Clear();
int[,] createMatrix1 = CreateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(createMatrix1);
Console.WriteLine();
int[,] createMatrix2 = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(createMatrix2);
int[,] multMatrix = MatrixMultiplication(createMatrix1, createMatrix2);
Console.WriteLine();
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(multMatrix);

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
  int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
  if (matrixA.GetLength(1) != matrixB.GetLength(0))
  {
    Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
  }

  else
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
      for (int j = 0; j < matrixB.GetLength(1); j++)
      {
        matrixC[i, j] = 0;

        for (var k = 0; k < matrixA.GetLength(1); k++)
        {
          matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
      }
    }

  return matrixC;
}