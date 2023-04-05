namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Metodun Kullanımı
        //Tetikleme = Çağırma = Kullanım
        #region Tanımlandığı Sınıf İçerisinde Kullanımı
        //Bir metot tanımlandığı sınıf içerisindeki farklı bir metot içerisinden çağırılacaksa eğer tek yapılması gereken sadece isminin çağırılmasıdır/tetiklenmesidir/çalıştırılmasıdır.
        X();
        #endregion
        #region Başka Sınıflarda Kullanımı
            
        #endregion
        #endregion
    }

    static void X()
    {

    }
}

class Ornek
{
    public void A()
    {
        B();
    }

    private void B()
    {
        C(5);
    }
    private int C(int a)
    {
        return a;
    }
}
