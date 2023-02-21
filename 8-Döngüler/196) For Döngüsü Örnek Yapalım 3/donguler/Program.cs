namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek 3
        //Klavyeden girilen sayının faktöriyelini bulan programı yapalım.

        System.Console.WriteLine("Faktöriyelini alacağımız sayıyı girelim.");
        int sayi = int.Parse(Console.ReadLine());
        int faktoriyel = 1;
        #region 1. Çözüm
        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        System.Console.WriteLine("Faktöriyel : " + faktoriyel);
        #endregion
        #region 2. Çözüm
        int faktoriyel = 1;
        string sonuc = "";
        for (int i = sayi; i > 0; i--)
        {
            faktoriyel *= i;
            sonuc += i + (i == 1 ? " = " : " x ");
            if (i == 1)
                sonuc += i + " = ";

            else
                sonuc += i + " x ";


        }
        System.Console.WriteLine("Faktöriyel : " + sonuc + faktoriyel);
        #endregion
        #endregion
    }
}
