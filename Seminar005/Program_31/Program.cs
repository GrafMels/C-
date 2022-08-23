// Задача 31: Задайте массив из 12 элементов случайных чисел от -9 до 9 и найти сумму отрицательных и положительных

int[] array = new int[12];

int resultNegative = 0;
int resultPositive = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] < 0) resultNegative += array[i];
    else resultPositive += array[i];
}

Console.WriteLine($"[ {String.Join(", ", array)} ]");
System.Console.WriteLine(resultNegative);
System.Console.WriteLine(resultPositive);