namespace akis_kontrol_mekanizmalari;
class Program
{
    static void Main(string[] args)
    {
        #region Senaryo 3
        //Kullanıcıdan alınan iki sayının ve yapılacak işlem türünün (toplama, çıkarma, çarpma, bölme) seçilmesiyle, sonucu hesaplayan programı yazalım.
        #region Çözümüm
        System.Console.Write("Birinci sayıyı giriniz :");
        float sayi1 = float.Parse(Console.ReadLine());
        System.Console.Write("İkinci sayıyı giriniz :");
        float sayi2 = float.Parse(Console.ReadLine());
        System.Console.Write("Yapılacacak İşlem Türünü Seçiniz\n1-Çarpma\n2-Bölme\n3-Toplama\n4-Çıkarma\n:::: ");
        int islemTuru = int.Parse(Console.ReadLine());

        float sonuc = islemTuru switch
        {
            1 => sayi1 * sayi2,
            2 => sayi1 / sayi2,
            3 => sayi1 + sayi2,
            4 => sayi1 - sayi2,
            _ => (float)Math.PI
        };
        System.Console.WriteLine(sonuc);
        #endregion
        #region Hocanın Çözümü
        System.Console.WriteLine("Birinci sayıyı giriniz :");
        int sayi1H = int.Parse(Console.ReadLine());
        System.Console.WriteLine("İkinci sayıyı giriniz :");
        int sayi2H = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Lütfen yapılacak işlem türünü belirtiniz (+, -, *, /)");
        char islemTuruH = char.Parse(Console.ReadLine());
        #region 1. Kritik
        if (islemTuruH == '+')
        {
            System.Console.WriteLine(sayi1H + sayi2H);
        }
        else if (islemTuruH == '-')
        {
            System.Console.WriteLine(sayi1H - sayi2H);
        }
        else if (islemTuruH == '/')
        {
            System.Console.WriteLine(sayi1H / sayi2H);
        }
        // else if (islemTuruH == '*')
        else
        {
            System.Console.WriteLine(sayi1H * sayi2H);
        }
        #endregion

        #region 2. Kritik
        switch (islemTuruH)
        {
            case '+':
                System.Console.WriteLine(sayi1H + sayi2H);
                break;
            case '-':
                System.Console.WriteLine(sayi1H - sayi2H);
                break;
            case '*':
                System.Console.WriteLine(sayi1H * sayi2H);
                break;
            // case '/':
            //     System.Console.WriteLine(sayi1H / sayi2H);
            //     break;
            default:
                System.Console.WriteLine(sayi1H / sayi2H);
                break;
        }
        #endregion

        #region 3. Kritik
        int sonuc = islemTuruH switch
        {
            '+' => sayi1H + sayi2H,
            '-' => sayi1H - sayi2H,
            '*' => sayi1H * sayi2H,
            '/' => sayi1H / sayi2H,
            _ => sayi1H / sayi2H,
        };
        System.Console.WriteLine(sonuc);
        #endregion

        #region 4. Kritik
        System.Console.WriteLine(islemTuruH == '+' ? sayi1H + sayi2H : (islemTuruH == '-' ? sayi1H - sayi2H : (islemTuruH == '*' ? sayi1H * sayi2H : sayi1H / sayi2H)));
        #endregion
        #endregion

        #endregion
    }
}
