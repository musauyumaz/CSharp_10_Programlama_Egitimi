namespace string_turu;

class Program
{
    static void Main(string[] args)
    {
        #region String Fonksiyonları
        string metin = "laylaylom galiba sana göre sevmeler...";

        #region Split
        //Metinsel ifadeyi verilen değeri ayraç olarak kullanıp, parçalayan ve sonucu `string` dizisi olarak döndüren bir fonksiyondur.
        string[] dizi = metin.Split(' ');
        string[] dizi = metin.Split(' ', 'a');
        #endregion
        #endregion
    }
}
