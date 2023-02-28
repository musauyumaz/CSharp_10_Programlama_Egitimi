namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region Break Örnek
        //Kullanıcıdan alınan sonsuz adet sayı değerlerinden 37'nin katı girildiğinde sonlanan uygulamayı yazalım.    

        bool durum = true;
        while (durum)
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 37 == 0)
            {
                System.Console.WriteLine("Uygulama Sonlanmıştır");
                // durum = !durum;
                break;
            }


        }
        #endregion
    }
}
