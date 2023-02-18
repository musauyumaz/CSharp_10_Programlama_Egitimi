namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region when Yapısı İle Hata Filtreleme(C# 6.0)
        //try catch bloklarına when keywordü ile şart uygulayabilmekteyiz...
        string x = "a";
        try
        {
            int s1 = 0, s2 = 10;
            int a = s2 / s1;
        }
        catch (DivideByZeroException ex) when (x == "a")
        {
            System.Console.WriteLine("Mesaj : " + ex.message);
        }
        catch (DivideByZeroException ex) when (x == "b")
        {
            System.Console.WriteLine("Mesaj : " + ex.message);
        }
        catch (Exception ex)
        {

        }

        #endregion
    }
}
