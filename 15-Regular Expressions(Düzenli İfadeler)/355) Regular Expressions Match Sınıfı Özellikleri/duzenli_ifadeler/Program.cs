using System.Text.RegularExpressions;
namespace duzenli_ifadeler;

class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        
        string text = "(555) 555 55 55";
        Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}$");
        Match match = regex.Match(text);

        System.Console.WriteLine($"Success :  {match.Success}");
        System.Console.WriteLine($"Value :  {match.Value}");
        System.Console.WriteLine($"Index :  {match.Index}");
        System.Console.WriteLine($"Length :  {match.Length}");
        // System.Console.WriteLine($"Text :  {match.Text}");
        #endregion
    }
}
