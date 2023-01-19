namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        #region Mantıksal Operatörlerin Geriye Dönüş Değeri
        //ve &&
        System.Console.WriteLine(true && true);  //true
        System.Console.WriteLine(true && false); //false
        System.Console.WriteLine(false && true); //false
        System.Console.WriteLine(false && false);//false

        //veya ||
        System.Console.WriteLine(true || true);  //true
        System.Console.WriteLine(true || false); //true
        System.Console.WriteLine(false || true); //true
        System.Console.WriteLine(false || false);//false

        //yada ^
        System.Console.WriteLine(true ^ true);  //false
        System.Console.WriteLine(true ^ false); //true
        System.Console.WriteLine(false ^ true); //true
        System.Console.WriteLine(false ^ false);//false
        //SHIFT + 3 + SPACE

        #region Örnek
        System.Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true));//true
        #endregion
        #endregion
    }
}
