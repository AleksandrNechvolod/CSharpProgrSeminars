// Задача 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



Console.Write("Введите первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Решение условным оператором
//////////////////////////////////////////////////
// int result = number1 % number2;
// if (result == 0)
// {
//   Console.WriteLine("Кратное");
// }
// else
// {
//   Console.WriteLine("Не кратное");
//   Console.Write($"остаток от деления -> ");
//   Console.WriteLine(result);
// }


// Решение 2 через метод
/////////////////////////////////////////////////
int ReminderDivision(int num1, int num2)
{
  int res = num1 % num2;
  return res;
}

int result = ReminderDivision(number1,number2);
if (result==0) Console.WriteLine("Кратное");
else Console.WriteLine($"Не кратное. Остаток от деления -> {result}");


