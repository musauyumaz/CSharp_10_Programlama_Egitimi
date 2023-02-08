namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Tuple Patterns
        int s1 = 10;
        int s2 = 20;
        string mesaj = "";
        switch (s1, s2)
        {
            case (5, 10):
                mesaj = "5 ile 10 değerleri";
                break;
            case (10, 20):
                mesaj = "10 ile 20 değerleri";
                break;
        }
        System.Console.WriteLine(mesaj);

        int s3 = 15;
        int s4 = 15;
        string mesaj2 = (s3, s4) switch
        {
            (5, 10) => "5 ile 10 değerleri",
            (10, 20) => "10 ile 20 değerleri",
            (15, 15) => "15 ile 15 değerleri"
        };
        System.Console.WriteLine(mesaj2);
        #endregion
    }
}
