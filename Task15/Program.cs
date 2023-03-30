// Задача 15: Напишите программу, которая
//  принимает на вход цифру, обозначающую день недели, и 
//  проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

///Решение через условного оператора

// Console.Write("Введите цифру дня недели: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// if (dayNumDigit >= 1 && dayNumDigit <= 7)
// {
//   if (dayNumDigit == 6 || dayNumDigit == 7)
//   {
//     Console.WriteLine("Этот день недели является выходным!");
//   }
//   else
//   {
//     Console.WriteLine("Этот день недели не является выходным.");
//   }

// }
// else
// {
//   Console.WriteLine("Не бывает такой цифры дня недели.");
// }

///Решение через метод

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
WeekDay(dayNumber);

void WeekDay(int dayNum) 
{
  if (dayNum == 6 || dayNum == 7) 
  Console.WriteLine("Этот день недели является выходным!");
  
  else if (dayNum < 1 || dayNum > 7) 
    Console.WriteLine("Не бывает такой цифры дня недели.");
  
  else Console.WriteLine("Этот день недели не является выходным.");
}

