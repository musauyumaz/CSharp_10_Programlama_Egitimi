namespace metotlar;
class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = new Random().Next();
        }
        foreach (int sayi in sayilar)
        {
            System.Console.WriteLine(sayi);
        }

        //İşlem A

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = new Random().Next();
        }
        foreach (int sayi in sayilar)
        {
            System.Console.WriteLine(sayi);
        }

        //İşlem B

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = new Random().Next();
        }
        foreach (int sayi in sayilar)
        {
            System.Console.WriteLine(sayi);
        }
    }
}
