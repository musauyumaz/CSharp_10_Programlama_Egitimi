namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Switch Case
        //Switch case, kodun akışında belirli bir şarta göre yönlendirme yapmamızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır.
        //Switch case yapılanması sadece bir değişkenin değerinin sadece eşitlik durumları kontrol ederken kullanılabilir.
        //Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir.

        string adi = "Ahmet";

        switch (adi)//kontrol edilen türü ne ise case bloklarında da aynı türde değerlerle kontrol edilmelidir.
        {
            case "Mehmet":
                System.Console.WriteLine("Adı Mehmet");
                break;
            case "Ahmet":
                System.Console.WriteLine("Adı Ahmet");
                break;
            case "Hilmi":
                System.Console.WriteLine("Adı Hilmi");
                break;
            default:
            System.Console.WriteLine("Hiçbiri değil");
                break;
        }

        #endregion
    }
}
