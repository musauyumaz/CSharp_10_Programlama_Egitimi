namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region @(Verbatim Strings) Operatörü
        #region 1. Kullanım
        //Bir değişken yahut metot vs. ibi yapılanma isimlerinin programatik bir keyworde karşılık gelmesi mümkün değildir. Derleyici hatası verilir.
        //Eğer ki illa ben bir keyword ismi kullanacağım diyorsan eğer @(Verbatim Strings) Operatörünü kullanabilirsin.
        int @void = 5;
        int @class = 5;
        int @namespace = 5;
        #endregion
        #endregion
    }

    void @void(){


    }
}
