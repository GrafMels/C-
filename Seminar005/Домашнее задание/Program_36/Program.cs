// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]}, ");
}

Console.WriteLine();

for (int i = 1; i < size; i = i + 2)
{
    sum += array[i];
    if (i < (size - 2)) Console.Write($"{array[i]} + ");
    else Console.Write($"{array[i]} = {sum}");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма чисел стоящих на нечётных индексах: {sum}");
