// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int counter = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);

    if (i < (size - 1)) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}.");

    if (array[i] % 2 == 0) counter++;
}


Console.WriteLine();
Console.WriteLine($"Колличество чётных чисел: {counter}");

