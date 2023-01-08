namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        #region (_a, _b) = (a, b) Tuple Türüyle Değer Atama
        int a = 5;
        int b = 10;

        (int x,int y) c = (5,10);
        (int yas,string adi,bool medeniHal) kisi = (23,"Musa",true);
        kisi.yas = 5;

        (int x,char y) z;

        z = (5, 'a');
        #endregion
    }
}
