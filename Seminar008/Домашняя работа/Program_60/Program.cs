// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет 
// построчно ввыводить массив, добавляя индексы каждого 
// элемента

Console.Clear();

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество глубины: ");
int depth = Convert.ToInt32(Console.ReadLine());



int[,,] MakeRandArray(int depth, int rows, int columns)
{
    int[,,] matrix = new int[depth, rows, columns];
    int count = 10;

    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;

}

void PrintArray(int[,,] matrix, int depth, int rows, int columns)
{
    Console.WriteLine("\n\n");

    for (int i = 0; i < depth; i++)
    {
        Console.WriteLine($"{i} глубина");

        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (matrix[i, j, k] > 99) goto More99;
                Console.Write($"{matrix[i, j, k]}[{i} {j} {k}]\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
    }
More99:
    Console.WriteLine();
    Console.WriteLine("Двузначных значений больше нет");
}


int[,,] array = MakeRandArray(depth, rows, columns);
PrintArray(array, depth, rows, columns);





