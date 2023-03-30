---
modified: 2023-03-30T10:08:10.390Z
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

*** 
# 373) Math Sınıfı - Truncate Fonksiyonu
- Bazen matematiksel işlemler neticesinde üretmiş olduğumuz ondalıklı değerlerin sadece tam sayısını elde etmek isteyebiliriz. Bakın burada dikkat etmeniz gereken nokta şu elinizdeki ondalıklı değeri tam sayılara yuvarlamak değil sadece elindeki değerin tam sayı kısmını elde etmek isteyebilirsin. Yani `Ceiling`, `Round`, `Floor` ile yapmış olduğumuz değilde yani sadece yuvarlama yapmadan ilgili tamsayı değerini elde etmek istiyorsan `Truncate`i kullanabilirsin.

```C#
#Math
#Truncate
System.Console.WriteLine(Math.Truncate(3.14));
```

***
# 374) DateTime - Now Özelliği
- Bir yazılımda en çok kullanılan hazır fonksiyonlar nedir derseniz eğer `string` fonksiyonlarından sonra `DateTime` fonksiyonları diyebiliriz.

- `Now` şimdiki zamanı döndüren şimdi, o an o kodun tetiklendiği andaki zamanı milisaniyeye kadar döndüren bir property'dir. Property dışarıdan parametre almaz sadece sana değer döndürür.

```C#
#DateTime Struct'ı
#Now
System.Console.WriteLine(DateTime.Now);
```

***
# 375) DateTime - Today Özelliği
- `Today` property'si ise tetiklendiği andaki tarih bilgisini getirir. `Now` property'si tetiklendiği an tarih zaman bilgisini getirirken `Today` sadece tarih bilgisini getirir.

```C#
#DateTime Struct'ı
#Today
System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine(DateTime.Today);
```

***
# 376) DateTime - Compare Fonksiyonu
- Yazılım süreçlerinde iki tarihsel değer arasında karşılaştırma yapma ihtiyacı hissedebiliriz. Dolayısıyla bu ihtiyaca istinaden `Compare` fonksiyonunu da kullanabiliriz.

- `Compare` fonksiyonu vermiş olduğumuz iki tarihi kıyaslayarak sonuç olarak `int` bir değer döndüren fonksiyondur.

- `Compare` fonksiyonu -1, 0, 1 değerlerini döndürür.
    * -1 ise ilk değer ikinci değerden küçük yani geride bir zaman
    * 0 ise iki değerde eş zaman
    * 1 ise ilk değer ikinci değerden büyük yani ileri bir zaman.

```C#
#DateTime Struct'ı 
#Compare
DateTime tarih1 = new DateTime(2022, 01, 01);
DateTime tarih2 = new DateTime(2023, 01, 01);
int result = DateTime.Compare(tarih1, tarih2);
if (result < 0)
    System.Console.WriteLine($"{tarih1} küçüktür {tarih2}");
else if (result == 0)
    System.Console.WriteLine($"{tarih1} eşittir {tarih2}");
else
    System.Console.WriteLine($"{tarih1} büyüktür {tarih2}");
```

***
# 377) DateTime - Tarihsel Zamana Saat, Gün, Ay, Yıl Ekleyerek Sonucu Hesaplamak
- `DateTime` fonksiyonları arasında en çok kullanacağımız fonksiyonlardan diğerleri ise `Add` fonksiyonlarıdır. Elimizdeki herhangi bir tarihsel zamanın üzerine filanca gün eklediğimizde şu kadar zaman eklediğimizde hangi tarih oluşuyor vs. gibi sormak istiyorsak bunu bu fonksiyonlarlar gerçekleştirebiliriz.

- Bu fonksiyonlar operasyonlar inanılmaz bizim işimize yarıyor çünkü yeri gelecek bazı token'ları falan kontrol etmeniz gerekecek. Bunlar senin için önemli. Buradaki tarihin zamanını bildirebilmek elindeki bir yapının ne kadar bir ömre sahip olduğunu oraya ifade edebilmek için bu fonksiyonları kullanırız. Mesela bunun ömrü şimdiden itibaren 5 dk geçerlidir demek için kullanılır.

