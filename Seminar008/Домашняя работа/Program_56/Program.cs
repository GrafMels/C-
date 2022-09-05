// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку 
// с наименьшей суммой элементов

Console.Clear();

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minRand = 1;
int maxRand = 10;
int[,] MakeRandArray(int rows, int columns, int minRand, int maxRand)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);
        }
    }
    return matrix;
}

void PrintArrayAndGetSum(int[,] matrix, int m, int n, int maxRand)
{
    Console.WriteLine("\n\n");

    int rowMinSum = maxRand * m;
    int rowMinSumIndex = 0;
    for (int i = 0; i < m; i++)
    {
        int[] sum = new int[m];
        for (int j = 0; j < n; j++)
        {
            sum[i] += matrix[i, j];
            Console.Write($"{matrix[i, j]}\t");
        }
        if (rowMinSum > sum[i])
        {
            rowMinSum = sum[i];
            rowMinSumIndex = i;
        }
        Console.WriteLine($"[{sum[i]}]");
    }
    Console.WriteLine($"\nМинимальная сумма {rowMinSum} в строке с индексом {rowMinSumIndex}");
}

int[,] array = MakeRandArray(rows, columns, minRand, maxRand);
PrintArrayAndGetSum(array, rows, columns, maxRand);

