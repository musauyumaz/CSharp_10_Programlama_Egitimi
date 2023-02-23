namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region İnceleme 4
        //Klavyeden girilen sayının faktöriyelini hesaplayalım.
        int sayi = int.Parse(Console.ReadLine());
        int faktoriyel = 1;
        while (sayi > 0)
        {
            faktoriyel *= sayi--;
            // sayi--;
        }
        #endregion
    }
}
