namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Sınıfı
        Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
        #region Metotlar
        #region IndexOf
        //Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
        //Arama neticesinde ilgili değer varsa int olarak o değerin index numarasını döndürecektir. Yoksa -1 değerini döndürür.
        int index = Array.IndexOf(isimler, "Rıfkı");
        if (index != -1)
        {
            //Demek ki aranana değer ilgili dizide bulunmaktadır...
            System.Console.WriteLine("Var");
        }
        int index = Array.IndexOf(isimler, "Rıfkı", 0, 3);
        #endregion
        #endregion
        #endregion
    }
}
