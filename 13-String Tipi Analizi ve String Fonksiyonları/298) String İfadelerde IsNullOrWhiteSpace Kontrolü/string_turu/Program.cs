namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region IsNullOrWhiteSpace
        // `IsNullOrWhiteSpace` fonksiyonu: Elimizdeki `string` ifadenin `null`, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye `bool` `true` değerini döndüren bir fonksiyondur.

        string x = "sebepsiz boş yere ayrılacaksan";
        // string x = "   ";
        // string x = "";
        // string x = string.Empty;
        // string x = null;
        if (!string.IsNullOrWhiteSpace(x))
        {
            //Operasyon...
        }

        #endregion
    }
}
