// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int number = Convert.ToInt32(Console.ReadLine());
int size = 0;
if (number > 1000) size = 15;
else if (number > 100) size = 10;
else if (number > 50) size = 7;
else size = 6;

int[] remainder = new int[size];
int[] binary = new int[size];
int equal = 0;

remainder[0] = number;
binary[0] = number % 2;
Console.WriteLine($"1: {remainder[0]}; {binary[0]}");

for (int i = 1; i < size; i++)
{
    remainder[i] = remainder[i - 1] / 2;
    binary[i] = remainder[i] % 2;
    if (remainder[i] == 0) break;
    Console.WriteLine($"{i + 1}: {remainder[i]}; {binary[i]}");
    equal = i;
}

Console.WriteLine();
Console.Write("Binary: ");

for (int i = 1; i < equal + 2; i++)
{
    Console.Write($"{binary[size - (size - equal) - i + 1]}");
}