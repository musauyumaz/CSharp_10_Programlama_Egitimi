namespace string_turu;
class Program
{
    static void Main(string[] args)
    {
        #region String - char Dizisi

        string metin = "sebepsiz boş yere ayrılacaksan...";

        for (int i = 0; i < metin.Length; i++)
        {
            if (metin[i] == 'e')
                System.Console.WriteLine(i);
        }
        int i = 0;
        do
        {
            if (metin[i] == 'e')
                System.Console.WriteLine(i);
            i++;
            
        } while (i < metin.Length);
        #endregion
    }
}
