namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region goto
        int i = 10;
        switch (i)
        {
            case 5:
                System.Console.WriteLine(i * 10); 
                break;
            case 6:
                System.Console.WriteLine(i / 5);
                break;
            case 7:
                // System.Console.WriteLine(i * 10);//kod tekrarı vardır
                // break;
                // goto case 5;
            case 10:
                // System.Console.WriteLine(i * 10);//kod tekrarı vardır
                // break;
                goto case 5;

        }
        #endregion
    }
}
