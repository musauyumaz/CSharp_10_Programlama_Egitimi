using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;
            for (int i = 0; i < 1000; i++)
            {
                b = i;
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i * i);
                }
            }
        }
    }
}
