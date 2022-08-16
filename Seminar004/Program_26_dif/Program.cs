// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
System.Console.Write("Введите число: ");
long number = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers(long num)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.WriteLine($"Колличество цифр в числе {number}: {GetCountNumbers(number)}");

