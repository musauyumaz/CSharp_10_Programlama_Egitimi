namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Switch Expressions
        #region Eski Yöntem
        string isim = "";
        int i = 10;
        switch (i)
        {
            case 5:
                isim = "Hilmi";
                break;
            case 7:
                isim = "Rıfkı";
                break;
            case 10:
                isim = "Gençay";
                break;
            case 17:
                isim = "Musa";
                break;
            default:
        }
        #endregion
        #region Yeni Yöntem
        int j = 10;
        string ad = i switch
        {
            5 => "Hilmi",
            7 => "Rıfkı",
            10 => "Gençay",
            17 => "Musa"
        };
        #endregion
        #endregion
    }
}
