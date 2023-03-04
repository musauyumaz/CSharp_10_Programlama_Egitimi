namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        #region Diziler - Array
        
        int[] yaslar = new int[7];
        yaslar[3] = 10; 
        yaslar[2] = 5; 
        yaslar[0] = 5; 
        yaslar[5] = 123; 

        System.Console.WriteLine(yaslar[3]);
        System.Console.WriteLine(yaslar[6]);
        System.Console.WriteLine(yaslar[7]);
        #endregion
    }
}
