using System;
namespace hazir_kutuphaneler;
class Program
{
    static void Main(string[] args)
    {
        #region DateTime Struct'ı
        #region AddDays
        System.Console.WriteLine("AddDays : "+DateTime.Now.AddDays(999)); 
        #endregion
        #region AddHours
        System.Console.WriteLine("AddHours : "+DateTime.Now.AddHours(999)); 
        #endregion
        #region AddMicroSeconds
        System.Console.WriteLine("AddMicroSeconds : " + DateTime.Now.AddMicroseconds(999));
        #endregion
        #region AddMilliseconds
        System.Console.WriteLine("AddMilliseconds : "+DateTime.Now.AddMilliseconds(999)); 
        #endregion
        #region AddMinutes
        System.Console.WriteLine("AddMinutes : "+DateTime.Now.AddMinutes(999)); 
        #endregion
        #region AddMonths
        System.Console.WriteLine("AddMonths : "+DateTime.Now.AddMonths(999)); 
        #endregion
        #region AddSeconds
        System.Console.WriteLine("AddSeconds : "+DateTime.Now.AddSeconds(999)); 
        #endregion
        #region AddTicks
        System.Console.WriteLine("AddTicks : "+DateTime.Now.AddTicks(999)); 
        #endregion
        #region AddYears
        System.Console.WriteLine("AddYears : "+DateTime.Now.AddYears(999)); 
        #endregion
        #endregion
    }
}
