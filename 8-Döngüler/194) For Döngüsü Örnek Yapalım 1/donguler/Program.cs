namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek 1
        //1'den 10'a ladar olan sayıları alt alta ekrana yazdıralım.
        #region 1. Çözüm
        for (int i = 1; i <= 10; i++)
        {
            System.Console.WriteLine(i);
        }
        #endregion

        #region 2. Çözüm
        for (int i = 50; i < 60; i++)
        {
            System.Console.WriteLine(i - 49);
        }
        #endregion

        #endregion
    }
}
