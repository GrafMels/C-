// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет
// на первом месте, а первый на последнем и т.д.)\
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] flippedOverArray = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]}\t");
}

Console.WriteLine();

//1 способ: поэлементно скопировать в новый массив

for (int i = 0; i < size; i++)
{
    flippedOverArray[i] = array[size - 1 - i];
    Console.Write($"{flippedOverArray[i]}\t");
}
