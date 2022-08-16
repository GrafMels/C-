// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число, а я скажу чётное оно или нет:");
int number = Convert.ToInt32(Console.ReadLine());
int signed = number % 2;
if(signed == 0)
{
    Console.WriteLine("Чётное");
}
if(signed == 1)
{
    Console.WriteLine("Нечётное");
}
else
{
    Console.WriteLine("Это вообще ноль");
}