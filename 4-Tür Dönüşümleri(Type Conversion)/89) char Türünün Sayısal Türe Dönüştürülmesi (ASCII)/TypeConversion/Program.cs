namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region char Türünün Sayısal Türe Dönüştürülmesi (ASCII)
        char a = 'a';
        byte _a = (byte)a;
        System.Console.WriteLine(_a);
        #endregion
    }
}
