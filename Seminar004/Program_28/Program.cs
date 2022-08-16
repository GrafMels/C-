// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.Write("Введите переменную: ");
int number = Convert.ToInt32(Console.ReadLine());

long FindFactorial(int num)
{
    long temp = 1;
    for (int i = 1; i <= num; i++)
    {
        temp *= i;
    }
    return temp;
}

Console.WriteLine(FindFactorial(number));
