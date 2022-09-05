// Задача 58: Задайте две матрицы. Напишите программу которая
// будет находить произведение(//сумму) двух матриц.

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

void PrintArray(int[,] matrix, int rows, int columns)
{
    Console.WriteLine("\n\n");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// int[,] SumArray(int[,] firstMatrix, int[,] secondMatrix, int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
//         }
//     }
//     return matrix;
// }

int[,] MulArray(int[,] firstMatrix, int[,] secondMatrix, int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int mulRow = 0;
            for (int k = 0; k < columns; k++)
            {
                mulRow += firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrix[i,j] = mulRow;
        }

    }
    return matrix;
}

int[,] firstArray = MakeRandArray(rows, columns, minRand, maxRand);
PrintArray(firstArray, rows, columns);

int[,] secondArray = MakeRandArray(rows, columns, minRand, maxRand);
PrintArray(secondArray, rows, columns);

int[,] mulArray = MulArray(firstArray, secondArray, rows, columns);
PrintArray(mulArray, rows, columns);




