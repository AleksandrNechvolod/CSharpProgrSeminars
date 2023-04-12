// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
InputNumbers(m);
Console.Write($"Чисел больше нуля введено: {PositiveNumbers(array)}.");

void InputNumbers(int count)
{
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int PositiveNumbers(int[] arr)
{
  int i = 0;
  int sum = 0;
  while (i < arr.Length)
  {
    if (arr[i] > 0)
    sum = sum + 1;
    i = i + 1;
  }
  return sum;
}

