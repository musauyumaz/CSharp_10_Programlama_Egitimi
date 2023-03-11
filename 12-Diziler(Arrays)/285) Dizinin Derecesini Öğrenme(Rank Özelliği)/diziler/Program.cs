namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Çok Boyutlu/Biçimli/Dereceli Diziler
        int[,] sayilar = new int[4, 3];
        sayilar[0, 0] = 3;
        sayilar[0, 1] = 5;
        sayilar[0, 2] = 7;
        sayilar[1, 0] = 5;
        sayilar[1, 1] = 6;
        sayilar[1, 2] = 7;
        sayilar[3, 2] = 67;

        System.Console.WriteLine(sayilar.Rank);
        #endregion
    }
}
