using Microsoft.Extensions.Primitives;

namespace dizilerde_verisel_performans;
class Program
{
    static void Main(string[] args)
    {
        string text = "Ölüme gidelim dedin de mazot mu yok dedik.";

        #region StringSegment İle Dizinin Belli Bir Alanını Referans Etmek 
        //`StringSegment` türünü kullanabilmek için uygulamaya Microsoft.Extensions.Primitives paketinin yüklenmesi gerekmektedir.
        StringSegment segment = new StringSegment(text);
        StringSegment segment1 = new StringSegment(text, 2, 5);
        System.Console.WriteLine(segment1);
        #endregion
    }
}
