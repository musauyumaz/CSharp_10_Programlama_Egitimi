namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Insert
        //Elimizdeki metinsel ifadeye bir değer dahil etmemizi/eklememizi sağlayan bir fonksiyondur.
        string eklenmisMetin = metin.Insert(17 ,"merhaba");
        System.Console.WriteLine(metin);
        System.Console.WriteLine(eklenmisMetin);
        #endregion
        #endregion
    }
}
