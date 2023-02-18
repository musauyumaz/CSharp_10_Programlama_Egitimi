namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region Mantıksal Hatalar - Örnek 2
        //Senaryo => Bir evlilik durumunu tutan değişkeni check edelim ve kişi evliyse bir promosyon/hediye gönderelim değilse de göndermeyelim.
        bool medeniHal = true;
        if(!medeniHal){
            System.Console.WriteLine("Hediye Gönder...");
        }
        else{
            System.Console.WriteLine("Hediye Gönderme...");
        }
        #endregion
    }
}
