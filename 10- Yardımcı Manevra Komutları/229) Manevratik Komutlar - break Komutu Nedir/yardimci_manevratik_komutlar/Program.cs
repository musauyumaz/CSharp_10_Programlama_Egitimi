namespace yardimci_manevratik_komutlar;
class Program
{
    static void Main(string[] args)
    {
        #region Break
        switch (10)
        {
            case 5:
                break;
            case 10:
                break;
            case 15:
                break;
        }

        while (true)
        {
            break;
        }

        for (int i = 0; i < 10; i++)
        {
            break;
        }

        do
        {
            break;
        } while (true);

        foreach (var item in new[] { "" })
        {
            break;
        }


        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                break;
            }
        }


        do
        {
            if (true)
            {
                break;
            }
        } while (true);


        while (true)
        {
            try
            {
                break;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        while (true)
        {
            if (DateTime.Now.Second == 45)
                break;
            System.Console.WriteLine(DateTime.Now);
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == 1)
                    break;
                System.Console.WriteLine("i : " + i + " j : " + j);
            }
        }

        #endregion

    }
}
