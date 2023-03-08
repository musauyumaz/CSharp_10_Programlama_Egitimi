namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Özellikler
        #region Rank
        int[,,] x = new int[3, 4, 5];
        System.Console.WriteLine(isimler.Rank);
        System.Console.WriteLine(x.Rank);
        #endregion
        #endregion
        #endregion
    }
}
