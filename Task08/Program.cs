// Задача 8. Напишите программу, которая
// на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
int count1 = 1;


if (number < count1)
{
  Console.Write($"Это не положительное число, введите положительное!");
  Console.WriteLine();
}
else if (number == count1)
{
  Console.Write($"Это положительное число не имеет четного ряда!");
}

while (count <= number)
{
  Console.Write($"{count} ");
  count += 2;
}

