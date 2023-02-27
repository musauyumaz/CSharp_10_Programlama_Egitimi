namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region Break Örnek
        //Kullanıcıdan 't' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yazalım.

        #region Çözümüm
        int sayi, toplam = 0;
        string deger;
        while (true)
        {
            System.Console.Write("Sayı Giriniz : ");
            deger = Console.ReadLine();
            if (deger == "t")
                break;
            sayi = int.Parse(deger);
            toplam += sayi;
        }
        System.Console.WriteLine("Toplam : " + toplam);
        #endregion

        #region Hocanın Çözümü

        int toplamH = 0;
        while (true)
        {
            System.Console.WriteLine("Lütfen bir sayı giriniz.");
            string girilenDeger = Console.ReadLine();
            if (girilenDeger == "t")
            {
                System.Console.WriteLine("Toplam Sonuç : " + toplamH);
                break;
            }
            else
            {
                toplamH += int.Parse(girilenDeger);
            }
        }
        #endregion
        #endregion
    }
}
