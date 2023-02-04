namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region default Operatörü
        //Belirtilen türün default değerini döndüren bir operatördür...
        //Default değer ne demektir? Default değerler, her tür için yazılım tarafında tanımlanmış bir varsayılan değer demektir.
        //sayısal = 0
        //bool = false
        //string = null
        //char = \0
        //referans = null

        System.Console.WriteLine(default(decimal));
        System.Console.WriteLine(default(string));
        System.Console.WriteLine(default(Program));
        System.Console.WriteLine(default(short));
        System.Console.WriteLine(default(byte));

        int a1 = default;
        int a2 = default(int);
        #endregion
    }
}
