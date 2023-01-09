namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Değişkenin Değerini Okuma
        int x = 5;
        //Bir değişkenin değerini elde edebilmek için değişkenin isminden/adından faydalanmaktayız.
        //Bir değişkenin adı assing(`=`) operatörünün sağında yahut metotların parametrelerinde çağırılıyorsa ilgili değişkenin değeri gönderilir.
        System.Console.WriteLine(x);
        int y = x;
        #endregion
    }
}
