namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Metotlar
        #region Sort
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));

        Array.Sort(isimler);
        System.Console.WriteLine("****************************");

        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));
        #endregion
        #endregion
        #endregion
    }
}
