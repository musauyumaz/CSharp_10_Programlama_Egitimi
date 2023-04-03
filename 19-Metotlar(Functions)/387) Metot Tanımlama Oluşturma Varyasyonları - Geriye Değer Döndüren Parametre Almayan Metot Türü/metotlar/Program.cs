namespace metotlar;
class Program
{
    static void Main(string[] args)
    {

    }
    #region Geriye Değer Döndüren, Dışarıdan Parametre Almayan Metot
    private char Metot5()//Metot5 isminde dışarıdan erişilemeyen geriye de `char` türünden bir değer döndüren fonksiyon oluşturmuş olduk. Eğer ki bu fonksiyon geriye değer döndüreceğini bildirdiği halde değer döndürmezse hata verir. Aynı şekilde geriye değeri `return` ile döndürdüğümde hata da gidiyor.
    {
        return 'a';
    }
    private int Metot6()
    {
        if (DateTime.Now.Second > 10)
            return 5;

        return 123;

    }
    #endregion
}
