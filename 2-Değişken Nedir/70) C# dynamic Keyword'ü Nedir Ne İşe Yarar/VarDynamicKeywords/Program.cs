namespace VarDynamicKeywords;

class Program
{
    static void Main(string[] args)
    {
        #region dynamic
        var a = 5;
        dynamic _a = 5; //derleme aşamasında bu türe bürünemeyeceği için dynamic hala dynamic kalacaktır. Çalıştırma aşamasında runtime'da bürünecektir.
        _a.ToString(); //hala dynamic olduğundan dolayı şu anda türü hala belli olmadığından dolayı herhangi bir member'a/metoda vs. erişememekteyim. Çünkü türünü bilmemektedir.

        System.Console.WriteLine(_a.GetType());
        System.Console.WriteLine(_a * 5); //Sağdakini sayısal verdin sıkıntı yok soldakini ise dynamic verdin bu muhtemelen sayısal olursa ben runtime'da bu işlemi gerçekleştiririm diyor. Sayısal olmaz başka bir türde olursa patlarım diyor. Runtime'da tür belli olacağından dolayı compile aşamasında hata vermiyor.

        //dynamic keywordü runtime'da türü belirleyecektir lakin kararlı davranmayacaktır.
        dynamic x = "Ahmet";
        Console.WriteLine(x.GetType());
        x = 3.14D;
        Console.WriteLine(x.GetType());
        #endregion
    }
}
