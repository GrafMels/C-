// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ,");
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    array[i] = -array[i];
    Console.Write($"{array[i]} ,");
}

