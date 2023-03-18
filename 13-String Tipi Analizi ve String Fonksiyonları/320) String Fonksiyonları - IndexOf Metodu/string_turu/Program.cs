namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region IndexOf
        //Verilen değerin `string` ifade içerisinde olup olmamasını geriye `int` döndüren bir fonksiyondur.
        //geriye `int` olarak indexNo'yu döndürür.
        //-1 değerini döndürür.
        //IndexOf ilk eşleşen değerin index'ini döndürür.
        System.Console.WriteLine(metin.IndexOf("la"));
        System.Console.WriteLine(metin.IndexOf("lay"));
        System.Console.WriteLine(metin.IndexOf("La"));
        System.Console.WriteLine(metin.IndexOf("sana"));

        #endregion
        #endregion
    }
}
