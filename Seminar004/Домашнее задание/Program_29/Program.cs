// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Напишите через Enter, 8 чисел: ");
int[] array = new int [8];
for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"Результат: [ {String.Join(", ", array)} ]");