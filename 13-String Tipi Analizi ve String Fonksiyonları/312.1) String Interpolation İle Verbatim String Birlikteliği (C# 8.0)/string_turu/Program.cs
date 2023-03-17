namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String Interpolation İle Verbatim String Birlikteliği (C# 8.0)
        string isim = "Musa", soyisim="Uyumaz",siparisNo="123123";
        int fiyat = 150;

        string mailMessage = @$"Merhaba {isim} {soyisim}\n 
        {siparisNo} nolu sipariş talebiliniz tarafımızca alınmıştır.\n
        Fiyat : {fiyat}";
        #endregion
    }
}
