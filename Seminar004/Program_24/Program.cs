Console.Write("Введите число а я покажу сумму всех чисел больше нуля до него: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int GetSumNumbers (int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine($"сумма чисел от 1 до {numberA} = {GetSumNumbers(numberA)}");

// int number = Convert.ToInt32(Console.ReadLine());
// // PascalCase 
// // type Name (params)
// int GetSumNumbers(int num) // PascalCase 
// {
//     int start = 1; // [1;A]
//     int sum = 0; // Суммы еще нет - значение 0
//     while (start <= num)
//     {
//         sum += start;
//         // sum = sum + start
//         // sum *= start => sum = sum * start
//         start++; // start = start + 1
//     }
//     return sum;
// }
// int testNumber = 0; // camelCase

// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetSumNumbers(number)}");
