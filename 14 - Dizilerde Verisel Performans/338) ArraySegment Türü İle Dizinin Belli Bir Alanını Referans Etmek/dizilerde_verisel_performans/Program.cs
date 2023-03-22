namespace dizilerde_verisel_performans;
class Program
{
    static void Main(string[] args)
    {
        #region ArraySegment İle Dizinin Belli Bir Alanını Referans Etmek
        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);//Dizinin tüm elemanlarını temsil eder.
        ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 2, 5);

        segment1[0] *= 10;
        segment2[0] *= 10;
        #endregion
    }
}
