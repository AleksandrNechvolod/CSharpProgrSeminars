// Задача 22: Напишите программу, которая
// принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите натуральное число -> ");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);


void TableSquare(int number)
{
  for (int i = 1; i <= number; i++)
  {
    int square = i * i;
    Console.WriteLine($"{i, 3} -> {square, 5}");
  }

}

// Вариант решения через while
// void TableSquare(int number)
// {
//    int i = 1;
//   while (i <= number)
//   {
//     int square = i * i;
//     Console.WriteLine($"{i, 3} -> {square, 5}");
//     i++;
//   }
// }