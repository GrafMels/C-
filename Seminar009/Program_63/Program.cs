// Факториал
// Console.Write("Введи число а я выдам факториал: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Factorial(int number)
// {
//     // Рекурсия имеет два случая 
//     // Базовый случай когда мы  выходим из рекурсии
//     // Рекурсивный случай
//     if (number == 1) return 1;
//     return (number * Factorial(number - 1));
// }
// Console.WriteLine($"Факториал от числа {number} = {Factorial(number)}"); 

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int N = Convert.ToInt32(Console.ReadLine());
if (1 > N) return;
string PrintNumber(int start, int end)
{
    //Базовый случай

    if (start == end) return start.ToString();

    //Рекурсивный случай

    return (start + ", " + PrintNumber(start + 1, end));
}

Console.WriteLine($"Числа от 1 до {N}: '{PrintNumber(1, N)}'");