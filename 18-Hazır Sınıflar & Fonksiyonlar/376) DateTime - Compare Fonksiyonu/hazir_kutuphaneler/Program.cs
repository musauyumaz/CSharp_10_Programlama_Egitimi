using System;
namespace hazir_kutuphaneler;
class Program
{
    static void Main(string[] args)
    {
        #region DateTime Struct'ı 
        #region Compare
        DateTime tarih1 = new DateTime(2022, 01, 01);
        DateTime tarih2 = new DateTime(2023, 01, 01);
        int result = DateTime.Compare(tarih1, tarih2);
        if (result < 0)
            System.Console.WriteLine($"{tarih1} küçüktür {tarih2}");
        else if (result == 0)
            System.Console.WriteLine($"{tarih1} eşittir {tarih2}");
        else
            System.Console.WriteLine($"{tarih1} büyüktür {tarih2}");
        #endregion
        #endregion
    }
}
