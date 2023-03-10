namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Ranges and Indices
        int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };

        // Index i1 = 5, i2 = 10;
        int i1 = 5, i2 = 10;

        Range range = i1..i2;
        var sayilar2 = sayilar[range];
        var sayilar2 = sayilar[i1..i2];
        #endregion
    }
}
