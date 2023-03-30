namespace hazir_kutuphaneler;
class Program
{
    static void Main(string[] args)
    {
        #region Random Sınıfı
        #region Next Fonksiyonu
        Random random = new Random();
        System.Console.WriteLine(random.Next()); //0 - ....
        System.Console.WriteLine(random.Next(100)); //0 - 100
        System.Console.WriteLine(random.Next(50, 100)); //50 - 100
        #endregion
        #endregion
    }
}
