// Задача 68: 
// 1. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintAccFunction(m, n);
// Console.WriteLine($"A(m,n) = {AccermanFunction(m, n)}");

void PrintAccFunction
(int m, int n)
{
  Console.Write($"A(m,n) = {AccermanFunction(m, n)}");
}

int AccermanFunction(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (m > 0 && n == 0)
  {
    return AccermanFunction(m - 1, 1);
  }
  else
  {
    return (AccermanFunction(m - 1, AccermanFunction(m, n - 1)));
  }
}