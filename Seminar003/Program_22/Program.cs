// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Все квадраты с 1 включая это число: ");
for(int i = 1 ; i < Number ; i++)
{
   Console.Write($"{Math.Pow(i, 2)}, "); 
}
   Console.Write($"{Math.Pow(Number, 2)}."); 