namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region Exception Dışında Farklı Bir Tür İle Hata Yakalama
        try
        {
            int s1 = 0, s2 = 10;
            int a = s2 / s1;

            int.Parse("asfasfsafsa");
        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine("Mesaj : " + ex.Message);
        }
        #endregion
    }
}
