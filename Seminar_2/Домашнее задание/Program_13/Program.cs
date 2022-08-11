// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next(1, 10000);
string numberStrg = Convert.ToString(number);
if(number > 99) Console.WriteLine($"К числу {numberStrg}, ответ: {numberStrg[2]}");
if(number < 99) Console.WriteLine($"К числу {numberStrg}, третьей цифры нет");
