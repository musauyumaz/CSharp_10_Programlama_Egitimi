namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {
        #region Checked
        int a = 123;
        byte b = (byte)a;
        System.Console.WriteLine(b);
        checked
        {
            int c = 500;
            byte d = (byte)c;
            System.Console.WriteLine(d);
        }
        #endregion
    }
}
