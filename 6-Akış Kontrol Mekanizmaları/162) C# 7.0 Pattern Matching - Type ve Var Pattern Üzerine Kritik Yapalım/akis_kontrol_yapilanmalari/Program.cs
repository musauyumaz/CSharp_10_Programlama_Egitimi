namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        object x = 123;
        if (x is string a)
        {

        }
        if (x is var b)
        {

        }

        bool result = x is string o1;
        System.Console.WriteLine(o1);

        bool result2 = x is var o2;
        System.Console.WriteLine(o2);
    }
}
