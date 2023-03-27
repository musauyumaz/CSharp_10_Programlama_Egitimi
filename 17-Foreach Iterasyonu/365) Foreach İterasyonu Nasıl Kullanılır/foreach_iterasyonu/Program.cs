namespace foreach_iterasyonu;
class Program
{
    static void Main(string[] args)
    {
        #region Foreach İterasyonu

        ArrayList sayilar = new ArrayList { 123, 123, 325, 2, 534, 5, 345, 345 };

        foreach (object item in sayilar)
        {
            System.Console.WriteLine(item);
        }

        foreach (object item in sayilar)
        {
            sayilar.Add(123123123);
            System.Console.WriteLine(item);
        }
        #endregion
    }
}
