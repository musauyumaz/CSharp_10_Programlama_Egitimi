namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
    #region goto Kritik

    a:
        for (int i = 0; i < 190; i++)
        {
            System.Console.WriteLine(i);
            goto a;
        }
        #endregion
    }
}
