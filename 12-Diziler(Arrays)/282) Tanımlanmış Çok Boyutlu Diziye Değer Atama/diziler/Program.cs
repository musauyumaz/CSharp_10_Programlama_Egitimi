namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Çok Boyutlu/Biçimli/Dereceli Diziler 
        #region Tanımlanmış Çok Boyutlu Diziye Değer Atama
        #region 2 Dereceli Dizi Örneklendirme
        int[,] sayilar = new int[3, 4];
        sayilar[1, 2] = 5;
        sayilar[2, 0] = 15;
        #endregion
        #region Çok Dereceli Dizi Örneklendirme
        #region Örnek 1 
        int[,,,] sayilar = new int[2, 3, 4, 5];
        sayilar[0, 0, 0, 0] = 15;
        sayilar[0, 0, 0, 1] = 16;
        sayilar[0, 0, 0, 2] = 17;
        sayilar[0, 0, 0, 3] = 18;
        sayilar[0, 0, 0, 4] = 119;
        sayilar[1, 0, 0, 0] = 119;
        #endregion
        #region Örnek 2
        int[,,] sayilar = new int[2, 3, 4];
        sayilar[0, 0, 1] = 15;
        #endregion
        #endregion
        #endregion
        #endregion
    }
}
