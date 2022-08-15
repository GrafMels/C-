//  17. Напишите программу, которая принимает на
//  вход координаты точки (X и Y), причём Х ≠ 0 и
//  Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка

Console.Write("Введите значение кординаты оси x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение кординаты оси y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Это первая четверть");
if (x < 0 && y > 0) Console.WriteLine("Это вторая четверть");
if (x < 0 && y < 0) Console.WriteLine("Это третья четверть");
if (x > 0 && y < 0) Console.WriteLine("Это четвёртая четверть");