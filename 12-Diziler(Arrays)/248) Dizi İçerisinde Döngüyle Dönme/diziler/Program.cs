namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme

        string[] personeller = new string[10];
        personeller[0] = "Hilmi";
        personeller[1] = "Hüseyin";
        personeller[2] = "Rıfkı";
        personeller[3] = "Şuayip";
        personeller[4] = "Muiddin";
        personeller[5] = "Naci";
        personeller[6] = "Hüsnü";
        personeller[7] = "Nurullah";
        personeller[8] = "Cabbar";
        personeller[9] = "Akif";


        #region Ameleus 
        System.Console.WriteLine(personeller[0]);
        System.Console.WriteLine(personeller[1]);
        System.Console.WriteLine(personeller[2]);
        System.Console.WriteLine(personeller[3]);
        System.Console.WriteLine(personeller[4]);
        System.Console.WriteLine(personeller[5]);
        System.Console.WriteLine(personeller[6]);
        System.Console.WriteLine(personeller[7]);
        System.Console.WriteLine(personeller[8]);
        System.Console.WriteLine(personeller[9]);
        #endregion

        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine(personeller[i]);
        }

        int i = 0;
        do
        {
            System.Console.WriteLine(personeller[i++]);
        } while (i < 10);
        #endregion
    }
}
