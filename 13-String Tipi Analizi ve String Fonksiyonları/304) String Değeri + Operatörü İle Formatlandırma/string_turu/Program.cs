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

        #region + Operatörü
        System.Console.WriteLine("TC No : " + tcNo + "olan " + isim + " " + soyisim + " şahsın bilgileri | Yaş : " + yas + "| Medeni Hal : " + (medeniHal ? "Evli" : "Bekar"));
        #endregion
        #endregion
    }
}
