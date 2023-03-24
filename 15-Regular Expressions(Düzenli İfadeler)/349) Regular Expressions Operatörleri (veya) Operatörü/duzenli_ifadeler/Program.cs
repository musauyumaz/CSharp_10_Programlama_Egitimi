using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region | Operatörü
        //Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksal veya operatörü kullanılır.

        //Baş harfi a ya da b ya da c olan metinsel ifadeyi girelim
        //a|b|c
        string text = "ahmet";
        Regex regex = new Regex(@"a|b|c");
        Match match = regex.Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
    }
}
