// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) return;
string PrintNumber(int start, int end)
{
    //Базовый случай

    if (start == end) return start.ToString();

    //Рекурсивный случай

    return (start + ", " + PrintNumber(start + 1, end));
}

Console.WriteLine($"Числа от {M} до {N}: '{PrintNumber(M, N)}'");
