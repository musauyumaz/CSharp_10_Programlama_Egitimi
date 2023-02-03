namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        #region Cast Operatörü
        //Genellikle tür dönüşümlerine kullanılan bir operatördür.
        //1. Boxing -> Unboxing
        object x = 1;
        int x2 = (int)x;
        //2. Bilinçli Tür Dönüşümü
        int a = 5;
        short b = (short)a;
        //3. char -> int | int -> char (ASCII)
        int ascii = 93;
        char c = (char)ascii;

        char d = 'd';
        int asciiNumber = (int)d;
        //İleride polimorfizm durumunda base class referansıyla işaretlenen bir nesneyi kendi türünde de elde edebilmemizi sağlamaktadır.
        #endregion
    }
}
