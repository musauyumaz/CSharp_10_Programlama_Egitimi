namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region finally Bloğu
        //finally bloğu try catch yapılanmasında hata alınsa da alınmasa da her iki durumda da tetiklenmesi/çalıştırılması gereken kodları yazdığımız bloktur.
        try
        {
            //hata verebilecek kodlar buraya
            System.Console.WriteLine("try");
        }
        catch
        {
            //hata alındıktan sonra yapılacak işlemler buraya
            System.Console.WriteLine("catch");
        }
        finally
        {
            //Her iki durumda da çalışmasını istediğimiz kodlar buraya
            System.Console.WriteLine("finally");
        }
        #endregion
    }
}
