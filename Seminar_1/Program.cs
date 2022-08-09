// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Write("Введите число которое надо возвести в квадрат:");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Квадрат этого числа:");
Console.WriteLine(first_number*first_number);
//Или второй вариант решение через подключение библиотеки Math
double sqrNumber = Math.Pow(first_number, 2);
Console.WriteLine("Квадрат этого числа " + first_number + " = " + sqrNumber);



