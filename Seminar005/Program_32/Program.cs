// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string?[] array = { };
Array.Resize(ref array, array.Length + size);//Это я присваиваю массиву длину
Console.WriteLine("Введите массив:");
for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
}

for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToString(-Convert.ToInt32(array[i]));
    System.Console.Write($"{array[i]} ,");
}

