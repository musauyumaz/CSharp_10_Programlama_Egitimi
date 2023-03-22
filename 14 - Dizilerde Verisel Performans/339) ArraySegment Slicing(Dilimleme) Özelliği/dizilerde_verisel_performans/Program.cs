namespace dizilerde_verisel_performans;
class Program
{
    static void Main(string[] args)
    {
        #region ArraySegment Slicing(Dilimleme)
        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        //Bir dizi üzerinde birden fazla parçada çalışılacaksa eğer her bir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz. Bu tanımlamaların dışında diziyi tek bir ArraySegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz . Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz. Bu durumda bize yazılımsal açıdan yani kodun gelişimi açısından efektiflik kazandırmış olacaktır.
        ArraySegment<int> segment = new ArraySegment<int>(sayilar);
        ArraySegment<int> segment1 = segment.Slice(0, 3);
        ArraySegment<int> segment2 = segment.Slice(4, 7);
        ArraySegment<int> segment3 = segment.Slice(5, 10);
        #endregion
    }
}
