namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        string[] personeller = new string[7];
        personeller[0] = "Hilmi";
        personeller[1] = "Hüseyin";
        personeller[2] = "Rıfkı";
        personeller[3] = "Şuayip";
        personeller[4] = "Muiddin";
        personeller[5] = "Naci";
        personeller[6] = "Hüsnü";

        for (int i = 0; i < personeller.Length; i++)
        {
            System.Console.WriteLine(personeller[i]);
        }
    }
}
