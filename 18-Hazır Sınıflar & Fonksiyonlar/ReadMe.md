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