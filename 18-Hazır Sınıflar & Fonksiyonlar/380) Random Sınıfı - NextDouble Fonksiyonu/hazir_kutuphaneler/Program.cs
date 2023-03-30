namespace hazir_kutuphaneler;
class Program
{
    static void Main(string[] args)
    {
        #region Random Sınıfı
        #region NextDouble Fonksiyonu
        Random random = new Random();
        while (true)
            System.Console.WriteLine(random.NextDouble());
        #endregion
        #endregion
    }
}
