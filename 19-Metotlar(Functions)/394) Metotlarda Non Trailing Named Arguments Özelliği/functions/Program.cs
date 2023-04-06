namespace functions;
class Program
{
    static void Main(string[] args)
    {
        #region Non-Trailing Named Arguments
        X(3, 5, "abc");
        X(c: "abc", a: 5, b: 15);

        //Hangi parametreye hangi değerlerin gönderildiğini direkt görebilmek için bu özelliği kullanırız.
        //Göreceli bir şekilde çok parametreli fonksiyonlarda hedef parametrelere değer göndermemizi sağlayan bir özelliktir.
        #endregion
    }
    static void X(int a, int b, string c)
    {

    }
}
