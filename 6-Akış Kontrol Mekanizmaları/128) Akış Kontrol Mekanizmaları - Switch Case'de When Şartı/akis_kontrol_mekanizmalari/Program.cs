namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region when
        int satisTutari = 1000;
        switch (satisTutari)
        {
            case 1000 when (3 == 5):
                break;
            case 1000 when (3 == 3):
                break;
        }
        #endregion
    }
}
