// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите зеркальное пятизначное число (число палиндром): ");
string? Number = Console.ReadLine();
if(Number?.Length < 5 || Number?.Length > 5)
{
    Console.WriteLine("Не пятизначное");
    return;
}

if (Number?[0] != Number?[4])
{
    Console.WriteLine("Не палиндром");
    return;
}

if (Number?[1] != Number?[3])
{
    Console.WriteLine("Не палиндром");
    return;
}
Console.WriteLine("Палиндром");