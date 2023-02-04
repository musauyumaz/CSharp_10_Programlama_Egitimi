namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region is not null Operatörü
        //Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool döndürmektedir.
        string a = null;
        System.Console.WriteLine(a is not null);

        //Sadece null alabilen türlerde kullanılabilir.
        #endregion
    }
}
