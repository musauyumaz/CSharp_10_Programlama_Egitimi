namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region sizeof Operatörü
        //Verilen türün bellekte kaç byte'lık yer kapladığını `int` olarak geriye döndürür.
        System.Console.WriteLine("int : " + sizeof(int));
        System.Console.WriteLine("long : " + sizeof(long));
        System.Console.WriteLine("decimal : " + sizeof(decimal));
        #endregion
    }
}
