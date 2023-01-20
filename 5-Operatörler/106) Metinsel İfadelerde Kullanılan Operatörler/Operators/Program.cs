namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Metinsel İfadelerde Operatörler
        #region + Operatörü
        // Metinsel ifadeler + operatörüyle yanyana birleştirilebilirler.
        int a = 5, b = 3;
        System.Console.WriteLine(a + b);

        string c = "Ahmet", d = "Mehmet";
        System.Console.WriteLine(c + d);

        int e = 5;
        string f = "abc";
        System.Console.WriteLine(e+f);
        #endregion
        #region += Operatörü
        string g = "ahmet";
        string h = "mehmet";
        
        g = g + h;
        System.Console.WriteLine(g);
        g += h;
        #endregion
        #region == Operatörü
        string i ="Ahmet";
        string j = "Mehmet";
        bool sonuc1 = i == j;

        bool sonuc2 = i != j;
        #endregion
        #endregion
    }
}
