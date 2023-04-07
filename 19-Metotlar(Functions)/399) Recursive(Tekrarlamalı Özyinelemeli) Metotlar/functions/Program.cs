namespace functions;
class Program
{
    static void Main(string[] args)
    {
        //Recursive Fonksiyon : Kendi içerisinde kendisini çağıran/tetikleyen fonksiyonlardır.
        //Özyinelemeli/Tekrarlamalı Fonksiyon

        //Recursive fonksiyonlar bir yaklaşımdır!

        //Anlaşılması, kullanması ve anlatılması zordur!

        //Recursive Fonksiyonlar ne amaçla kullanılmaktadır?
        //Öngörülemeyen, derinliği tahmin edilemeyen, sonu bilinmeyen durumlarda tercih edilebilir.

        //Döngülerin kullanıldığı her noktada recursive fonksiyonlar kullanılabilir. Amma velakin recursive fonksiyonların kullanıldığı her yerde döngü KULLANILAMAZ!!!

        // X();
        // System.Console.WriteLine(Topla(0, 50));
        List<FileInfo> files =  DosyaYazdir("");
        foreach (FileInfo file in files)
        {
            System.Console.WriteLine(file.FullName);
        }
    }

    // static void X(int a = 1)
    // {
    //     System.Console.WriteLine(a + ". Merhaba");
    //     if (a < 3)
    //     {
    //         X(a++);
    //     }

    // }
    // void X(int a = 1)
    // {
    //     System.Console.WriteLine("Merhaba");
    //     if (a < 7)
    //     {
    //         X(++a);
    //     }
    //     System.Console.WriteLine("Dünya");
    // }

    #region Örnek 1
    //Belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan recursive fonksiyonu yazalım.

    static int Topla(int baslangic, int bitis)
    {
        if (baslangic % 5 == 0)
            return baslangic + Topla(++baslangic, bitis);
        if (baslangic <= bitis)
            return Topla(++baslangic, bitis);
        return 0;
    }

    #endregion
    #region Örnek 2
    List<FileInfo> DosyaYazdir(string path)
    {
        List<FileInfo> fileInfos = new();

        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

        if (directoryInfos.Any())
            foreach (DirectoryInfo directory in directoryInfos)
                DosyaYazdir(directory.FullName);
        else
            fileInfos.AddRange(directoryInfo.GetFiles());

        return fileInfos;


    }
    #endregion

}
