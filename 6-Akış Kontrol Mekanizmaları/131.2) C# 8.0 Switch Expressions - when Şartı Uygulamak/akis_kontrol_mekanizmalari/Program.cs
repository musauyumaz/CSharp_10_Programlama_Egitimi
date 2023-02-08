namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        int i = 10;
        string isim = i switch 
        {
            5 when 3 == 3 => "Hilmi",
            int x when x == 7 && x % 2 == 1 => "Rıfkı",
            10 => "Musa",
            int x => "Hiçbiri"
        };
    }
}