```C#
#DateTime Struct'ı
#AddDays
System.Console.WriteLine("AddDays : "+DateTime.Now.AddDays(999)); 
#AddHours
System.Console.WriteLine("AddHours : "+DateTime.Now.AddHours(999)); 
#AddMicroSeconds
System.Console.WriteLine("AddMicroSeconds : " + DateTime.Now.AddMicroseconds(999));
#AddMilliseconds
System.Console.WriteLine("AddMilliseconds : "+DateTime.Now.AddMilliseconds(999)); 
#AddMinutes
System.Console.WriteLine("AddMinutes : "+DateTime.Now.AddMinutes(999)); 
#AddMonths
System.Console.WriteLine("AddMonths : "+DateTime.Now.AddMonths(999)); 
#AddSeconds
System.Console.WriteLine("AddSeconds : "+DateTime.Now.AddSeconds(999)); 
#AddTicks
System.Console.WriteLine("AddTicks : "+DateTime.Now.AddTicks(999)); 
#AddYears
System.Console.WriteLine("AddYears : "+DateTime.Now.AddYears(999)); 
```

***
# 378) TimeSpan Türü İle İki Tarih Farkının Karşılanması
- İki tarih arasındaki farkı `TimeSpan` türüyle karşılayabilirsiniz. İki `DateTime` arasındaki farkı `-` operatörünü kullanarak alabilirsiniz.

- Operatör Overloading dediğimiz işlem var. Biz operatörleri farklı türlerde de `class` yapılarında nesneler üzerinde vs işlem yapabilir hale getiriyoruz. Yani onlara ekstradan çoklu yükleme yapabiliyoruz.

```C#
#TimeSpan Struct'ı
DateTime t1 = DateTime.Now;
DateTime t2 = new DateTime(2000,1,1);
TimeSpan span = t1 - t2;
System.Console.WriteLine(span.Days);
System.Console.WriteLine(span.Minutes);
```

***
# 379) Random Sınıfı - Next Fonksiyonu
- `Random` ile operasyon yapabilmek için bir nesne üretmemiz gerekecektir.

- `Random` adı üstünde rastgele sayısal değer oluşturmamızı sağlayan bir sınıftır.

- Algoritmalarda böyle değerlere bazen ihtiyacımız olacaktır.

- `Random` sınıfının dışında farklı mimaride de sınıflar var rastgele sayı oluşturmanızı sağlayan.

- `Random` sınıfında belirli bir aralıkta tam sayısal değer oluşturmak istiyorsanız `Next` fonksiyonunu kullanabilirsiniz.

- `Random.Next();` 0 ile `Integer.MaxValue` arasında değer üretecektir.
- `Random.Next(100);` 0 ile 100 arasında değer üretecektir.
    * Max değer aralığını belirtebilirsiniz.
- `Random.Next(50,100);` 50 ile 100 arasında değer üretecektir.
    * Min ve Max değer aralığını belirtebilirsiniz.

- Belirttiğiniz Minimum değer dahilken Maximum değer dahil değildir.

- Sayısal değerlerde sadece pozitif değerleri size döndürecektir. Negatif değer üretmeyecektir. Eğer ki negatif değere ihtiyacın varsa üretilen değeri -1 ile çarpabilirsin.

```C#
#Random Sınıfı
#Next Fonksiyonu
Random random = new Random();
System.Console.WriteLine(random.Next()); //0 - ....
System.Console.WriteLine(random.Next(100)); //0 - 100
System.Console.WriteLine(random.Next(50, 100)); //50 - 100
```

***
# 380) Random Sınıfı - NextDouble Fonksiyonu
- `NextDouble` Fonksiyonu ile `Random` sınıfımız 0 ile 1 arasında rastgele bir sayı üretir.

- Bu sayıların mükerrer olma ihtimali çok düşüktür.

```C#
#Random Sınıfı
#NextDouble Fonksiyonu
Random random = new Random();
while (true)
    System.Console.WriteLine(random.NextDouble());
```