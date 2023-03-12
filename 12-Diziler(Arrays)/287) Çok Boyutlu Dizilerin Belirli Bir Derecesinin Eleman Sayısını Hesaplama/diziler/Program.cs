namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Çok Boyutlu/Biçimli/Dereceli Diziler
        int[,,] sayilar = new int[2, 2, 4];
        sayilar[0, 0, 0] = 1;
        sayilar[0, 0, 1] = 2;
        sayilar[0, 0, 2] = 3;
        sayilar[0, 0, 3] = 4;
        sayilar[0, 1, 0] = 5;
        sayilar[0, 1, 1] = 6;
        sayilar[0, 1, 2] = 7;
        sayilar[0, 1, 3] = 8;
        sayilar[1, 0, 0] = 9;
        sayilar[1, 0, 1] = 10;
        sayilar[1, 0, 2] = 11;
        sayilar[1, 0, 3] = 12;
        sayilar[1, 1, 0] = 13;
        sayilar[1, 1, 1] = 14;
        sayilar[1, 1, 2] = 15;
        sayilar[1, 1, 3] = 16;
        System.Console.WriteLine(sayilar.GetLength(0));
        System.Console.WriteLine(sayilar.GetLength(1));
        System.Console.WriteLine(sayilar.GetLength(2));
        #endregion
    }
}
