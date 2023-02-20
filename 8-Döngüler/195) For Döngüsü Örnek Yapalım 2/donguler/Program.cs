namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek 1
        //1 ile 40(Dahil) arasındaki çift sayıları toplayarak sonucu ekranda gösterelim.
        int toplamSonuc = 0;
        for (int i = 1; i <= 40; i++)
        {
            if (i % 2 == 0)
            {
                toplamSonuc += i;
            }
        }
        System.Console.WriteLine("Toplam Sonuç : " + toplamSonuc);
        #endregion
    }
}
