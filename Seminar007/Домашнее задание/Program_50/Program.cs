// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MakeRandArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = MakeRandArray(rows, columns);
PrintArray(array);

Console.WriteLine("Введите индекс строки искомого числа: ");
int indexRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца искомого числа: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());
if(indexRows > rows || indexColumns > columns || indexRows < 0 || indexColumns < 0) System.Console.WriteLine($"Элемента в {indexRows}-ой строке и {indexColumns}-ом столбце не существует");
else Console.WriteLine($"Элемент в {indexRows}-ой строке и {indexColumns}-ом столбце: {array[indexRows,indexColumns]}");

