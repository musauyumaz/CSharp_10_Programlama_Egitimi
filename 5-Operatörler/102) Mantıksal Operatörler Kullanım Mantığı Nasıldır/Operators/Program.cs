namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Mantıksal Operatörlerin Kullanım Mantığı
        bool patetes = true, kofte = false;
        bool sonuc1 = patetes && kofte;
        bool sonuc2 = patetes || kofte;
        bool sonuc3 = patetes ^ kofte;

        System.Console.WriteLine(sonuc1);
        System.Console.WriteLine(sonuc2);
        System.Console.WriteLine(sonuc3);
        //Mantıksal operatörler  geriye bool/mantıksal sonuçlar dönerler...
        #endregion
    }
}
