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