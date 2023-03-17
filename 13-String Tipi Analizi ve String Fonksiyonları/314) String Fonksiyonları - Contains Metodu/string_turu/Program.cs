namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";
        #region Contains
        bool sonuc = metin.Contains("Sana");
        System.Console.WriteLine(sonuc);
        #endregion
        #endregion
    }
}
