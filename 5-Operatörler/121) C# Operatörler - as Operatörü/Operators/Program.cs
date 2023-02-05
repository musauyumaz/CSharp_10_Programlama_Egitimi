namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region as Operatörü
        //Cast operatörünün UnBoxing işlemine alternatif olarak üretilmiş bir operatördür...
        #region Cast Örneklendirmesi
        // object x = "Ahmet";
        // int x2 = (int)x;
        // System.Console.WriteLine(x2);
        #endregion
        #region as Örneklendirmesi
        object y = "Mehmet";
        Program y1 = y as Program;
        System.Console.WriteLine(y1);
        #endregion
        #endregion
    }
}
