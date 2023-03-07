namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Özellikler
        #region IsFixedSize
        //Bir veri kümesinin eleman sayısının sabit olup olmama durumunu `IsFixedSize` ile öğrenebiliriz.
        //Tümmmm dizilerde eleman sayısı sabit olduğu için sürekli `true` dönecektir. Örneğin `ArrayList` koleksiyonunda `false` dönmektedir. Çünkü orada eleman sayısı sabit değildir.
        System.Console.WriteLine(isimler.IsFixedSize);
        #endregion
        #endregion
        #endregion
    }
}
