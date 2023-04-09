namespace functions;

class Program
{
    static void Main(string[] args)
    {
        #region Out Keyword
        //OUTPUT parametre barındıran bir metodu kullanırken `out` parametrelerden gelecek olan değerleri karşılayacak değişkenler tanımlanmalıdır!
        #region Kullanım 1
        int _b = 0;
        string _d = "";

        int a = X(out _b, 123, out _d);
        #endregion
        #region Kullanım 2
        int a = X(out int _b, 123, out string _d);
        System.Console.WriteLine(_b);
        System.Console.WriteLine(_d);
        #endregion

        int X(out int b, int c, out string d)
        {
            //Bir metot `out` parametre(ler) barındırıyorsa o parametrelere kendi içerisinde değer atanması gerekmektedir! Aksi taktirde derleyici hatası alınacaktır.
            b = 25;
            d = "ahmet";
            return 0;
        }

        #region TryParse
        string s = "123";
        if (int.TryParse(s, out int r)) { }
        else { }
        #endregion
        #endregion
    }
}
