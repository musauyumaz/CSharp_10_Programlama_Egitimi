namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Substring
        //Metinsel ifadenin belirli bir aralığını elde etmemizi sağlar.
        System.Console.WriteLine(metin.Substring(5));//5. indexten sonuna kadar tüm değerleri getir.
        System.Console.WriteLine(metin.Substring(5,10));//5. indexten sonra 10 karakter getirecektir.
        #endregion
        #endregion
    }
}
