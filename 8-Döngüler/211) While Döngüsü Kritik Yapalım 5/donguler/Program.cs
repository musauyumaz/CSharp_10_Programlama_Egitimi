namespace donguler;
class Program
{
    static void Main(string[] args)
    {
        #region İnceleme 5
        //O anki tarihin saniye değeri 5'in katıysa eğer tarihih ekranda gösteren uygulamayı yazalım.

        while (true)
        {
            if (DateTime.Now.Second % 5 == 0)
                System.Console.WriteLine(DateTime.Now);
        }
        #endregion


    }
}
