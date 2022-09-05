// Задача 54: Задайте двумернный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.


Console.Clear();

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MakeRandArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void SortingByLinesArray(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int max = matrix[i, j];//находим максимальное в строке и переносим на j
            int kMax = j;
            for (int k = j; k < columns; k++)
            {
                if (max < matrix[i, k])
                {
                    max = matrix[i, k];
                    kMax = k;
                }
            }
            matrix[i, kMax] = matrix[i, j];
            matrix[i, j] = max;
        }
    }
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

int[,] array = MakeRandArray(rows, columns);
PrintArray(array, rows, columns);
SortingByLinesArray(array, rows, columns);
PrintArray(array, rows, columns);











