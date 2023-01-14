namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        #region Metinsel İfadelerin Diğer İfadeler Dönüştürülmesi
        //Tür dönüşümlerinde dikkat edilmesi gereken tek bir husus vardır ki, o da ; dönüşüm yapılacak verinin türüne uygun bir hedef tür belirlenmelidir.
        #region Parse Metodu
        //Parse metodu sadece string dataları hedef türe dönüştürürken kullanılır!
        #region Örnek 1
        string x = "123";
        // System.Console.WriteLine(x * 5);
        short x2 = short.Parse(x);
        System.Console.WriteLine(x2 * 5);
        System.Console.WriteLine(short.Parse(x) * 5);
        #endregion
        #region Örnek 2
        //TÜr HATALI
        string a = "Ahmet";
        int a2 = int.Parse(a);
        System.Console.WriteLine(a2);
        #endregion
        #region Örnek 3
        string medeniHal = "Evli";
        bool medeniHal2 = bool.Parse(medeniHal);
        System.Console.WriteLine(medeniHal2);
        #endregion
        #region Örnek 4
        string v = "ab";
        char v2 = char.Parse(v);
        #endregion
        #endregion
       
        #region Convert Fonksiyonları
            
        #endregion
        #endregion
    }
}
