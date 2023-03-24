using System.Text.RegularExpressions;
namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        //`^` Operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.

        //^9 : 
        //Uygun : 9asfafdas, 9414156, 9''!3123, 
        //Uygun değil : asfasfsaf, 123, 1239, 0912312

        string text = "9212347123asadgagfakmgag";

        Regex regex = new Regex("^91");//Burada değer 91 ile başlamalı eğer başlamıyorsa `false` dönecektir.
        Match match = regex.Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
    }
}
