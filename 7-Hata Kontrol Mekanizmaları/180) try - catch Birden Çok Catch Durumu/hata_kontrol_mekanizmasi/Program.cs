namespace hata_kontrol_mekanizmasi;
class Program
{
    static void Main(string[] args)
    {
        #region Birden Çok Catch Durumu
        try
        {
            int s1 = 0, s2 = 10;
            int a = s2 / s1;//DivideByZeroException

            int.Parse("asasfsadasfsaf");//FormatException
        }
        catch (DivideByZeroException ex)//DivideByZeroException hatası alındığında bu hatayı karşılayacak olan catch haline getirilmiş oldu...
        {

        }
        catch (FormatException ex)//FormatException hatası alındığında bu hatayı karşılayacak olan catch haline getirilmiş oldu...
        {

        }
        catch (Exception ex)
        {

        }

        #endregion
    }
}
