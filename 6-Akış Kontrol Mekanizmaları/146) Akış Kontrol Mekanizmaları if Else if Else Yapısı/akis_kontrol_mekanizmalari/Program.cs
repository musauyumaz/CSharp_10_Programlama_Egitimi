namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region if - else if - ... - else
        int i = 100;
        if (i < 100)
        {
            System.Console.WriteLine("100'den küçük");
        }
        else if (i > 100)
        {
            System.Console.WriteLine("100'den büyük");
        }
        else
        {
            System.Console.WriteLine("100'e eşit");
        }

        #endregion
    }
}
