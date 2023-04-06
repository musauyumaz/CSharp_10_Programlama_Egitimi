namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Local Functions
        //Bir metot içerisinde tanımlanmış olan metotlardır.
        //C#'ta metotlar sade ve sadece `class` içerisinde tanımlanırlar diye söylemiştik! Halbuki OOP'de göreceğimiz `struct`, `abstract class`, `interface`, `record` yapılanmalarında da metotlar tanımlanmaktadır. Metotlar bu saydıklarımızın dışında KESİNLİKLE başka bir yerde tanımlanamaz!!!
        //Metotlar kesinlikle metotların içerisinde tanımlanamaz demiştik!!! Halbuki C# 7.0'Da gelen Local Function özelliği sayesinde metot içerisinde metot tanımlabilmektedir.
        #endregion
        #region Tanımlama Kuralları
        //1. Erişim belirleyici(Access Modifier) yazılmaz!
        //2. Local Function olarak tanımlanan fonksiyon adı tanımlandığı fonksiyonun adından farklı olmalıdır! Aksi taktirde derleyici hatası VERMEZ!!!
        #endregion
        #region Kullanım Kuralları
        //1. Bir local function sade ve sadece tanımlandığı metodun içerisinde kullanılabilir
        //2. Local function tanımlandığı metodun içerisinde her yerden erişilebilir.
        #endregion
        #region Amacı
        //Local function, sadece tek bir metotta tekrarlı bir şekilde kullanılacak bir algoritamayı/kod parçacığını/işlemi o metoda özel bir şekilde tek seferlik tanımlamamızı ve kullanmamızı sağlamaktadır.
        #endregion
        #region Muadilleri
        //Anonim, Delagate, Func
        #endregion
    }
    public static int X()
    {
        Y();
        void Y()
        {
            System.Console.WriteLine("Merhaba");
        }

        Y();

        return 0;
    }
}
