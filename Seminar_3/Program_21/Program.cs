// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите две точки на оси координат, а я найду между ними расттояние.");

Console.Write("Введите x точки A: ");
int Xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки A: ");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x точки B: ");
int Xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки B: ");
int Yb = Convert.ToInt32(Console.ReadLine());

// очень сложная строчка для того чтобы не вводить 
// лишние переменные, по факту считает AB = √(xb - xa)2 + (yb - ya)2
System.Console.WriteLine($"Растояние между точками A и B: {Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2))}");