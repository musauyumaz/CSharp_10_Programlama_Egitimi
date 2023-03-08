namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        int[] yaslar = new int[3];
        //Normalde yukarıdaki gibi yapılan dizi tanımlası esasında arka planda `Array` sınıfının `CreateInstance` metodunu kullanmaktadır. Bizler de bu metodu kullanarak fonksiyonel diziler oluşturabilmekteyiz.
        Array yaslar2 = Array.CreateInstance(typeof(int),3);
    }
}
