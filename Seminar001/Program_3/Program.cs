// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите номер дня недели");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
if(dayOfTheWeek == 1)
{
    Console.WriteLine("1 - Понедельник");
}
if(dayOfTheWeek == 2)
{
    Console.WriteLine("2 - Вторник");
}
if(dayOfTheWeek == 3)
{
    Console.WriteLine("3 - Среда");
}
if(dayOfTheWeek == 4)
{
    Console.WriteLine("4 - Четверг");
}
if(dayOfTheWeek == 5)
{
    Console.WriteLine("5 - Пятница");
}
if(dayOfTheWeek == 6)
{
    Console.WriteLine("6 - Суббота");
}
if(dayOfTheWeek == 7)
{
    Console.WriteLine("7 - Воскресенье");
}
else
{
    Console.Write("Такого дня недели не бывает");
}
