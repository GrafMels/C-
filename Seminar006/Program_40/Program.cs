// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа обозначающие три стороны треугольника:");

Console.Write("1: ");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.Write("2: ");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.Write("3: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if (firstSide > (secondSide + thirdSide) || secondSide > (firstSide + thirdSide) || thirdSide > (firstSide + secondSide)) Console.WriteLine("Треугольник с таким соотношение сторон существовать не может");
else Console.WriteLine("Подходящие стороны для треугольника");
