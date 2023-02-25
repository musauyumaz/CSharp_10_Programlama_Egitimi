namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region Sonsuz Döngü - Do While
        bool durum = true;
        do
        {
            if (true)
            {
                durum = !durum;
            }
        } while (durum);
        #endregion
    }
}
