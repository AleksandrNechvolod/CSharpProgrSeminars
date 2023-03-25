// Задача 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// if (dayNum == 1)
// {
//   Console.WriteLine($" {dayNum} является понедельником");
// }
// if (dayNum == 2)
// {
//   Console.WriteLine($" {dayNum} является вторником");
// }
// if (dayNum == 3)
// {
//   Console.WriteLine($" {dayNum} является средой");
// }
// if (dayNum == 4)
// {
//   Console.WriteLine($" {dayNum} является четвергом");
// }
// if (dayNum == 5)
// {
//   Console.WriteLine($" {dayNum} является пятницей");
// }
// if (dayNum == 6)
// {
//   Console.WriteLine($" {dayNum} является оубботой");
// }
// if (dayNum == 7)
// {
//   Console.WriteLine($" {dayNum} является воскресеньем");
// }

// if (dayNum > 7)
// {
//   Console.WriteLine($" {dayNum} не является днём недели.ВНИМАТЕЛЬНО!");
// }
// if (dayNum < 1)
// {
//   Console.WriteLine($" {dayNum} не является днём недели.ВНИМАТЕЛЬНО!");
// }


Console.WriteLine("Введите номер дня недели");
string day = Console.ReadLine();

if (day == "1")
{
  Console.WriteLine("Это понедельник");
}
else if (day == "2")
{
  Console.WriteLine("Это вторник");
}
else if (day == "3")
{
  Console.WriteLine("Это среда");
}
else if (day == "4")
{
  Console.WriteLine("Это четверг");
}
else if (day == "5")
{
  Console.WriteLine("Это пятница");
}
else if (day == "6")
{
  Console.WriteLine("Это суббота");
}
else if (day == "7")
{
  Console.WriteLine("Это воскресенье");
}

else
{
  Console.WriteLine("Такого дня недели НЕ СУЩЕСТВУЕТ!!!");
}

