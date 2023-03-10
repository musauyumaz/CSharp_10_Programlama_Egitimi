namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Range and Indices
        int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };

        // Index i = ^3;
        // System.Console.WriteLine(sayilar[i]);

        Range range = ^7..^3;
        var sayilar2 = sayilar[range];
        #endregion
    }
}
