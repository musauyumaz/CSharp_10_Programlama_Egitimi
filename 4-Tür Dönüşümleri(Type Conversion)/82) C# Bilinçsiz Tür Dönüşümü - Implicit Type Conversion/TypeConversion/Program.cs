namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region Sayısal İfadelerin Kendi Aralarında Tür Dönüşümü
        #region Bilinçsiz Tür Dönüşümü
        //Bir sayısal türün kendisinden daha geniş aralıktaki bir başka sayısal türe atanması bilinçsiz tür dönüşümüdür.
        #region Örnek 1
        int a = 3000;
        float f = a;
        #endregion
        #region Örnek 2 
        short x = 123;
        long y = x;
        #endregion
        #endregion
        #endregion
    }
}
