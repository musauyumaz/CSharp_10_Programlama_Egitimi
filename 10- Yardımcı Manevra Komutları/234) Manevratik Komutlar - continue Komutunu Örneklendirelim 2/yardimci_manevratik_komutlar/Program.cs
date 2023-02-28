namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region Continue - Örnek
        //1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdıralım.

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 7 == 0)
                continue;
            System.Console.WriteLine(i);
        }
        #endregion

    }
}
