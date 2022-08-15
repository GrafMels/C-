//  17. Напишите программу, которая принимает на
//  вход координаты точки (X и Y), причём Х ≠ 0 и
//  Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка

Console.Write("Введите значение кординаты оси x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение кординаты оси y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Это I четверть");
if (x < 0 && y > 0) Console.WriteLine("Это II четверть");
if (x < 0 && y < 0) Console.WriteLine("Это III четверть");
if (x > 0 && y < 0) Console.WriteLine("Это IV четверть");