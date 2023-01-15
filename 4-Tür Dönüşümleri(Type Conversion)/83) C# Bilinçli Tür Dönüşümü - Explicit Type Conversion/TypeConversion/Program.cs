namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region Sayısal İfadelerin Kendi Aralarında Tür Dönüşümü
        #region Bilinçli Tür Dönüşümü
        #region Örnek 1
        int x = 3000;
        short y = (short)x;
        Console.WriteLine(y);
        #endregion
        #region Örnek 2
        int a = 60000;
        short b = (short)a;
        Console.WriteLine(b);
        #endregion
        #region Örnek 3
        int c = 60000;
        byte d = (short)c;
        Console.WriteLine(d);
        #endregion
        #endregion
        #endregion
    }
}
