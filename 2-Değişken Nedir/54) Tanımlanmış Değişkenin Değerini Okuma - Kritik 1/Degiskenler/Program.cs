﻿namespace Degiskenler;

class Program
{
    static void Main(string[] args)
    {
        #region Tanımlanmış Değişkenin Değerini Okuma
        #region Kritik 1
        int a = 5;
        int b = 10;
        int c = b;
        int d = a;
        b = a;
        c = b;

        #endregion
        #endregion
    }
}
