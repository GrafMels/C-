using System;
namespace GrafMels
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            
        }
    }
}
