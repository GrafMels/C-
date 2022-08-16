// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите его степень:");
int degree = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int number, int degree)
{
    int numberToThePower = 0;
    numberToThePower = number * number;
    for (int i = 2; i < degree; i++)
    {
        numberToThePower = numberToThePower * number;
    }
    return numberToThePower;
}
Console.WriteLine($"Ответ: {Exponentiation(number, degree)}");