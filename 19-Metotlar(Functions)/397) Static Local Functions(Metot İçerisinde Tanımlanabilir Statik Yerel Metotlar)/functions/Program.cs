namespace functions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void X(int a)
    {
        int b = 0;
        static void Y(int a, int b)
        {
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }

        Y(a, b);
    }
}
