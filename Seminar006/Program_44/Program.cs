Console.Write("Сколько чисел Фибаначчи вам вывести: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
array[0] = 0;
Console.WriteLine();
Console.Write($"{array[0]}\t\t");
array[1] = 1;
Console.Write($"{array[1]}\t\t");

for (int i = 2; i < size; i++)
{
    array[i] = array[i - 1] + array[i - 2];
    if ((i+1) % 5 == 0) Console.WriteLine($"{array[i]}\t\t");
    else Console.Write($"{array[i]}\t\t");
}
