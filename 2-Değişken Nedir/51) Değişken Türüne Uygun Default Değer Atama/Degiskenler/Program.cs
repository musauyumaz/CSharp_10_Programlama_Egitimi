namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        #region Değişken Türüne Uygun Default Değer Atama
        //default keywordü : içerisine verilen türün varsayılan değerini geriye döndürür.
        bool x = default(bool);
        int y = default(int);
        string z = default(string);
        char c = default(char);
        //Main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz.
        // Main içerisinde oluşturduğunuzun ilk değerlerini Compiler kendisi veremez. Class'ta verir
        #endregion
        
    }
}
