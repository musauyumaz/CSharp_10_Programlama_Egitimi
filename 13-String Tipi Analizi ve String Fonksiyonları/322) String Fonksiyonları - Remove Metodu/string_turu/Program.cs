namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Remove
        //Metinsel ifade de indexel olarak verilen değer aralığını silen bir fonksiyondur.
        //`Insert`te olduğu gibi ilgili fonksiyon yapmış olduğu işlem neticesinde yeni değeri üreterek bizlere `string` olarak döndürecektir. Elimizdeki orjinal veri değişmeyecektir.
        System.Console.WriteLine(metin.Remove(5));//5. indexten sonraki tüm değerleri sil
        System.Console.WriteLine(metin.Remove(5,10));//5. indexten başla 10 adet sil
        System.Console.WriteLine(metin);
        #endregion
        #endregion
    }
}
