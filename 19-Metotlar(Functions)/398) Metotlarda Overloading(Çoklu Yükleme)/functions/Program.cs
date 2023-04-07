namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Method Overloading(Çoklu Yükleme)
        //Overloading : Çoklu Yükleme
        //Bir `class` içerisinde belirli kurallar çerçevesinde aynı isimde birden fazla metot oluşturmaya Method Overloading denir.

        Random random = new Random();
        random.Next();

        Matematik matematik = new Matematik();
        matematik.Topla(2, 5);
        matematik.Topla(2, (byte)5, 1, 2);

        #region Overloading Kuralları
        //Bir sınıf içerisinde birden fazla aynı isimde metot tanımlayabilmek için şu kurallara dikkat edilmesi gerekmektedir.
        //Metot Overloading işlemini yapabilmek için metotların isimleri aynı olmalıdır.
        //Bu metotlar içerisinde fark yaratmamız gerekmektedir.
        //Bu fark bizzat metot imzalarında OLMALIDIR!
        //Metotlar arasında farkı yaratırken erişim belirleyicileri ve geri dönüş değerleri aktif rol oynamamaktadır.
        //Parametre sayıları ya da parametre türleri farklı olmalıdır.
        #endregion
        #endregion

        //Overloading işlemine tabi tutulmuş metotlardan istediğimizi kullanabilmek için o metodun imzasına uygun parametreleri tetiklememiz(ya da bir başka deyişle o imzadaki metodu kullanmamız) yeterli olacaktır.
    }
}
class Matematik
{
    //Bir class içerisinde aynı isimde birden fazla metot tanımlanamaz
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Topla(int sayi1, double sayi2)
    {
        return (int)(sayi1 + sayi2);
    }
    public int Topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }
    public int Topla(int sayi1, double sayi2, int sayi3, int sayi4)
    {
        return (int)(sayi1 + sayi2 + sayi3 + sayi4);
    }

    public int Topla(int sayi1, byte sayi2, int sayi3, int sayi4)
    {
        return sayi1 + sayi2 + sayi3 + sayi4;
    }
}