namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region is Operatörü
        //Boxing'e tabi tutulmuş değerin öz türünü öğrenebilmek/check edebilmek/kontrol edebilmek için kullanılan bir operatördür.
        //is operatörü denetleme neticesinde durumu bool yani true ya da false olarak döndürür.
        object x = true; //Boxing
        System.Console.WriteLine(x is bool);
        System.Console.WriteLine(x is int);
        System.Console.WriteLine(x is Program);

        //İleride if yapılanmasında vs. çok tercih ettiğimiz bir operatör olacaktır.
        //OOP yapılanmasında polimorfizm `is` operatörüyle kalıtımsal durumlardaki nesnelerin türlerini de öğrenebiceleğiz...
        #endregion
    }
}
