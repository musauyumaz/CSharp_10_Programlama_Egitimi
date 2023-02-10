namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region if - else if
        int sayi = 30;

        if (sayi > 5 && sayi <= 10)
        {
            System.Console.WriteLine(sayi * 5);
        }
        else if (sayi > 10 && sayi <= 20)
        {
            System.Console.WriteLine(sayi * 10);
        }
        else if (sayi > 20 && sayi <= 30)
        {
            System.Console.WriteLine(sayi * 20);
        }
        #endregion
    }
}
