using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        #region [n] Operatörü
        //`[n]` : Karakter aralığı belirtilebilir.
        //Ayrıca özel karakterlerin yerinde yazılmasınıda ifade eder. 
        
        //\d{3}[A-E]

        string text = "123A";
        string text = "123C";
        string text = "123F";

        //(555) 555 55 55  
        //[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

        string text = "(555) 555 55 55";
        Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
        Match match = regex.Match(text);
        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
