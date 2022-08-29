// Задача 51. Найти сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива двумерного
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

// Печать массива

void PrintArray(int[,] inputMatrix)
{
    Console.WriteLine("\n\n");
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sumDiagonal = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j) sumDiagonal += matrix[i, j];
        }
    }
    return sumDiagonal;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine($"Сумма главной диагонали: {SumMainDiagonal(resultMatrix)}");

