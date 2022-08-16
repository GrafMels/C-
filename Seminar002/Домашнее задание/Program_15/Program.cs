// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели а я скажу выходной он или нет: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfTheWeek < 1 || dayOfTheWeek > 7) Console.WriteLine("Такого дня недели не существует");
if (dayOfTheWeek == 1 || dayOfTheWeek == 2 || dayOfTheWeek == 3 || dayOfTheWeek == 4 || dayOfTheWeek == 5) Console.WriteLine("Это НЕ выходной");
if (dayOfTheWeek == 6 || dayOfTheWeek == 7) Console.WriteLine("Это ВЫХОДНОЙ! УРА!");