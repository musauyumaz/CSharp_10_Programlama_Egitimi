using System.Collections;
namespace koleksiyonlar;
class Program
{
    static void Main(string[] args)
    {
        #region ArrayList

        #region ArrayList Kullanırken Boxing - Unboxing Durumları
        ArrayList _yaslar = new ArrayList();

        for (int i = 0; i < 17; i++)
        {
            _yaslar.Add(i);
        }

        //`ArrayList`, verilen datayı boxing işlemine tabi tutar. 
        //`ArrayList` içerisindeki herhangi bir veriyi talep ettiğimizde o veri `object` olarak gelecektir. Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir.

        int toplam = 0;
        for (int i = 0; i < _yaslar.Count; i++)
        {
            toplam += (int)_yaslar[i];
        }
        
        #endregion
        #endregion
    }
}
