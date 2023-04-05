namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Optional Parameters(İsteğe Bağlı Parametreler)
        X(15, 20);
        X(15);
        X();
        X(5, 7);
        X(5);

        #region Kritik 1
        //Tüm parametreler opsiyonel olabilir.
        #endregion
        #region Kritik 2
        //Birden fazla parametre içerisinde bir kısmı opsiyonel olabilir mi?
        //Birden fazla parametre durumunda opsiyonel olanlar sağ tarafta TANIMLANMALIDIR!
        X(5, 10, 15);
        X(5,10);
        #endregion
        #endregion
    }

    static public void X(int a, int x, int y, int b = 0, int c = 0)
    {

    }
}
