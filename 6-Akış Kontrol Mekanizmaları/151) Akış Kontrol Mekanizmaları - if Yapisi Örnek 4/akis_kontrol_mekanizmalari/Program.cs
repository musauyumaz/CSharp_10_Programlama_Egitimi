namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Senaryo 4
        //Girilen sayının değeri 10 değilse ekrana "sayı yanlış" yazdıralım.
        #region Çözümüm
        System.Console.Write("Sayı Giriniz : ");
        int sayi = int.Parse(Console.ReadLine());
        if (sayi != 10)
            System.Console.WriteLine("sayı yanlış");
        #endregion
        #region Hocanın Çözümü
        System.Console.Write("Sayı Giriniz : ");
        int sayiH = int.Parse(Console.ReadLine());

        #region Kritik 1
        if (sayiH == 10)
        {

        }
        else
        {
            System.Console.WriteLine("sayı yanlış");
        }

        #endregion
        #region Kritik 2
            
        if (sayiH != 10)
        {
            System.Console.WriteLine("sayı yanlış");
        }
        #endregion
        #region Kritik 3
        System.Console.WriteLine(sayiH == 10 ? "" : "sayı yanlış");
        #endregion
        #endregion

        #endregion
    }
}
