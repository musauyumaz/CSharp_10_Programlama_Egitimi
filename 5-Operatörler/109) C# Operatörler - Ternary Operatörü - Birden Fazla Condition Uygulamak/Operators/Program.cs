namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Birden Fazla Condition Uygulamak
        int yas = 25;
        //Yaşı 25'den büyük olanlara A, 25 olanlara B ve 25'den büyük olanlara C değerini döndüren ternary operatörünü oluşturalım
        string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
        System.Console.WriteLine(sonuc);
        #endregion
    }
}
