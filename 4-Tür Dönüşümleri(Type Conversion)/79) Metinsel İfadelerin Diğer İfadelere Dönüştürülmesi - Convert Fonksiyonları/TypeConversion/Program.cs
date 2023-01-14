namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region Convert Fonksiyonları
        #region Örnek 1
        string x = "25";
        int x2 = Convert.ToInt32(x);
        #endregion
        #region Örnek 2
        string y = "3,14";
        double y2 = Convert.ToDouble(y);
        System.Console.WriteLine(y2 * 5);
        #endregion
        #endregion
    }
}
