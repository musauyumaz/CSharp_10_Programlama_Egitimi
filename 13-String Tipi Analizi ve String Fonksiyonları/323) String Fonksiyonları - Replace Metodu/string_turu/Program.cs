namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Replace
        //Elimizdeki metinsel ifade de belirtilen değerleri yahut karakterleri, belirtilen diğer değerler ya da karakterler ile değiştirmemizi sağlayan bir fonksiyondur.
        //Sonuç olarak `string` değer üretecek ve geriye döndürecektir...
        System.Console.WriteLine(metin.Replace('a','b'));;
        System.Console.WriteLine(metin.Replace("la","lo"));;
        #endregion
        #endregion
    }
}
