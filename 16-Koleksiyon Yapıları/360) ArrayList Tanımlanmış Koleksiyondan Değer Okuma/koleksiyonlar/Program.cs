using System.Collections;

namespace koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        #region ArrayList
        int[] yaslar = new int[17];

        ArrayList _yaslar = new ArrayList();

        #region Tanımlanmış Koleksiyondan Değer Okuma
        for (int i = 0; i < 17; i++)
        {
            yaslar[i] = i + 10;
            _yaslar.Add(i + 10);
        }

        //Diziler
        System.Console.WriteLine(yaslar[5]);

        //Koleksiyonlar
        System.Console.WriteLine(_yaslar[5]);

        #endregion
        #endregion
    }
}
