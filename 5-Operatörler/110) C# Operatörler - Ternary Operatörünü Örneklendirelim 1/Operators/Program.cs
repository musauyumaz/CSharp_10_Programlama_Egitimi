namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek 1
        //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.
        // sayı < 3                   => sayı * 5
        // sayı > 3 && sayı < 9       => sayı * 3
        // sayı >= 9 && sayı % 2 == 0 => sayı * 10
        // sayı % 2 == 1              => sayı
        // Hiçbiri değilse            => -1
        System.Console.Write("Sayı Giriniz : ");
        // string sayi = Console.ReadLine();
        // int _sayi = int.Parse(sayi);
        int sayi = int.Parse(Console.ReadLine());// Console.ReadLine() => Kullanıcının girdiği değeri string olarak getiren/yakalayan bir komuttur. Console.ReadLine komutu kullanicinin console'dan bir değer girmesini bekler.
        // int sonuc = sayi < 3 ? sayi * 5 : (sayi > 3 && sayi < 9 ? sayi * 3 : (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : sayi));
        int sonuc = sayi < 3 ? sayi * 5 : (sayi > 3 && sayi < 9 ? sayi * 3 : (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : sayi % 2 == 1 ? sayi : -1));
        System.Console.WriteLine("Sonuç : " + sonuc);
        #endregion
    }
}
