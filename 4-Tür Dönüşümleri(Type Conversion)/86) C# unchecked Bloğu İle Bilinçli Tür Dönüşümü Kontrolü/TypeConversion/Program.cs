namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {
        #region unchecked
        unchecked
        {
            int a = 500;
            byte b = (byte)a;
            System.Console.WriteLine(b);
        }
        #endregion
    }
}
