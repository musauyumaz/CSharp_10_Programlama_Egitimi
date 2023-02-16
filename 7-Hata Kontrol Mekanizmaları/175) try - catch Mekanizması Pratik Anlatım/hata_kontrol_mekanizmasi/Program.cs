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


        try
        {
            System.Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        }
        catch 
        {
            System.Console.WriteLine("Lütfen doğru bir ifade giriniz.");
        }
        #endregion
    }
}
