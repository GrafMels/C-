// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите три числа, а я скажу какое больше");

Console.Write("Введите Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
int indexMax = 1;

if(secondNumber > firstNumber){
    max = secondNumber;
    indexMax = 2;
}if(thirdNumber > secondNumber){
    max = thirdNumber;
    indexMax = 3;
}

Console.WriteLine(indexMax + "-е чило больше всех и равно: " + max);