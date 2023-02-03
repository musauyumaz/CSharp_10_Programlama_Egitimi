namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek 2
        //Hava durumunu tutan string değişkenin değerine göre aşağıdaki önergeleri uygulayan programı yazınız.
        //"Yağmurlu" => "Şemsiye almalısın"
        //"Güneşli"  => "Bol bol d vitamini alman dileğiyle..." 
        //"Kapalı"   => "Yağmur Yağabilir"

        string havaDurumu = "Kapalı";
        System.Console.WriteLine(havaDurumu == "Yağmurlu" ? "Şemsiye almalısın" : (havaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle..." : "Yağmur Yağabilir"));
        #endregion
    }
}
