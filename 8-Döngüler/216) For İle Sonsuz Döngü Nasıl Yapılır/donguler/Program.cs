namespace donguler;

class Program
{
    static void Main(string[] args)
    {
        #region Sonsuz Döngü - for
        for (int i = 0; true; i++) { } //i değeri int'in değer aralığını aşarsa patlar Bu yüzden sonsuz döngü olmaz.
        for (; true; ) { } //for sonsuza gider
        for (; ; ) { } //for'un sonsuz döngü varyasyonu

        bool dongu = true;
        for (; dongu; )
        {
            if (true)
            {
                dongu = !dongu;
            }
        }

        #endregion
    }
}
