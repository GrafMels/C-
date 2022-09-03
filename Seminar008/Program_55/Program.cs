// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это не 
// возможно, программа должна вывести сообщение для 
// пользователя.

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

void TurnOverArray(int[,] matrix, int m, int n)// можно войд
{
    for (int j = 0; j < m; j++)
    {
        for (int i = j; i < n; i++)
        {
            int row = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = row;
        }
    }
}

int[,] MakeTurnOverArray(int[,] oldMatrix, int m, int n)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[j, i] = oldMatrix[i, j];
        }
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

if (rows == columns)
{
    TurnOverArray(Array, rows, columns);
    PrintArray(Array, rows, columns);
}
else
{
    int[,] turnOverArray = MakeTurnOverArray(Array, rows, columns);
    PrintArray(turnOverArray, columns, rows);//интересный момент нужно написать строки и столбцы наоборот потому что массив у нас на боку: {Ленивый массив}
}

