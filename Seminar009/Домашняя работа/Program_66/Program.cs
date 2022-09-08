// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) return;
int SumNumber(int start, int end)
{
    //Базовый случай

    if (start == end) return start;

    //Рекурсивный случай

    return (start + SumNumber(start + 1, end));
}

Console.WriteLine($"Сумма чисел от {M} до {N}: {SumNumber(M, N)}");