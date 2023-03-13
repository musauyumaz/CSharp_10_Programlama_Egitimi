namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Dizi İçerisinde Dizi Tanımlama/Düzensiz Diziler/Dizi Dizileri
        int[][] sayilar = new int[3][];
        sayilar[0] = new int[3] { 3, 5, 7 };
        sayilar[1] = new int[5] { 3, 5, 7, 523, 01 };
        sayilar[2] = new int[10] { 3, 5, 7, 234, 234, 23, 4, 234, 234, 123 };
        
        System.Console.WriteLine(sayilar.Length);//Ana Dizinin eleman sayısı
        //Düzensiz dizinin eleman sayısını getirir. Bu bize total eleman sayısını vermez. Çok boyutlu dizilerde olduğu gibi düzensiz diziler başlı başına farklı bir dizi yapısı değildir.. Normal bir dizi yapılanmasıdır. Lakin içerisinde dizi barındıran bir dizidir. Haliyle eleman sayısını döndürür.
        //İçteki dizilerin eleman sayılarını totalde elde edebilmek için her birini toplamamız gerekmektedir.
        

        System.Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length);//Toplam Eleman sayısı : İçteki dizilerin `Length`lerinin eleman sayısı.
        #endregion
    }
}
