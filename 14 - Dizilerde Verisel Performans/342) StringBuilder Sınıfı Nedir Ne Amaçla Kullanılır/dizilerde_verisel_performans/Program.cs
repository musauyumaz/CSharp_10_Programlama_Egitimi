using System.Text;

namespace dizilerde_verisel_performans;
class Program
{
    static void Main(string[] args)
    {
        #region StringBuilder Sınıfı
        //`StringBuilder` `string` birleştirme operasyonlarında `+` operatörüne nazaran yüksek maliyeti absorbe edebilmek için arka planda `StringSegment` algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek ennn az maliyetle birleştirip döndüren bir sınıftır.

        string isim = "Musa";
        string soyisim = "Uyumaz";
        System.Console.WriteLine(isim + soyisim);

        StringBuilder builder = new StringBuilder();
        builder.Append(isim);
        builder.Append(" ");
        builder.Append(soyisim);
        System.Console.WriteLine(builder.ToString());
        #endregion
    }
}
