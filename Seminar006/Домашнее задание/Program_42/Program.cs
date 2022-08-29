// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
System.Console.Write("Введите десятичное число а я сделаю из него двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());

int size = 0;

// Условия для размера массивов
if (number > 10000) size = 1000;
else if (number > 1000) size = 15;
else if (number > 100) size = 10;
else if (number > 50) size = 7;
else size = 6;

//Инициализация бинарного массива
int[] binary = new int[size];
int equal = 0;

//Вычисляем бинарный массив
binary[0] = number % 2;
Console.WriteLine($"1: {number}; {binary[0]}");

for (int i = 1; i < size; i++)
{
    number = number / 2;
    binary[i] = number % 2;
    if (number == 0) break;
    Console.WriteLine($"{i + 1}: {number}; {binary[i]}");
    equal = i;
    
}

//Выводим бинарный массив
Console.WriteLine();
Console.Write("Binary: ");
int reverseRoom = size - (size - equal) + 1;

for (int i = 1; i < equal + 2; i++)
{
    Console.Write($"{binary[reverseRoom - i]}");
}