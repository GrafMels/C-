int[] array = GetArray(10, 0, 9);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++) // size = array.Length
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // [0,5) => [0;4]
    }
    return res;
}
// тут всё сложнее чем кажется
void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)// вишенка на торте это то что мы делаем в два раза меньше проходов в массиве потому что они местами меняют пары
    {
        int temp = inArray[i];// мы сохраняем элемент в переменную что бы не потерять его
        inArray[i] = inArray[inArray.Length - i - 1];// мы заменяем уже сохранёный в переменную элемент обратным ему по номеру в массиве
        inArray[inArray.Length - i - 1] = temp;// теперь сохранёный элемен переносим на место обратное в массиве
        // таким образом мы поменяли два обратных друг другу элемента местами
    }
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length]; // size = inArray.Length
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}
