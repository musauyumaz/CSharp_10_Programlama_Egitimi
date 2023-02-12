namespace akis_kontrol_yapilanmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Type Pattern
        object x = "Musa";
        if (x is string a)//C# 7.0'dan itibaren artık if şart bloğu içine direkt değişken ismi belirleyebiliyoruz. Tabi bu değişken ismi öncekilerle çakışmayacak bir değişken ismi olmalı ve anlamlı olmalı.
        {//Type pattern diyor ki eğer bu objectin içindeki değer string ise ben bunu a'ya cast eder sana string olarak veririm diyor. Hiç içeride cast yapmaya ihtiyacın yok
            // string _x = (string)x;// Önceden bu şekilde erişim sağlıyorduk yani kendimiz cast operatörüyle birlikte değişkene atıyorduk
            System.Console.WriteLine(a);
            //a değişkeni scope içerisinde if scope'u içerisinde tanımlanmamıştır.
        }
        else if (x is int b)
        {
            
        }
        #endregion

        a = "agasgasgasg";
        System.Console.WriteLine(a); //a if scope'u içerisinde tanımlanmadığı için ben a'ya erişebiliyorum. Amma velakin burada hata verecektir. 
        //Biz Type pattern'da tanımlanan değişkenlere manuel olarak dışarıdan erişebiliyoruz.
    }
}
