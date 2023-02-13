namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Var Pattern - Kritik
        object x = "asfsadsafasf";
        var b = "asgfassdafsa";
        dynamic c = "aswfasfasfasf";
        if (x is var a)
        {

        }
        #endregion
    }
}
