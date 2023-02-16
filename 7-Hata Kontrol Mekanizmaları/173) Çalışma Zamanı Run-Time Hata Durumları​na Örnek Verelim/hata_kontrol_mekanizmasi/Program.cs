namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region Çalışma Zamanı Hata Durumları Örnek
        System.Console.WriteLine("Lütfen birinci sayıyı giriniz.");
        int sayi1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
        int sayi2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        #endregion
    }
}
