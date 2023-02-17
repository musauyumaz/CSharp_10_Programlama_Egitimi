namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region try - catch Yapılanması
        #region try -catch İskelet Yapısı
        try
        {
            //Olası çalışma zamanı hatalarını barındıran/verebilecek olan kodları buraya yazıyoruz.
        }
        catch
        {
            //try içerisinde bir hata söz konusu olduğunda catch bloğu tetiklenecektir. 
            //Hataya dair; log, Kullanıcı bilgilendirme, Kontrollü kapanış vs.
        }
        #endregion

        System.Console.WriteLine("Lütfen birinci sayıyı giriniz.");
        int sayi1 = 0, sayi2 = 0;
        try
        {

            sayi1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            sayi2 = int.Parse(Console.ReadLine());

        }
        catch
        {
            System.Console.WriteLine("Lütfen doğru bir ifade giriniz.");
        }
        System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        #endregion
    }
}
