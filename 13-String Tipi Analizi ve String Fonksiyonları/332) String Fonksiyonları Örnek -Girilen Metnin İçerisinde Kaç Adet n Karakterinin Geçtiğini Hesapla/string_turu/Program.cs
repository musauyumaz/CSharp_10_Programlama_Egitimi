namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region Girilen Metnin İçerisinde Kaç Adet "n" Karakterinin Geçtiğini Hesaplayalım
        System.Console.WriteLine("Lütfen Bir Metin Giriniz.");
        string metin = Console.ReadLine();

        int adet = 0;
        for (int i = 0; i < metin.Length; i++)
        {
            if (metin[i] == 'n')
                adet++;
        }
        System.Console.WriteLine(adet);
        #endregion
    }
}
