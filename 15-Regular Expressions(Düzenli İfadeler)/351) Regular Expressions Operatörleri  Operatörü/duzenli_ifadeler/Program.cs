using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        #region ? Operatörü
        //Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.

        //\d{3}B?A
        //234BA, true
        //543BA, true
        //543A,  true 
        //123BBA false

        string text = "234BA";//true
        string text = "123BBA";//false
        Regex regex = new Regex(@"\d{3}B?A");
        Match match = regex.Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
