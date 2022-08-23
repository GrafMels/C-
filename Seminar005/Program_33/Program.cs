// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите искомое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] indexArray = new int[size];
int j = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 101);

    if (array[i] == number)
    {
        indexArray[j] = i;
        j++;
    }

    Console.Write($"{array[i]} ,");
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < j; i++)
{
    Console.WriteLine($"{i + 1}-e число которое совпадает имеет индекс: {indexArray[i]}");
}

