// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("Введите два числа что-бы первое было квадратом второго");

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber == secondNumber * secondNumber){
    Console.WriteLine("ДА: Первое число: " + firstNumber + " является квадратом Второго числа: " + secondNumber);
    Console.WriteLine("Ты молодец");
}else{
    Console.WriteLine("НЕТ: Первое число: " + firstNumber + " НЕ является квадратом Второго числа: " + secondNumber);
    Console.WriteLine("Ты не молодец");
}



