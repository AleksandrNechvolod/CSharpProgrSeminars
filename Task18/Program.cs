// Задача 18: Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек
//  в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти -> ");

// Первый вариант решения (через числа)

// int quarterNumber = Convert.ToInt32(Console.ReadLine());

// string result = Coordinates(quarterNumber);
// Console.WriteLine(result);

// string Coordinates(int quarterNum)
// {
//   if (quarterNum == 1) return "x > 0, y > 0";
//   if (quarterNum == 2) return "x < 0, y > 0";
//   if (quarterNum == 3) return "x < 0, y < 0";
//   if (quarterNum == 4) return "x > 0, y < 0";
//   return "Введен некорректный номер четверти";
// }

//Второй, более оптимальный вариант решения!


string quarterNumber = Console.ReadLine();

string result = Coordinates(quarterNumber);
Console.WriteLine(result);

string Coordinates(string quarterNum)
{
  if (quarterNum == "1") return "x > 0, y > 0";
  if (quarterNum == "2") return "x < 0, y > 0";
  if (quarterNum == "3") return "x < 0, y < 0";
  if (quarterNum == "4") return "x > 0, y < 0";
  return "Введен некорректный номер четверти";
}

