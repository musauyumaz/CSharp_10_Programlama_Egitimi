namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region Continue - Örnek
        //Kullanıcının girdiği sonsuz adet sayıdan pozitif olanlarını çarpan ve 't'(enter) yapıldığında sonucu ekrana yazdıran kodu yazalım.

        #region Çözümüm
        string deger;
        int sayi, carpim = 1;
        while (true)
        {
            System.Console.Write("Sayı Giriniz : ");
            deger = Console.ReadLine();
            if (deger == "t")
            {
                System.Console.WriteLine("Sonuç : " + carpim);
                break;
            }
            else
            {
                sayi = int.Parse(deger);
                if (sayi < 0)
                    continue;

                carpim *= sayi;

            }

        }
        #endregion
        #region Hocanın Çözümü
        int carpimH = 1;
        while (true)
        {
            System.Console.WriteLine("Lütfen bir sayı giriniz.");
            string girilenDeger = Console.ReadLine();
            if (girilenDeger == "t")
            {
                System.Console.WriteLine(carpim);
            }
            // else
            // {
                int sayiH = int.Parse(girilenDeger);

                #region 1. İhtimal
                if (sayiH > 0)
                    carpimH *= sayiH;
                #endregion
                #region 2. İhtimal
                if (sayiH < 0)
                    continue;
                carpimH *= sayiH;
                #endregion


            // }

        }
        #endregion

        #endregion
    }
}
