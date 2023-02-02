namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Ternary Operatörü 
        //Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür.

        bool medeniHal = true;
        string mesaj = medeniHal == true ? "Evlilere Kampanya...." : "Bekarlara Kampanya....";
        System.Console.WriteLine(mesaj);
        #endregion
    }
}
