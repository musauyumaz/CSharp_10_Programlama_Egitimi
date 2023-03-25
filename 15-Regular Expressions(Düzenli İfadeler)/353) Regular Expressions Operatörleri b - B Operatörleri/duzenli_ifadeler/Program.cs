using System.Text.RegularExpressions;
namespace duzenli_ifadeler;

class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        #region \b \B Operatörleri
        //\B: Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
        //\b: Bu ifade ile ilgili kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar

        //\d{3}dır\B 
        //123dır  false
        //dır123  false
        //123dır2 true

        string text = "123dır";
        string text = "123dır2";
        Regex regex = new Regex(@"\d{3}dır\B ");
        Match match = regex.match(text);

        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
