// Задача 57: Составить частотный словарь элементов двумерного 
// массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

Console.Clear();

Console.WriteLine("Введите максимальное диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MakeRandArray(int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void FindCountAndPrint(int[,] matrix, int rows, int columns, int max, int min)
{   
    Console.WriteLine();
    for (int i = 0; i < max - min; i++)
    {
        int count = 0;
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (matrix[j, k] == min + i) count++;
            } 
        }
        Console.WriteLine($"{min+i}: встречается {count} раз");
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

int[,] Array = MakeRandArray(rows, columns, max, min);
PrintArray(Array, rows, columns);
FindCountAndPrint(Array, rows, columns, max, min);

