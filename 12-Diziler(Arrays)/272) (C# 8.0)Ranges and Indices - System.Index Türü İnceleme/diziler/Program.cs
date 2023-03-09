using System;

namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Ranges and Indices
        int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };

        // Index index = 5; //--> Soldan 0 - (n - 1)
        Index index = ^8; //--> Sağdan n - 1
        System.Console.WriteLine(sayilar[index]);
        #endregion
    }
}
