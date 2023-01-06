namespace Application;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(typeof(decimal).IsPrimitive);
        Console.WriteLine(typeof(int).IsPrimitive);
        Console.WriteLine(typeof(byte).IsPrimitive);
    }
}
