namespace Degiskenler;

class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Değişkene Değer Atama
        #region Tanımlama Aşamasında Değer Atama
        int x = 123;
        string adi = "Musa";
        string soyadi = "Uyumaz";
        char basHarf = 'M';
        #endregion
        #region Tanımlandıktan Sonra Değer Atama
        #region Örnek 1
        int y;
        y = 15;
        #endregion
        #region Örnek 2
        int a = 5;
        int b = 15;
        string c;

        c = "Hilmi";
        #endregion
        #region Örnek 3
        int w = 5;
        char q = 'a';
        bool p;
        decimal d = 3.14m;
        p = false;
        #endregion
        #endregion
        //Dikkat 
        //Bir değişkene atanan en son değer geçerlidir.
        int e = 5;
        e = 15;
        e = 20;
        #endregion
    }
}
