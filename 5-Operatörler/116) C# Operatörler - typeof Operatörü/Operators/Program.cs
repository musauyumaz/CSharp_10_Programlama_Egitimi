namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region typeof Operatörü
        //typeof operatörü verilen türün/değerin type'ını/türünü getirir.
        //O tür ile ilgili bilgileri deinmek için kullanılan bir operatördür.
        //İleride(İleri Düzey Programlama da) reflection dediğimiz bir konuda elimizdeki bir türün reflection'ına girmek için kullanıldığını göreceğiz.
        Type t = typeof(int);//int türüne ait tümmm bilgiler t değişkenine atanmıştır.
        System.Console.WriteLine(t.Name);
        System.Console.WriteLine(t.IsPrimitive);
        System.Console.WriteLine(t.IsClass);
        System.Console.WriteLine(t.IsValueType);
        #endregion
    }
}
