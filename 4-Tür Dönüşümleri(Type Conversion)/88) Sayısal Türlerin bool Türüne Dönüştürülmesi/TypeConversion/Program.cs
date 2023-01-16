using System;
namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region Sayısal Türlerin bool Türüne Dönüştürülmesi
        //Tür dönüşümlerinde dönüştürülecek türün hedef türe uygun olması gerekiyordu.
        //Burada bir istisna var.
        //normal de;
        //1 -> true
        //0 -> false
        //eşit olması ve geri kalanının mümkün olmaması gerekmektedir. Halbuki burada 0'ın dışındaki tümmmm değerler true olarak kabul edilmesi bir istisnadır.
        #region Örnek 1
        int i = 1;
        bool b = Convert.ToBoolean(i);
        System.Console.WriteLine(b);
        #endregion
        #region Örnek 2
        int j = 0;
        bool c = Convert.ToBoolean(j);
        System.Console.WriteLine(c);
        #endregion
        #region Örnek 3
        int k = 123;
        bool d = Convert.ToBoolean(k);
        System.Console.WriteLine(d);
        #endregion
        #region Örnek 4
        int l = -123;
        bool e = Convert.ToBoolean(l);
        System.Console.WriteLine(e);
        #endregion
        #endregion
    }
}
