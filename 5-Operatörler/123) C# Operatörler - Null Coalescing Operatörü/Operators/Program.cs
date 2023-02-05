namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region ??(Null Coalescing) Operatörü
        //Elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür.
        string a = "Ahmet";
        System.Console.WriteLine(a ?? "Merhaba");
        System.Console.WriteLine(a == null ? "Merhaba" : a);

        System.Console.WriteLine(a ?? 3);
        //Sol ve sağdaki türler birebir aynı olmalıdır. Aksi taktirde derleyici hata verecektir...
        #endregion
    }
}
