namespace dizilerde_verisel_performans;
class Program
{
    static void Main(string[] args)
    {
        #region Span Türü
        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Span<int> span = new Span<int>(sayilar);
        Span<int> span2 = sayilar;
        Span<int> span3 = new Span<int>(sayilar, 3, 5);

        Span<int> span4 = sayilar.AsSpan();
        Span<int> span5 = sayilar.AsSpan(3, 5);

        string text = "Sen kalbimde batan güneş, ben yollarda çilekeş...";
        ReadOnlySpan<char> readOnlySpan = text.AsSpan();
        ReadOnlySpan<char> span6 = text;
        #endregion
    }
}
