Console.Write("Сколько чисел вы хотите ввести: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arraySize];
int counter = 0;
for (int i = 0; i < arraySize; i++)
{
    Console.Write($"{i + 1}: Введите число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0) counter++;
}

Console.WriteLine($"\n[{String.Join(", ", numbers)}]");
Console.WriteLine($"Колличество чисел больше нуля: {counter}");
