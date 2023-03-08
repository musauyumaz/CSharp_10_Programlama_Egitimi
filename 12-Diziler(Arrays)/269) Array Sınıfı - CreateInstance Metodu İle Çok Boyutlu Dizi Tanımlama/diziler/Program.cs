namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        Array dizi = Array.CreateInstance(typeof(int), 5, 3, 5, 6, 32, 2, 23, 23, 2);
        System.Console.WriteLine(dizi.Rank);
    }
}
