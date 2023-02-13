namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Var Pattern - Kritik
        object x = "asfsafsafsaf";
        var b = "faassafafasf";
        if (x is var a)//x'in türü her neyse x'in değerini burada cast edip a'ya vereceğinden dolayı bu işlemi runtime'da yapacaktır. Runtime'de türü belirlenecektir.
        {
            
        }
        #endregion
    }
}
