namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        int s1 = 10;
        int s2 = 20;

        string mesaj = (s1, s2) switch
        {
            (5, 10) when (true) => "5 ile 10 değerleri",
            var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 değerleri"
        };
        System.Console.WriteLine(mesaj);
    }
}
