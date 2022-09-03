// Задача 59: Задайте двумерный массив из целлых чисел.
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент массива

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

int FindMin(int[,] matrix, int rows, int columns)
{
    int min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
        }
    }
    return min;
}

void PrintArrayAndDeleteRowAndColumn(int[,] matrix, int m, int n, int min)
{
    Console.WriteLine("\n\n");
    if (min == -11567)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    else
    {
        int iMin = 0;
        int jMin = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (min == matrix[i, j])
                {
                    iMin = i;
                    jMin = j;
                    goto firstMinFound;
                }
            }
        }
    firstMinFound:
    Console.WriteLine($"Min = {min}[{iMin}, {jMin}]");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != iMin
                && j != jMin) Console.Write($"{matrix[i, j]}\t");
            }
            if (i != iMin) Console.WriteLine();
        }
    }
}

int[,] Array = MakeRandArray(rows, columns);
PrintArrayAndDeleteRowAndColumn(Array, rows, columns, -11567);// число -11567 это костыль
int min = FindMin(Array, rows, columns);
PrintArrayAndDeleteRowAndColumn(Array, rows, columns, min);


