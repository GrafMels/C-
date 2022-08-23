// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int counter = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 101);

    if ((array[i] > 9) && (array[i] < 100)) counter++;


    Console.Write($"{array[i]} ,");
}

Console.WriteLine();
Console.WriteLine($"Колличество чисел от 9 до 100: {counter}");

