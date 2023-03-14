namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region Null - Empty Durumları, Farkları
        
        #region Null
        //Bir değişken/nullable/referans eğer ki `null` alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
        //Arsa Yok!
        //Değer türlü değişkenler `null` alamazlar!
        //`null` alabilen türler sadece referans türlerdir.
        //Değer türlü değişkenlerin `null` alabilmesi için nullable(`?`) olmaları gerekmektedir.

        int? a = null;
        string b = null;
        #endregion
        #region Empty
        //Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. Lakin alan tahsisinde bulunulmuştur.
        //Arsa var lakin ev Yok arsa Boş!
        //Tüm değerler empty atanabilir.
        //Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
        //Default değerlerin olduğu durumlar empty olarak geçer.
        //Empty dendiğinde aklınıza `string` bir değişkene "" değerinin verilmesi gelsin yeter.

        int a = 0;
        bool b = false;
        int[] x = new int[55];
        string a = "";
        string _a = null;
        string a2 = string.Empty;
        #endregion
        #endregion
    }
}
