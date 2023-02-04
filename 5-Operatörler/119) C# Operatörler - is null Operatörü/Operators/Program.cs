namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region is null Operatörü
        //Bir değişkenin değerinin null olup olmamasını kontrol eden ve sonuç olarak bool döndüren bir operatördür.
        string a = null;
        System.Console.WriteLine(a is null);

        //is null operatörünü sadece null olabilen türlerde kullanabilmekteyiz.
        int b = null;
        System.Console.WriteLine(b is null);
        #endregion
    }
}
