// Задача 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 1)
{
  Console.WriteLine($" {dayNum} является понедельником");
}
if (dayNum == 2)
{
  Console.WriteLine($" {dayNum} является вторником");
}
if (dayNum == 3)
{
  Console.WriteLine($" {dayNum} является средой");
}
if (dayNum == 4)
{
  Console.WriteLine($" {dayNum} является четвергом");
}
if (dayNum == 5)
{
  Console.WriteLine($" {dayNum} является пятницей");
}
if (dayNum == 6)
{
  Console.WriteLine($" {dayNum} является оубботой");
}
if (dayNum == 7)
{
  Console.WriteLine($" {dayNum} является воскресеньем");
}

if (dayNum > 7)
{
  Console.WriteLine($" {dayNum} не является днём недели.ВНИМАТЕЛЬНО!");
}
if (dayNum < 1)
{
  Console.WriteLine($" {dayNum} не является днём недели.ВНИМАТЕЛЬНО!");
}
