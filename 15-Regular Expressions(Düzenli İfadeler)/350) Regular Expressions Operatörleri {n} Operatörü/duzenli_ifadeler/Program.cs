using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region {n} Operatörü
        //Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli.

        //555-5555555
        //\d{3}-\d{6}
        string text = "555-5555555";
        Regex regex = new Regex(@"\d{3}-\d{7}$");
        Match match = regex.Match(text);
        System.Console.WriteLine(match.Success);
        #endregion
    }
}
