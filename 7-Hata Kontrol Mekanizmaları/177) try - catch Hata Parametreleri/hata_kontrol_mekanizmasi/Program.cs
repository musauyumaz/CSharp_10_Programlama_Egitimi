namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region try - catch Yapılanması - Hata Parametreleri
        //Çalışma zamanında alınan hataya dair bizlere bilgi veren bilgi taşıyan parametrelerdir...

        int s1 = 0, s2 = 10;
        int a = s2 / s1;

        object x = null;
        x.ToString();

        int.Parse("asgsagdasfalkfsa");


        try
        {
            int s1 = 0, s2 = 10;
            int a = s2 / s1;
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Mesaj : " + ex.Message);
        }
        #endregion
    }
}
