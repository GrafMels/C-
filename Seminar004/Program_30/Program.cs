// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);
        Console.Write($"{result[i]}\t");
    }
    return result;
}
int[] array = GetBinaryArray(8);
Console.WriteLine(array);
Console.WriteLine($"Результат: [ {String.Join(", ", array)} ]");


