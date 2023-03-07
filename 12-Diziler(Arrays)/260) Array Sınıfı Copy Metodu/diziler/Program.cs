namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Metotlar
        #region Copy
        //Elimizdeki bir dizinin verilerini bir başka diziye kopyalamamızı sağlayan bir fonksiyondur.
        string[] isimler2 = new string[isimler.Length];
        Array.Copy(isimler, isimler2, 5);
        for (int i = 0; i < isimler2.Length; i++)
            System.Console.WriteLine(isimler2[i]);

        Array.Copy(isimler, 2, isimler2, 3, 2);
        for (int i = 0; i < isimler2.Length; i++)
            System.Console.WriteLine(isimler2[i]);

        #endregion
        #endregion
        #endregion
    }
}
