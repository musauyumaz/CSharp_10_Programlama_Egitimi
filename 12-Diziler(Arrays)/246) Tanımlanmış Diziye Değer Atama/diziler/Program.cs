namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Sınırlılıklar
        //Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamayacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır.
        #endregion

        #region Diziler - Array
        
        int[] yaslar = new int[7];
        yaslar[3] = 10;
        yaslar[2] = 5;
        yaslar[0] = 5;
        // yaslar[15] = 123;//Hata
        #endregion
    }
}
