// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите достаточно длинное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitsInNumber (int number1)
{
    int count = number1;
    int numberSize = 0;
    while (count > 0)
    {
        count /= 10;
        numberSize++;
    }
    int result = 0;
    for (int i = 0; i < numberSize; i++)
    {
        result += (number1 % 10);
        number1 /= 10;
    }
    return result;
}
Console.WriteLine(SumDigitsInNumber(number));
