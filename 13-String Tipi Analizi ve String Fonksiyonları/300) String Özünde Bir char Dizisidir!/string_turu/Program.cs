namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String - char Dizisi
        //`string` ifadeler esasında bir `char` dizisidir. Yani yazılım açısından `string` ifade yoktur! Esasında karakterlerin bir araya gelmiş hali vardır. Dolayısıyla karakterleri bir araya getirebilecek yegane şey bir dizidir. `string` ifadeler yazılımsal açıdan bilgisayarda bir `char` dizisi olarak tarif edilmekte ve o şekilde tutulmaktadırlar.
        //`string` ifadeler özünde bir `char` dizisi/yani dizi olmasından dolayı referans türlü değişkenlerdir. Çünkü diziler referans türlüdürler. Yani nesnedirler. yani Heap'te tutulurlar.
        //`string` ifadeler `char` dizisi olduklarından dolayı yapısal olarak her bir karakter baştan sona otomatik indexlenmektedir. Dolayısıyla `string` bir ifade üzerinde bizler indexer operatörünüde(`[]`) kullanabilmekteyiz...
        string metin = "sebepsiz boş yere ayrılacaksan..";

        System.Console.WriteLine(metin[3]);
        System.Console.WriteLine(metin.Length);

        Array array = metin;//`string` özünde bir `char` dizisi olabilir amma velakin yapısal olarak yine de `string` olduğu için `Array` referansına atılamaz `Array` ile karşılanamaz!!!
        #endregion
    }
}
