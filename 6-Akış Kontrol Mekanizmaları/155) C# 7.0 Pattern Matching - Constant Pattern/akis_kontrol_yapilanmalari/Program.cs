namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Constant Pattern
        object x = 123;
        string y = "asasg";
        bool z = true;
        int a = 123;
        System.Console.WriteLine(a is 123);
        if (x is 123) //değersel bazda bir kontroldür.
        {
            
        }
        if (x is int)//Tür babında bir kontroldür.
        {
            
        }

        if (y is "asasg")
        {
            System.Console.WriteLine("y is asasg");
        }
        if (z is true)
        {
            System.Console.WriteLine("z is true");
        }
        if (a is 123)
        {
            System.Console.WriteLine("a is 1235");
        }
        #endregion
    }
}
