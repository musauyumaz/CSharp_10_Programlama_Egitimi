namespace hazir_kutuphaneler;
class Program
{
    static void Main(string[] args)
    {
        #region TimeSpan Struct'ı
        DateTime t1 = DateTime.Now;
        DateTime t2 = new DateTime(2000,1,1);

        TimeSpan span = t1 - t2;
        System.Console.WriteLine(span.Days);
        System.Console.WriteLine(span.Minutes);
        #endregion
    }
}
