using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        #region . Operatörü
        //`\n` : Kullanıldığı yerde `\n` karakteri dışında herhangi bir karakter bulunabilir
        //\d{3}.A

        string text = "123'A";
        string text = @"123\nA";
        Regex regex = new Regex(@"\d{3}.A");
        Match match = regex.Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
