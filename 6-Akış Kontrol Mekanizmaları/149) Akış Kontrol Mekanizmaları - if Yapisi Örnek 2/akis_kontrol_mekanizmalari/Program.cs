namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Senaryo 2 
        //Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı", yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren Console uygulamasını yapalım"
        #region Çözümüm
        System.Console.Write("Kullanıcı Adı : ");
        string kullaniciAdi = Console.ReadLine();
        System.Console.Write("Şifre : ");
        string sifre = Console.ReadLine();

        if (kullaniciAdi == "Musa" && sifre == "123")
            System.Console.WriteLine("Giriş Başarılı");
        else
            System.Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");

        #endregion
        #region Hocanın Çözümü
        System.Console.WriteLine("Lütfen kullanıcı adınızı yazınız.");
        string kullaniciAdH = Console.ReadLine();
        System.Console.WriteLine("Lütfen kullanıcı adınızı yazınız.");
        string sifreH = Console.ReadLine();

        if (!(kullaniciAdH == "musa" && sifreH == "12345"))
            System.Console.WriteLine("if Else ->"+" Girdiğiniz kullanıcı adı veya şifre hatalıdır.");
        else
            System.Console.WriteLine("if Else ->"+" Giriş Başarılı");

        System.Console.WriteLine(kullaniciAdH == "musa" && sifreH == "12345" ? "Ternary -> "+" Giriş Başarılı." : "Ternary -> "+" Girdiğiniz kullanıcı adı veya şifre hatalıdır.");

        string mesaj = (kullaniciAdH, sifreH) switch
        {
            var x when x.kullaniciAdH == "musa" && x.sifreH == "12345" => "switch expression -> "+" Giriş Başarılı.",
            _ => "switch expression -> "+" Girdiğiniz kullanıcı adı veya şifre hatalıdır."
        };
        System.Console.WriteLine(mesaj);
        #endregion
        #endregion
    }
}
