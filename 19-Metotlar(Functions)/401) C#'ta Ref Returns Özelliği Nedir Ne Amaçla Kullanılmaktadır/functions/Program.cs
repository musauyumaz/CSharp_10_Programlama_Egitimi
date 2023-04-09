namespace functions;

class Program
{
    static void Main(string[] args)
    {
        #region Ref Returns
        //ref returns özelliği sadece metotlarda geçerlidir.
        //Metotlar geriye değer döndürebilen yapılardır. Ayrıca metotlarda geriye nesnelerde döndürebilmekteyiz. Ayrıca ref returns özelliği sayesinde değer türlü değişkenlerin referanslarınıda geriye döndürebilmekteyiz.

        #region Örnek 1

        int a = 5;
        int b = X(ref a);
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);

        ref int X(ref int y)
        {
            y = 25;
            return ref y;
        }
        #endregion
        #endregion
    }
}
