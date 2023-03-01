namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region goto
        switch (10)
        {
            case 5:
                System.Console.WriteLine("asdfgasgfasgfa");
                break;
            case 10:
                goto case 15;
            case 15:
                break;
        }

        a:
        System.Console.WriteLine("Merhaba");
        System.Console.WriteLine("Dünya");
        goto a;

        #endregion
    }
}
