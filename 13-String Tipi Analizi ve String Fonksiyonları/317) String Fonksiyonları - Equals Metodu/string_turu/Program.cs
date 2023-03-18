namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";
        #region Equals
        //Elimizdeki metinsel ifadeyle herhangi bir ifadenin değersel olarak eşit olup olmamasını check eden/denetleyen ve geriye `bool` sonuç dönen bir fonksiyon.
        System.Console.WriteLine(metin.Equals("laylaylom galiba sana göre sevmeler..."));
        #endregion
        #endregion
    }
}
