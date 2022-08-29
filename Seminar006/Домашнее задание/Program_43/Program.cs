// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// b1 = 5, k1 = 2, b2 = 9, k2 = 4 -> (-2; 1)
//ввод переменых через консоль и вывод информации о программе
Console.WriteLine("Программа решает систему уравнений или по простому находит точку пересечения прямых: ");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine($"y = k2 * x + b2 \n");

Console.Write("Введите значение k1: ");
double multipliedByX1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double summedByX1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double multipliedByX2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double summedByX2 = Convert.ToInt32(Console.ReadLine());

// вычисление и вывод
double xIntersections = -(summedByX1 - summedByX2) / (multipliedByX1 - multipliedByX2);
double yIntersections = (multipliedByX1 * xIntersections) + summedByX1;
Console.WriteLine($"\nТочка пересечения прямых [{xIntersections}, {yIntersections}]");
