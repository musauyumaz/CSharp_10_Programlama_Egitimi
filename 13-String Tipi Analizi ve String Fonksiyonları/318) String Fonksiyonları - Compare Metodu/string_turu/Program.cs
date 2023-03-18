namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Compare
        //Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak `int` türde değer elde etmemizi salar.
        //0 : Her iki değer birbirine eşittir.
        //1 : Soldaki sağdakinden alfa numerik olarak büyük
        //-1 : Soldaki sağdakinden alfa numerik olarak küçük

        System.Console.WriteLine(string.Compare(metin, "Z"));
        System.Console.WriteLine(string.Compare(metin, "a"));
        System.Console.WriteLine(string.Compare(metin, metin));

        System.Console.WriteLine(string.Compare(metin, 9, metin, 8, 5));
        #endregion
        #endregion
    }
}
