namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        int number = 111;
        string result = number switch
        {
            < 50 => "50'den küçük",
            > 50 => "50'den büyük",
            _ => "50'ye eşit",
        };
        System.Console.WriteLine(result);
    }
}
