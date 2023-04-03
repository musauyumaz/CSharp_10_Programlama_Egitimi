using System;
namespace metotlar;
class Program
{
    static void Main(string[] args)
    {

    }
    #region Geriye Değer Döndüren, Parametre Alan Metot

    public bool Metot7(int x)
    {
        return true || false;
    }

    public int Metot8(int x)
    {
        return DateTime.Now.Year > 2000 ? 1 : 0;
    }
    #endregion
}
