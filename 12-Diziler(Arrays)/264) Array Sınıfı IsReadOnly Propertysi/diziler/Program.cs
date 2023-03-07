namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Özellikler
        #region IsReadOnly
        //Bir dizinin sadece okunabilir olup olmadığını `bool` türde bildiren bir özelliktir.
        System.Console.WriteLine(isimler.IsReadOnly);
        #endregion
        #endregion
        #endregion
    }
}
