// 1-й вид методов
void Method1()
{
    Console.WriteLine("Автор GrafMels");
}
Method1();



// 2-й вид методов

void Method2(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
}
Method2("Текст сообщения", 4);
Method2(count: 4, msg: "Текст сообщения");




// 3-й вид методов

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// 4-й вид методов


string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);



// продолжение лекции

// таблица умножения
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();
}


// новая задача
string text = "- Я думаю, - сказал князь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

// программа для сортировки масиива по возрастанию

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// раскоментируй что бы заполнить масиив случайными числами
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(1, 10);
// }

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);