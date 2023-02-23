namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region İnceleme 3
        //0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım.

        int i = 0, toplam = 0;
        while (i <= 100)
        {
            //i++;
            if (i % 2 == 1)
                toplam += i;
            i++;
        }

        #endregion
    }
}
