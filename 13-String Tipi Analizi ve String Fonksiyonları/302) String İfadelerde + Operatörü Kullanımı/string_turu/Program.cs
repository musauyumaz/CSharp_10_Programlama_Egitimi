namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String İfadelerde + Operatörü
        //`string` ifadelerde `+` operatörü kullanılabilmektedir.
        //İki `string` ifade arasında birleştirme görevi görür.
        //Bir `string` ifade ile herahngi bir tür `+` operatörüyle işleme tabi tutulabilir.
        //`+` operatörü `string` bir ifadeyle  herhangi bir türdeki ifadeleri işleme tabi tutarken `object` + `string` olarak davranış sergileyecek ve sonuç olarak geriye `string` değer döndürecektir.
        //Dolayısıyla herhangi bir ifadeyi `string`e dönüştürebilmek için o ifadeyi `+ ""` işleme tutmak yeterli olabilir.
        string a = "merhaba", b = "dünya";
        System.Console.WriteLine(a + b);

        int a2 = 5;

        var c = a + a2;

        System.Console.WriteLine(5 + 7 + 20 + "ahmet");
        System.Console.WriteLine(5 + 7 + 20 + "ahmet" + 84 + 78 + 95);
        #endregion
    }
}
