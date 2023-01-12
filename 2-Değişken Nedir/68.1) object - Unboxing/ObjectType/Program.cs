namespace ObjectType;

class Program
{
    static void Main(string[] args)
    {
        #region UnBoxing
        int yas = 23;
        object _yas = 23;

        #region Casting
        int unBoxingYas =  (int)_yas; //UnBoxing
        System.Console.WriteLine(unBoxingYas * 5);
        #endregion
        #endregion
    }
}
