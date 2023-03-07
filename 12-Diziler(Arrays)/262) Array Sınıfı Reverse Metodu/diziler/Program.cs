namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Metotlar
        #region Reverse
        //Elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur.
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));
        Array.Reverse(isimler);
        System.Console.WriteLine("*************************");
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));

        System.Console.WriteLine("*************************");
        Array.Reverse(isimler, 0, 3);
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));
        #endregion
        #endregion
        #endregion
    }
}
