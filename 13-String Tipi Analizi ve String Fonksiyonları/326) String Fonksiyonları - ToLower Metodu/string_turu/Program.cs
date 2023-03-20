namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "lAylaylOm galiba Sana göre sevmeler...";

        #region ToLower
        //Eldeki metinsel ifadenin tüm karakterlerini küçük karakter olarak düzenler.
        System.Console.WriteLine(metin);
        System.Console.WriteLine(metin.ToLower());
        #endregion
        #endregion
    }
}
