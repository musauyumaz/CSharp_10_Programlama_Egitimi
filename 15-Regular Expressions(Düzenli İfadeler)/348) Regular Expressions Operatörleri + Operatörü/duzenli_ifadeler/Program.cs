using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        
        #region + Operatörü
        //Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılan operatördür.
        //9 ile başlayan arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
        //^9\d+\S
        // string text = "1987454511d";false
        // string text = "9a7454511d";false
        // string text = "9874a54511d";true
        // string text = "9874 54511d";true
        // string text = "98 54511d";false
        string text = "98 54511d";
        Regex regex = new Regex(@"^9\d+\S");
        Match match = regex.Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
