---
modified: 2023-03-29T10:05:27.404Z
title: 366) C#'da Hazır Sınıflar ve Fonksiyonlar Nedir?
---

***
# 366) C#'da Hazır Sınıflar ve Fonksiyonlar Nedir?
- C#'ta belirli işlemleri hızlı bir şekilde yapmamızı sağlayan hazır fonksiyonlarımız mevcuttur.

- Temelde 2 kategori üzerinde nitelendirebiliriz.
    1. `Math` Sınıfı : Matematiksel metotlar. Örneğin Sin, Cos işlemi
        * Metot fonksiyon nasıl yazılır biliyorsun varsayalım hazır bir yapıya ihtiyaç duymaksızın herhangi bir matematiksel fonksiyonu ortaya koyabilirsin. Ama burada matematik bilmen/matematiğe bağımlılık gerekecek. Böyle bir durumda sadece elindeki bir değerin direkt Tanjantını almak istiyorsan, Logaritmik bir değerini ölçmek istiyorsan ya da karekökünü ya da üssünü almak istiyorsan vs. bunun gibi operasyonlarda matematik bilgisine danışmadan ya da matematikle uğraşmadan direkt sonuç almanı sağlayacak hazır matematik fonksiyonlarımız vardır. 
    2. `DateTime` Struct'ı : Tarih Metotları. Tarihle ilgili işlem yapmamızı sağlayacak fonksiyonlarımız olacak.
        * Tarihle ilgili ekstradan farklı işlem yapmamızı sağlayan iki tarih arasındaki farkı temsil eden 
    3. `TimeSpan` Struct'ı : Tarihle ilgili ekstradan farklı işlem yapmamızı sağlayan iki tarih arasındaki farkı temsil eder.
    4. `Random` Sınıfı : Yeri gelecek algoritmalarda random değerlere ihtiyacımız olabilir rastgele sayı üretmek isteyebiliriz. İşte bu ihtiyaca istinaden sen kendi algoritmanı yazabilirsin rastgele sayı üreten ya da mimaride gelen bu sınıfı kullanabilirsin.

```C#
###Math Sınıfı###
#Abs
#Ceiling
#Floor
#Round
#Pow
#Sqrt
#Truncate

###DateTime Struct'ı###
#Now
#Today
#Compare
#AddDays
#AddHours
#AddMonths
#AddYears
#AddMiliseconds

###TimeSpan Struct'ı###       

###Random Sınıfı###
#Next Fonksiyonu
#NextDouble Fonksiyonu
```

***
# 367) Math Sınıfı - Abs Fonksiyonu
- `Math` sınıfına ihtiyacımız var operasyon yapacaksın herhangi bir işlem yapman lazım matematiksel. Haliyle Math sınıfını önce çağırman lazım ardından ilgili fonksiyonu çağıracaksın.

- Direkt `Math` yazınca gelecektir herhangi bir namespace'i kütüphaneyi using etmeye gerek yok. `System` kütüphanesi altındadır. Bu yüzden using'lere `System` namespace'i eklenmiş olması gerekir. Dolayısıyla varsayılan olarak `System` her daim ekli geleceğinden dolayı yani using edilmiş olarak geleceğinden dolayı `Math`te `System`ın altında bir sınıf olduğundan dolayı direkt hangi C# dosyasında çalışırsanız çalışın direkt gelecektir.

- `Abs` mutlak değer işlemi yapar. Sizin elinizdeki herhangi bir sayısal değerin bu fonksiyon sonunda değeri 0'dan büyük olacaktır. Operasyon olarak bir matematiksel işlemde bir sayısal değeri mutlak değere tabi tutuyorsanız ilgili değeri pozitif olarak geri döndürecektir.

```C#
#Math Sınıfı
#Abs
//Mutlak Değer
//Absolute Value
int i = Math.Abs(5);
int i2 = Math.Abs(-5);
```

***
# 368) Math Sınıfı - Ceiling Fonksiyonu
- Yazılımda matematiğe ihtiyacınız varsa eğer bu matematiği genellikle yuvarlama üzerinden olabilmekte. Yani elinizdeki herhangi bir küsüratlı değeri yuvarlayıp tam sayıya dönüştürmeniz gerekebilir.

- Elimizdeki herhangi bir ondalıklı değeri tam sayıya dönüştürürken yukarıya yuvarlayarak dönüştürür. 

- Parametre olarak `double` ya da `decimal` alabilir ve sonuç olarak bizlere `double` değer verirsek `double`, `decimal` değer verirsek `decimal` döndürür.

```C#
#Math Sınıfı
#Ceiling
System.Console.WriteLine(Math.Ceiling(3.14));
```

***
# 369) Math Sınıfı - Floor Fonksiyonu
- `Ceiling` fonksiyonunun tam tersi olarak elimizdeki herhangi bir küsüratlı sayıyı aşağıya yuvarlamak istiyorsak `Floor` fonksiyonunu kullanabiliriz.

- Parametre olarak `double` ya da `decimal` alabilir ve sonuç olarak bizlere `double` değer verirsek `double`, `decimal` değer verirsek `decimal` döndürür.

```C#
#Math
#Floor
System.Console.WriteLine(Math.Floor(3.14));
```

***
# 370) Math Sınıfı - Round Fonksiyonu
- Elimizdeki ondalık değerin kendisine en yakın olan tam sayıya yuvarlanma işlemini sağlayan bir fonksiyondur. Bu fonksiyon sayesinde siz elinizde bir işlem neticesinde üretmiş olduğunuz ondalıklı değeri herhangi bir kontrole ya da işleme bir iradeye sahip olmaksının en yakın olan tam sayıya direkt yuvarlayabiliyorsunuz.

- Tam ortadayken rastgele tercih yapmaz. Bu bir kabuldür. O bişeyin yarısı tamamına genellemedir. Örneğin birşeyin yarısı yanlışsa tamamı yanlıştır. Matematiksel bir mantık yürüterek tamamına gidebilirsiniz. Yarısına gelmiş bundan sonra gideceği yer üste doğru yukarı doğru yuvarlama işlemini gerçekleştirecektir.

```C#
#Math
#Round
System.Console.WriteLine(Math.Round(3.4));
System.Console.WriteLine(Math.Round(3.5));
System.Console.WriteLine(Math.Round(3.6));
```

***
# 371) Math Sınıfı - Pow Fonksiyonu
- Bazen yazılımsal olarak herhangi bir sayının üssünü almanız gerekebilir. Örneğin 7'nin 9. kuvvetti nedir diye merak ettiğimizde bunun için fonksiyon oluşturmanız gerekecektir. Tabi böyle bir durumda fonksiyon oluşturup bununla ilgili işlemler yapmaktansa matematikteki `Pow` fonksiyonunu kullanabilirsiniz. Direkt üs almanızı sağlayacak olan bir fonksiyondur.

- Sonuç olarak `double` döner çünkü üs alma neticesinde büyük bir değer dönebilir.

```C#
#Math Sınıfı
#Pow
System.Console.WriteLine(Math.Pow(7, 9));
```

***
# 372) Math Sınıfı - Sqrt Fonksiyonu
- Elimizdeki değerlerin 2.dereceden kökünü yani karekökünü almak istiyorsanız `Sqrt` fonksiyonunu kullanabilirsiniz.

```C#
#Math Sınıfı
#Sqrt
System.Console.WriteLine(Math.Sqrt(4));
System.Console.WriteLine(Math.Sqrt(16));
System.Console.WriteLine(Math.Sqrt(55));
```