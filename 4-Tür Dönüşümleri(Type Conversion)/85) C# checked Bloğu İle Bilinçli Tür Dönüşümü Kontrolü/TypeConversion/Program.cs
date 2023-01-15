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
            int a = 500;
            byte b = (byte)a;
            System.Console.WriteLine(b);
        }
        #endregion
    }
}
