using System.Text.RegularExpressions;

namespace duzenli_ifadeler;
class Program
{
    static void Main(string[] args)
    {
        #region Regular Expressions Operators
        #region \ Operatörü
        // \  : Belirli karakter gruplarını içermesini istiyorsak kullanırız.

        // \D : Metinsel değerlerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir
        // \d : Metinsel değerlerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir.

        // \W : Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiğini bildirir. Alfanümerik karakterler :  a-z A-Z 0-9
        // \w : Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.

        // \S : Metinsel değerin ilgili yerinde boşluk karakterleri(tab/space) dışında herhangi bir karakterin olabileceği belirtilir.
        // \s : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir.

        //Örn;
        //9 ile başlayan 2. karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
        //^9\d\S
        string text = "94 54131563415sfasfasdfasfsafasf";
        Regex regex = new Regex(@"^9\d\S");
        Match match = new Match(text);

        System.Console.WriteLine(match.Success);
        #endregion
        #endregion
    }
}
