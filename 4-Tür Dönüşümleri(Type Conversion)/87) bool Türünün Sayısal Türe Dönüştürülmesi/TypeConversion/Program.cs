using System;
namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region bool Türünün Sayısal Türe Dönüştürülmesi
        //Elimizdeki mantıksal bir değeri herhangi bir sayısal değere convert edersek ilgili değerin mantıksal karşılığını elde edebiliriz...
        #region Örnek 1
        bool b = true;
        int i = Convert.ToInt32(b);
        System.Console.WriteLine(i);
        #endregion
        #region Örnek 2
        bool c = false;
        long l = Convert.ToInt64(c);
        System.Console.WriteLine(l);
        #endregion
        #endregion
    }
}
