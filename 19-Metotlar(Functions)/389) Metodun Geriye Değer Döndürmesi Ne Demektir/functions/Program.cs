namespace functions;
class Program
{
    static void Main(string[] args)
    {
        int sonuc = Topla(3, 5);
        if (sonuc > 10)
        {
            System.Console.WriteLine("Sonuç 10'dan büyük");
        }
        bool sonuc2 = PersonelEkle("Rıfkı","Cümbül",25);
        if(sonuc2)
        {

        }else
        {
            
        }
        #region Metodun Geriye Değer Döndürmesi Ne Demektir?

        #endregion
    }
    
    static public bool PersonelEkle(string adi,string soyadi,int yas)
    {
        if(yas>= 20)
        {
            //....Veritabanına eklendi
            return true;
        }else
        {
            System.Console.WriteLine("Personel 20'den küçük olamaz!");
            return false;
        }
    }
    static public int Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        System.Console.WriteLine(sonuc);//Burada ekrana yazdırdığın değer bu metodun döndürdüğü değer değil.
        return sonuc;
    }



}
