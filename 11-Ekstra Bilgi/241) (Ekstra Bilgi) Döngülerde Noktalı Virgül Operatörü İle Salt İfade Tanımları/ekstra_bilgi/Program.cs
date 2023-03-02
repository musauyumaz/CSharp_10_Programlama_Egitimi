namespace ekstra_bilgi;
class Program
{
    static void Main(string[] args)
    {
        #region Döngülerde Boş Scope Kullanmak İstemediğimiz Durumlarda ;(Noktalı Virgül Operatörü İle Temiz Kod Yazımı) 

        while (true)
        {

        }
        while (true) ;


        for (; ; )
        {

        }

        for (; ; );

        do
        {

        } while (true);

        do;
        while (true);

        #endregion
    }
}
