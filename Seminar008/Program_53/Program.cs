// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
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

int[,] ChangeLastFirstRows(int[,] matrix, int m, int n)
{
    int row = 0;
    for (int i = 0; i <= n - 1; i++)
    {
        row = matrix[0, i];
        matrix[0, i] = matrix[m - 1, i];
        matrix[m - 1, i] = row;
    }
    return matrix;
}

void PrintArray(int[,] matrix, int m, int n)
{
    Console.WriteLine("\n\n");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Array = MakeRandArray(rows, columns);
PrintArray(Array, rows, columns);
ChangeLastFirstRows(Array, rows, columns);
PrintArray(Array, rows, columns);

