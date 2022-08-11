// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Write("Введите число, а я вам скажу какая у него третья цифра: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberStrg = Convert.ToString(number);
if(number > 99) Console.WriteLine($"К числу {numberStrg}, ответ: {numberStrg[2]}");
if(number < 99) Console.WriteLine($"К числу {numberStrg}, третьей цифры нет");
