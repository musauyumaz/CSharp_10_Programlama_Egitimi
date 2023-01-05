using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i * i);
                }
            }
        }
    }
}
