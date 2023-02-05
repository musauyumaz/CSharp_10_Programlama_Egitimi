namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region ?(Nullable) Operatörü
        //C# programlama dilinde değer türlü değişkenler normal şartlarda null değer alamazlar(Not Nullable)
        //Bir değer türlü değişkenbin null değer alabilmesi için (yani nullable olabilmesi için) ? operatörünün kullanılması gerekmektedir.
        int? a = null;//Bir değer türlü değişkenden ziyade referans türlüymüş gibi hareket edecek ve null değerlerini karşılayabilecek
        bool? b = null;
        System.Console.WriteLine(a);
        System.Console.WriteLine(a is null);
        System.Console.WriteLine(b is not null);

        object sayi = 4;
        int? sayi2 = sayi as int?;
        Console.WriteLine(sayi2);
        //Bir değer türlü değişken nullable yapıldıysa eğer; is null, is not null, as gibi null ile çalışan operatörleri kullanabiliriz.

        #region as Örneklendirme
        object x = 123;
        int? y = x as int?;
        #endregion
        #endregion
    }
}
