namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region Adımızın İlketen 3. Soyadımızın Sondan 5. Karakterini Getirelim
        string adSoyad = "Musa Uyumaz";
        
        #region 1. Çözüm
        System.Console.WriteLine(adSoyad[2]);
        System.Console.WriteLine(adSoyad[adSoyad.Length - 5]);
        #endregion

        #region 2.Çözüm
        string aralik = adSoyad[2..^4];
        System.Console.WriteLine(aralik[0]);
        System.Console.WriteLine(aralik[aralik.Length - 1]);
        #endregion
        #endregion
    }
}
