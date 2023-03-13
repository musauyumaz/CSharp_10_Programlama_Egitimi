namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Dizi İçerisinde Dizi Tanımlama/Düzensiz Diziler/Dizi Dizileri
        int[][] sayilar = new int[3][];
        sayilar[0] = new int[3] { 3, 5, 7 };
        sayilar[1] = new int[5] { 3, 5, 7, 523, 01 };
        sayilar[2] = new int[10] { 3, 5, 7, 234, 234, 23, 4, 234, 234, 123 };

        System.Console.WriteLine(sayilar[0][0]);
        sayilar[0][0] = 13;
        System.Console.WriteLine(sayilar[0][0]);
        #endregion
    }
}
