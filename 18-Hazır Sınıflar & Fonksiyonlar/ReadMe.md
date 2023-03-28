---
modified: 2023-03-28T02:11:54.404Z
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