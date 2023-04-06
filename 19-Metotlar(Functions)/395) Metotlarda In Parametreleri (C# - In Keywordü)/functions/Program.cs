namespace functions;
class Program
{
    static void Main(string[] args)
    {
        //1. Parametrenin değerini metodun içerisinde herhangi bir yerde çağırıp kullanabiliriz.
        //2. Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz. Yani parametreni değerini değiştirebiliriz (Çünkü parametreler özünde bir değişkendir.)
        #region In Parameters
        //`in` komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
        //`in` komutu, metodun parametresini readonly(Sadece okunabilir) hale getirir.
        //`in` komutunun kullanıldığı eğer ki metot içerisinde farklı bir assign durumu söz konusu olursa derleyici hatası verecektir.
        #endregion
    }
    static void X(in int a, int b, in char c)
    {
        a = 123;
        b = 5;
        c = 'a';
    }
}
