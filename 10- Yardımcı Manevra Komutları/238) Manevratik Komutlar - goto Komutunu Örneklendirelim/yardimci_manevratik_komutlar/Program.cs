namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region goto Örnek
        //1'den 100'e kadar sayalım

        int i = 1;
    x:
        System.Console.WriteLine(i++);
        if (i <= 100)
            goto x;

        for (int i = 0; i <= 100; i++)
            System.Console.WriteLine(i);

        #endregion
    }
}
