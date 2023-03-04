namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme - Kritik 1
        string[] personeller = new string[15];
        personeller[0] = "Hilmi";
        personeller[1] = "Hüseyin";
        personeller[2] = "Rıfkı";
        personeller[3] = "Şuayip";
        personeller[4] = "Muiddin";
        personeller[5] = "Naci";
        personeller[6] = "Hüsnü";
        // personeller[7] = "Nurullah";
        // personeller[8] = "Cabbar";
        // personeller[9] = "Akif";
        // personeller[10] = "Ayşe";
        // personeller[11] = "Fatma";
        // personeller[12] = "Nuriye";

        for (int i = 0; i < personeller.Length; i++)
        {
            System.Console.WriteLine(personeller[i]);
        }
        #endregion
    }
}
