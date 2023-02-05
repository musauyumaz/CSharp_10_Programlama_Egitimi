namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region ??= Operatörü (Null Coalescing Assignment) (C# 8.0)
        string x = null;
        System.Console.WriteLine(x ??= "Merhaba");
        System.Console.WriteLine(x);

        int? id = null;
        id ??= 1;//id null ise 1 değerini ata, yok eğer değilse değerini koru...
        #endregion
    }
}
