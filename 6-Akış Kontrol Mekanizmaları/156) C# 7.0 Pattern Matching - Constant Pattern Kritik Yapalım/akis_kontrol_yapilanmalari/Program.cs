namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        //is operatörü bir değişkenin türünü sormamızı/belirlememizi sağlayan bir operatördür ve bu operatörün kullanıldığı değişkenlerin türü illa bir referans türlü olmak zorunda değildir.
        //İsterseniz değer türlü değişkenlerde de is operatörü kullanılabilmektedir ve hatta primitive türlerde bile kullanılabilmektedir...

        int a = 5;
        System.Console.WriteLine(a is int);
        System.Console.WriteLine(a is string); //Buradakiler ise normal `is` operatörünün kendi fıtratındaki işlemdir.
        System.Console.WriteLine(a is bool);

        System.Console.WriteLine(a is 5); //Eğer ki is operatörüyle bir değişkenin değerini == operatörünün sorsumluluğuyla check ediyorsak işte buna Constant pattern denmektedir...
        System.Console.WriteLine(a is "5");
        System.Console.WriteLine(a is "asasgsafasfa");
        System.Console.WriteLine(a is false);
    }
}
