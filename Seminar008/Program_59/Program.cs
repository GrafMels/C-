// Задача 59: Задайте двумерный массив из целлых чисел.
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент массива

Console.Clear();

int rows = 10;
int columns = 10;
int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int minElementRow = 0; // Строчка с минимальным элементом
int minElementColumn = 0;// Столбец с минимальным элементом
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
{
    for (int j = 0; j < columns; j++) // matrix.GetLength(1) = columns
    {
        matrix[i, j] = new Random().Next(10); // [0;10]
        Console.Write(matrix[i, j] + "\t"); // Tab
        if (minElement > matrix[i, j]) // 5 > 0 , min = 0
        {
            minElement = matrix[i, j];
            minElementRow = i;
            minElementColumn = j;
        }
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Min = {minElement}, row: {minElementRow}, column: {minElementColumn} ");
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (minElementRow != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minElementColumn != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
    }
    Console.WriteLine();
}