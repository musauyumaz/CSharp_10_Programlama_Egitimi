namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region IsNullOrEmpty
        //Elimizdeki `string` ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.

        string x = "";//Empty
        // string x = string.Empty;//Empty
        // if (x != "")
        // if (x != string.Empty && x != null)
        if (x != string.Empty && x is not null)
        {
            //Operasyon...
        }

        //IsNullOrEmpty fonksiyonu; elimizdeki `string` ifadenin `null` yahut empty olup olmama durumları hakkında bir check yapar ve geriye `bool` türde sonuç döner.
        //Eğer ki `null` ya da empty ise geriye `true` değilse `false` dönecektir.
        if (!string.IsNullOrEmpty(x))
        {
            //Operasyon...
        }
        #endregion
    }
}
