namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Başka Sınıfta Tanımlanmış Bir Metodun Kullanımı
        Matematik matematik = new Matematik();//Burada matematik referansı ile Matematik nesnesini işaretlemiş olduk. matematiği her kullandığın yerde Matematik nesnesini kullanmış olacaksın. 
        //Artık başka bir sınıftaki memberlara/elemanlara/fonksiyonlara/property'lere/field'lara erişilebilir hale getirmiş olduk.
        //Program farklı bir sınıf Matematik farklı bir sınıf. Bunlar birbirleri için öteki. Erişim belirleyicisi bir sınıfın içerisindeki herhangi bir fonksiyonu o sınıfın dışındaki öteki sınıflardan erişilebilir olup olmamasını ayarlayan özel keywordlerdir. Bir sınıftaki fonksiyonu farklı bir sınıf içerisinde kullanmak istiyorsan ilgili fonksiyonun bulunduğu sınıfta `public` olması gerekiyor. İlgili fonksiyonun tanımlaması `public` olarak tanımlanmış olması gerekiyor.
        System.Console.WriteLine(matematik.Carp(3, 5));  
        #endregion
    }
}

class Matematik
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }

    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    public int Bol(int sayi1, int sayi2)
    {
        return sayi1 / sayi2;
    }
}
