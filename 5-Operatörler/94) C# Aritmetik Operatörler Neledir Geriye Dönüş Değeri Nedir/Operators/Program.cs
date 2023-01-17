namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        #region Aritmetik Operatörler
        // +
        // -
        // *
        // /
        // %

        #region Aritmetik Operatörler Geriye Dönüş Değeri
        //Aritmetik operatörler iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesinde geriye 'uygun türde' sonuç dönerler.

        #region İnceleme 1
        int sonuc = 3 + 5;
        #endregion
        #region İnceleme 2
        int x = 3,
            y = 5;
        // int y = 5;
        int sonuc2 = x * y;
        #endregion
        //Aynı türde olan sayısal türler üzerinde işlem yaparken sonuç türü aynı olacaktır.
        #region İnceleme 3
        double s1 = 123;
        double s2 = 321;
        double sonuc3 = s1 + s2;
        #endregion
        #region İnceleme 4
        decimal sayi1 = 123123;
        decimal sayi2 = 3214532;
        decimal sonuc4 = sayi1 % sayi2;
        #endregion
        #endregion
        #endregion
    }
}
