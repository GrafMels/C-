int inty = 1;
string SayHello(int inty)
{
    inty++;
    if (inty < 10) SayHello();
    return "Hello";
}
SayHello(inty);
