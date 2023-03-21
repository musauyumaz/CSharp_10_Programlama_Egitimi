namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region Girilen Metindeki Kelime Sayısını Hesaplayalım
        System.Console.WriteLine("Lütfen bir metin giriniz");
        string metin = Console.ReadLine().Trim();
        #region 1. Çözüm
        string[] kelimeler = metin.Split(' ');
        System.Console.WriteLine(kelimeler.Length);
        #endregion
        #region 2. Çözüm
        
        int adet = 1;
        while (true)
        {
            int index = metin.IndexOf(' ');
            if (index == -1)
                break;
            adet++;
            metin = metin.Substring(index + 1);
        }
        System.Console.WriteLine(adet);
        #endregion
        #endregion
    }
}
