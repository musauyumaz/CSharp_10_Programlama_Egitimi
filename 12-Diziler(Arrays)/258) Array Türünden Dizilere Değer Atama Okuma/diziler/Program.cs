namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Array Türünden Dizilere Değer Atama / Okuma

        Array dizi = new int[3];

        #region 1. Yöntem
        int[] dizi = new int[3];
        dizi[0] = 30;
        dizi[1] = 31;
        dizi[2] = 32;
        Array dizi2 = dizi;
        #endregion
        #region 2. Yöntem
        Array dizi = new int[] { 3, 5, 7, 9 };
        Array dizi = new int[4] { 3, 5, 7, 9 };
        Array dizi = new[] { 3, 5, 7, 9 };
        Array dizi = { 3, 5, 7, 9 };//KULLANILAMAZ //Bu varyasyon maalesef ki kullanılamaz.
        #endregion
        #region 3. Yöntem
        Array dizi = new int[3];
        dizi.SetValue(30,0);
        dizi.SetValue(31,1);
        dizi.SetValue(32,2);

        object value = dizi.GetValue(1);
        Console.WriteLine(value);
        #endregion
        #endregion
    }
}
