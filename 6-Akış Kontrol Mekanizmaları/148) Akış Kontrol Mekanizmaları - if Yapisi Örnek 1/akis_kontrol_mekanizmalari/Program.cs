namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Senaryo 1
        //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL'den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

        #region Çözümüm
        System.Console.Write("Birinci Ürünün Fiyatını Giriniz :");
        float birinciUrunFiyat = float.Parse(Console.ReadLine());
        System.Console.Write("İkinci Ürünün Fiyatını Giriniz :");
        float ikinciUrunFiyat = float.Parse(Console.ReadLine());
        if ((birinciUrunFiyat + ikinciUrunFiyat) > 200)
            System.Console.WriteLine(birinciUrunFiyat + (ikinciUrunFiyat * 0.75));

        else
            System.Console.WriteLine(birinciUrunFiyat + ikinciUrunFiyat);
        #endregion
        #region Hocanın Çözümü
        System.Console.Write("Lütfen birinci ürünün fiyatını giriniz : ");
        int birinciUrununFiyati = int.Parse(Console.ReadLine());
        System.Console.Write("Lütfen ikinci ürünün fiyatını giriniz : ");
        int ikinciUrununFiyati = int.Parse(Console.ReadLine());

        #region 1. Kritik
        // int toplam = birinciUrununFiyati + ikinciUrununFiyati;
        // if (toplam > 200)
        // {
        //     //.....
        // }
        #endregion
        #region 2. Kritik
        if (birinciUrununFiyati + ikinciUrununFiyati > 200)
        {
            // int toplamSonTutar = birinciUrununFiyati + (ikinciUrununFiyati * 75 / 100);
            //System.Console.WriteLine(toplamSonTutar);
            System.Console.WriteLine(birinciUrununFiyati + (ikinciUrununFiyati * 75 / 100));
        }
        else
        {
            System.Console.WriteLine(birinciUrununFiyati + ikinciUrununFiyati);
        }
        #endregion
        #endregion
        #endregion
    }
}
