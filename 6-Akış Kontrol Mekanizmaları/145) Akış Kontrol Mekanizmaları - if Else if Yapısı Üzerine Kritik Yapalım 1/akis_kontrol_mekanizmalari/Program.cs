namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region if - else - if - KRİTİK
        int sayi = int.Parse(Console.ReadLine());
        if (sayi > 100 && sayi <= 200)
        {
            System.Console.WriteLine("100 ile 200 arasında");
        }
        else if (sayi > 200 && sayi <= 300)
        {
            System.Console.WriteLine("200 ile 300 arasında");
        }
        else if (sayi > 200 && sayi <= 400)
        {
            System.Console.WriteLine("300 ile 400 arasında");
        }

        int sayi = int.Parse(Console.ReadLine());
        if (sayi > 100 && sayi <= 200)
        {
            System.Console.WriteLine("100 ile 200 arasında");
        }
        if (sayi > 200 && sayi <= 300)
        {
            System.Console.WriteLine("200 ile 300 arasında");
        }
        if (sayi > 300 && sayi <= 400)
        {
            System.Console.WriteLine("300 ile 400 arasında");
        }
        #endregion
    }
}
