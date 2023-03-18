namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region CompareTo
        //Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak `int` türde değer elde etmemizi salar.
        //0 : Her iki değer birbirine eşittir.
        //1 : Soldaki sağdakinden alfa numerik olarak büyük
        //-1 : Soldaki sağdakinden alfa numerik olarak küçük

        System.Console.WriteLine(metin.CompareTo("Z"));
        System.Console.WriteLine(metin.CompareTo("a"));
        System.Console.WriteLine(metin.CompareTo(metin));
        #endregion
        #endregion
    }
}
