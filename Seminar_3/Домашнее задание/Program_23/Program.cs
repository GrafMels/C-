﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Все квадраты с 1 включая это число: \t");
for(int i = 1 ; i < Number ; i++)
{
   Console.Write($"{Math.Pow(i, 3)},\t"); 
}
   Console.Write($"{Math.Pow(Number, 3)}."); 
