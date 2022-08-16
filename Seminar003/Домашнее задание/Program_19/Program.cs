// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите зеркальное пятизначное число (число палиндром): ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99999 || Number < 10000)
{
    Console.WriteLine("Не пятизначное");
    return;
}

if (Number / 10000 != Number % 10)
{
    Console.WriteLine("Не палиндром");
    return;
}

if ((Number % 10000) / 1000 != (Number % 100)/10)
{
    Console.WriteLine("Не палиндром");
    return;
}
Console.WriteLine("Палиндром");