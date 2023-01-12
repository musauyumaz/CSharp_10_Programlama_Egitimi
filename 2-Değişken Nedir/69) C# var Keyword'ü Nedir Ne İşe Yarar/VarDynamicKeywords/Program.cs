namespace VarDynamicKeywords;
class Program
{
    static void Main(string[] args)
    {
        #region var
        string adi = "Musa";

        var x = 3.14F; 
        //var keywordüyle tanımlanan değişkenin değeri tanımlanma aşamasında verilmelidir. Verilmelidir ki türü belirleyip direkt ona dönüşebilsin o türde davranış sergileyebilsin...
        //var keywordüyle tanımlanan değişkene ilk değer verildikten sonra o değerin türüne bürüneceği için sonraki durumlarda değeri farklı türlerde verilemez!!!
        //var - object arasındaki farkı;
       //var bir keyword iken object ise bir türdür. var atanan değerin türüne bürünürken, object atanan değeri Boxing yaparak object'te dönüştürür.
        #endregion
    }
}
