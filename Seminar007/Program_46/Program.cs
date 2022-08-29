// Задача 46: Задайте двумерный масиив размером mxn, заполненый случайными числами.
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2 
// 77 3 8 1

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

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
// Печать массива

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}