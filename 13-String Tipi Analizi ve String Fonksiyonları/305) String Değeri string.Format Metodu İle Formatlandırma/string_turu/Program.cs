namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String Formatlandırma
        string isim = "Musa", soyisim = "Uyumaz", tcNo = "12345678910";
        int yas = 24;
        bool medeniHal = false;

        System.Console.WriteLine("TC No : .............. olan ..... ...... şahsın bilgileri | Yaş : .. | Medeni Hal : ..");
        #region string.Format
        string sonuc = string.Format("TC No : {0} olan {1} {2} şahsın bilgileri | Yaş : {3} | Medeni Hal : {4}", tcNo, isim, soyisim, yas, medeniHal ? "Evli" : "Bekar");
        System.Console.WriteLine(sonuc);
        #endregion
        #endregion
    }
}
