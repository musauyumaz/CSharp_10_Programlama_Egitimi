namespace functions;

class Program
{
    static void Main(string[] args)
    {
        #region Ref Keywordü
        //ref keywordü referanstan gelmektedir.
        //Referans OOP kavramıdır.
        //OOP'de nesneler(object) RAM'de Heap bölgesinde tutulmaktadır.
        //OOP'de referanslar `=` operatörü ile iletişime geçebilmektedirler. Bir referans, işaretlediği herhangi bir nesneyi `=` operatörü sayesinde farklı bir referansa işaretletebilir.
        //Yani referanslar da `=` operatörü neticesinde herhangi bir verisel/nesnesel türeme söz konusu olmamakta, işaretlenmiş nesne diğer referans tarafından işaretlenmektedir.
        //Değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer `ref` keywordü kullanılır!
        //`ref` keywordü, değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur.
        //Değer türlü değişkenlerde shallow copy yapmamızı sağlayan bir keyworddür.

        #region Örnek 1
        int a = 5;
        ref int b = ref a;

        System.Console.WriteLine(b);
        System.Console.WriteLine(a);

        a *= 5;
        System.Console.WriteLine(b);

        b -= 10;
        System.Console.WriteLine(a);
        #endregion

        #region Örnek 2
        int y = 10;
        X(ref y);
        System.Console.WriteLine(y);

        void X(ref int a)
        {
            a = 25;
        }
        #endregion

        #endregion
        #region Ref Returns

        #endregion
    }
}
