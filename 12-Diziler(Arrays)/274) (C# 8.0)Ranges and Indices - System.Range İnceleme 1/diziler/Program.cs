namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Ranges and Indices
        int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };

        Range range = 5..10;
        var sayilar2 = sayilar[range];
        sayilar2[0] = 100;

        Range range = ..; //--> Tüm diziye karşılık gelir.
        var sayilar2 = sayilar[range];
        sayilar2[0] = 100;
        #endregion
    }
}
