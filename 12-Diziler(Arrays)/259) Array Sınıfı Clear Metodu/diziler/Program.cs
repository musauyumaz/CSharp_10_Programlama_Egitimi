namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Metotlar
        #region Clear
        //Dizi içerisindeki tüm elemanları siliyor diye bilinir. Halbuki bu yanlıştır. Dizi içerisindeki tüm elemanlara, dizinin türüne uygun default/varsayılan değerleri atayan bir fonksiyondur.
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));
        Array.Clear(isimler, 0, isimler.Length);
        System.Console.WriteLine("*********************");
        for (int i = 0; i < isimler.Length; i++)
            System.Console.WriteLine(isimler.GetValue(i));
        System.Console.WriteLine("Test");
        #endregion
        #endregion
        #endregion
    }
}
