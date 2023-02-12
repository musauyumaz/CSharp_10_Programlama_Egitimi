namespace akis_kontrol_mekanizmalari;
using System;
class Program
{
    static void Main(string[] args)
    {
        #region Senaryo 5
        //Girilen sayının negatif ya da pozitif olduğunu gösteren uygulamayı yazalım.
        #region Çözümüm
        Console.Write("Sayı Giriniz : ");
        int sayi = int.Parse(Console.ReadLine());

        Console.WriteLine(sayi > 0 ? "Pozitif" : "Negatif");
        #endregion

        #region Hocanın Çözümü
        int sayiH = int.Parse(Console.ReadLine());

        string sonuc = "";

        if (sayiH < 0)
            // Console.WriteLine("Negatif");
            sonuc = "Negatif";

        else
            // System.Console.WriteLine("Pozitif");
            sonuc = "Pozitif";

        System.Console.WriteLine(sonuc);

        #endregion
        #endregion
    }
}
