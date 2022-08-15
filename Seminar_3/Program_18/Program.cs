// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.WriteLine("Введите номер четверти на оси кординат от 1 до 4: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());
if (quarterNumber < 1 || quarterNumber > 4){
Console.WriteLine("Ошибка");
}
else{
if (quarterNumber == 1) Console.WriteLine("x > 0, y > 0");
if (quarterNumber == 2) Console.WriteLine("x < 0, y > 0");
if (quarterNumber == 3) Console.WriteLine("x < 0, y < 0");
if (quarterNumber == 4) Console.WriteLine("x > 0, y < 0");
}