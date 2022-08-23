// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double min = new Random().NextDouble() * 1000;
double max = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 10;
    Console.Write($"{array[i]}\t");
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {Math.Round(max - min, 4)}");