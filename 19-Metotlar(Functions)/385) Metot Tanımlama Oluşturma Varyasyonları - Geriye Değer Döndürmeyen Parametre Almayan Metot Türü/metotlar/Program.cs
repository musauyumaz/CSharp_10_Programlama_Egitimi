namespace metotlar;

class Program
{
    static void Main(string[] args) { }

    //[erişim belirleyici] [geri dönüş değeri] [metot adi](...........)
    //{

    //}
    #region Geriye Değer Döndürmeyen, Parametre Almayan Metot
    private void Metot1()//=> Metot1 isminde bir metot oluşturduk dışarıdan erişilemeyen Metot1 ismindeki bu metot geriye herhangi bir değer dönmüyor ve parametre almıyor. Bu metotla istediğinizi yapabilirsiniz. İçeride istersen `for` döngüsüyle milyonlarca dön `switch - case`ler `try catch`ler artık aklına ne geliyorsa ihtiyacın neyse onu yap. Sadece geriye bir değer döndürmüyor dışarıdan da değer almıyor. 
    {
        System.Console.WriteLine("Geriye Değer Döndürmeyen, Parametre Almayan Metot oluşturuldu");
    } 
    #endregion
}
