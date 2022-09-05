// Задача 62: Заполните спиралью массив 4 на 4.

Console.Clear();
Console.WriteLine("Колличество строк должно быть равно колличеству столбцов: ");
Console.Write("Введите колличество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());


int[,] MakeRandArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    // matrix[i, j] = count;
    for (int j = 0; j < (rows+columns)/2; j++)
    {

        for (int i = j; i < columns - j; i++)
        {
            matrix[j, i] = count;
            count++;
        }
        for (int i = j + 1; i < rows-j; i++)
        {
            matrix[i, columns - (j+1)] = count;
            count++;
        }
        for (int i = columns - (j+2); i > j; i--)
        {
            matrix[rows - (j+1), i] = count;
            count++;
        }
        for (int i = rows - (j+1); i > j; i--)
        {
            matrix[i, j] = count;
            count++;
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

int[,] firstArray = MakeRandArray(rows, columns);
PrintArray(firstArray, rows, columns);







