namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region continue

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 != 0)
                continue;

            System.Console.WriteLine(i);
        }

        while (true)
        {
            if (true)
            {
                switch (1)
                {
                    case 5:
                        continue;
                        break;
                    default:
                }
            }
        }

        #endregion
    }
}
