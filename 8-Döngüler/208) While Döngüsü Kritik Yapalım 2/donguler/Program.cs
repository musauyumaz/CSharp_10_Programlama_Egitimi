namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region İnceleme 2
        //Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım.
        int sayi = int.Parse(Console.ReadLine());

        while (sayi >= 0)
        {
            //sayi--;
            System.Console.WriteLine(sayi);// Bu senaryoda 
            sayi--;
        }

        #endregion
    }
}
