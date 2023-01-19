namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        #region Arttırma Azaltma Operatörleri
        #region Örnek 1
         // ++
        int i = 5;
        i++;
        System.Console.WriteLine(i);
        ++i;
        System.Console.WriteLine(i++); // Çıktı : 5 | Bellek : 6
        System.Console.WriteLine(++i); // Çıktı : 7 | Bellek : 7
        // --
        #endregion
        #region Örnek 2 
        int a = 5;
        int b = a++;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        #endregion
        #region Örnek 3
        int i1 = 5;
        int i2 = ++i1;
        int i3 = i1;
        i2 = ++i2;
        System.Console.WriteLine(i1);
        System.Console.WriteLine(i2);
        System.Console.WriteLine(i3);
        #endregion
        #endregion
    }
}
