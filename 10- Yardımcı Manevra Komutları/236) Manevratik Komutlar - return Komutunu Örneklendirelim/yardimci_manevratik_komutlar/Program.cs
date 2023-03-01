namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region return Örnek
        //Kullanıcı 'c' tuşuna basana kadar sonsuz döngüde dönen uygulamayı yazınız.

        while (true)
        {
            if (Console.ReadKey().KeyChar == 'c')
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Uygulama Sona Ermiştir.");
                return;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Uygulama Çalışıyor...");

        }
        #endregion
    }
}
