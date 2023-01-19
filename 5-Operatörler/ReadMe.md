***
# 92) Programlamada Operatör Nedir?
- Yazılımda en önemli yapıtaşlarından biridir.

- Operatörler temel anlamda bir işin sorumluluğunu üstlenen temel yapıtaşlarıdır.

- Bir işin sorumluluğunu üstlenen, sorumluluk alan bir operasyon gerçekleştiren yapılanmalardır.

- Diyelim ki toplama işlemi yapacağız. Biz toplamayı yaparken `+` operatörünü kullanıyoruz. Yazılımda `+` operatörü benim yerime toplama işlemini gerçekleştiren bu sorumluluğunu üstlenen bir değerdir/yapıdır. Nasıl ki `+` ile birşeyleri toplayabiliyorsam diğer operatörlerle belirli işlemleri belirli sorumlulukları gerçekleştirebilmekteyiz. Bu işlemler bu sorumluluklar türlü türlü farklı farklı sorumluluklar olabilir. Bunlara uygun metinsel ya da direkt sembolik operatörlerimiz vardır.

- Operatörler belirli bir sorumluluğu/işi/operasyonu üstlenen sembolik yahut metinsel yapılardır.

- Bizim yerimize o sorumluluğu icra ederler...

- Nasıl ki bir inşaatta o inşaatla ilgili çalışmayı yapan kepçenin kullanıcısı operatörse ne yapıyor benim yerime oradaki işi yapıyor. Buradaki de benim yerime toplamayı yapıyor, kontrolleri yapıyor gerekli dönüşüm işlemlerini yapıyor vs falan aklına ne gelirse yapıyor.

- Operatör dediğimi,z yapının teknik boyutuna girdiğimizde operatörleri kullanırken bir operatör okur yazarlığı gerekiyor.

- Operatör bir işi benim yerime yapan görevlidir/operasyoncudur/operasyonu yürüten işçidir.

- Nasıl ki karakollarda planlamayı yapanlar stratejisyenlerse operasyonu genellikle özel harekatlar yapıyor. İşte özel harekatlar orada operatörler oluyor. Sorumluluğu üstlenen/yapan oradaki stratejik kararda olması gereken işi yapanlar özel harekatsa bizim de yazılımdaki özel harekatlarımız operatörlerimizdir.

- Belirli bir işe ihtiyacın var örneğin 1 arttırman gerekiyor orada `++` operatörünü kullanacaksın senin yerine 1 arttırıyor gibi

- Mesela `null` kontrolü yapacaksın orada `?` operatörü gelecektir.

- Farklı şekilde yapabileceğin uzun uzun yapacağın işlemleri kısaca yapmanı sağlayan sembolik yahut metinsel değerlere operatörler diyoruz.

<img src="1.png" width="auto">

***
# 93) Programlamada Operatör Okur Yazarlığı
- Herhangi bir operatör genellikle sağındaki ve solundaki değerler üzerinde bir bağıntı oluşturur. Bu operatör aritmetik olabilir mantıksal olabilir ya da herhangi bir işleyişi sorumluluğu üstlenen operatörde olabilir. 

- Operatör dediğin genellikle iki değer arasına konulur ve bu iki değer arasında işlem yapan bir yapıdır.

- Oepratörler genellikle iki değer arasında matematiksel, matıksal yahut farklı bir işlemsel görev/operasyon yapan yapılardır.

- İki değer arasına sen bir operatör yerleştirdiysen o yerleştirdiğin operatörün mahiyetine göre sonuç olarak bir işlem yapacaktır. Bir sonuç dönecektir sana

- Operatörler genellikle yaptıkları işlem neticesinde bir sonuç dönerler. Dönülen sonucu sen alıp başka bir işlemde de kullanbilirsin. Örneğin
    * 3 + 5 Burada `+` operatörü 3 ile 5'i toplar ve sonuçta 8 değerini döndürüyor.

- Operatörleri kullanırken geriye dönüş değerlerine dikkat edilmesi gerekmektedir. Özellikle aritmetik operatörlerde dikkat edilmelidir.

- Bir operatör işlem yaparken geriye ne döndürüyor bu çok önemli buna dikkat etmezseniz eğer ezbere kod yazmış olursunuz.

- Operatör Türleri
    * Aritmetik Operatörler
    * Karşılaştırma Operatörleri
    * Mantıksal Operatörler
    * Diğer/Özel İşlem Operatörler

<img src="2.png" width="auto">

***
# 94) C# Aritmetik Operatörler Neledir? Geriye Dönüş Değeri Nedir?
- Aritmetik operatörler `+`,`-`,`*`,`/`,`%` olmak üzere 5 tanedir.

- Aritmetik operatörlerin geriye dönüş değerleri vardır.

- Aritmetik operatörler iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesinde geriye 'uygun türde' sonuç dönerler.

- `int sonuc = 3 + 5;` `+` operatörü diyor ki : Soluma ve sağıma vermiş olduğun iki `int` tür üzerinde ben bir işlem yaparım. Bu işlem neticesinde sana sonucu da `int` döndürürüm.
- `int sonuc2 = x * y;` `*` operatörü diyor ki : Soluma ve sağıma vermiş olduğun değerler üzerinde ben bir işlem yaparım kombinasyon uygularım. Bu işlem neticesinde sana sonucu da `int` döndürürüm.

- Aritmetik operatörlerde işlem yaparken hangi türlerde çalışıyorsanız o türlerde sonuç döner.

- Aynı türde olan sayısal türler üzerinde işlem yaparken sonuç türü aynı olacaktır.

```C#
Aritmetik Operatörler
// +
// -
// *
// /
// %
Aritmetik Operatörler Geriye Dönüş Değeri
//Aritmetik operatörler iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesinde geriye 'uygun türde' sonuç dönerler.

int sonuc = 3 + 5;


int x = 3,
    y = 5;
// int y = 5;
int sonuc2 = x * y;

//Aynı türde olan sayısal türler üzerinde işlem yaparken sonuç türü aynı olacaktır.

double s1 = 123;
double s2 = 321;
double sonuc3 = s1 + s2;


decimal sayi1 = 123123;
decimal sayi2 = 3214532;
decimal sonuc4 = sayi1 % sayi2;

```

<img src="3.png" width="auto">

***
# 95) Aritmetik Operatörlerde Kritik Yapalım 1
- İki farklı türde sayısal değerler üzerinde yapılan aritmetik işlem neticesinde sonuç büyük olan türde dönecektir.

- Elinde diyelim ki `int` değer var ve birde `short` değer var yapmış olduğun işlem netice olarak `short`'un kapsam alanını geçebilir. O yüzden aritmetik işlemlerde sayısal türler birbirinden farklıysa varsayılan olarak büyük olan baz alınır. Yani sonuç olarak büyük olan türde sonuç dönecektir.

<img src="4.png" width="auto">

- Aritmetik operatörler kapsam alanı küçük olan türü kapsam alanı büyük olan türe bilinçsiz bir şekilde dönüştürülerek o şekilde hesap yapılır... O yüzden sonuç büyük olan türde elde edilecektir/edilmektedir.

<img src="5.png" width="auto">

```C#
(int) * (double)
//İki farklı türde sayısal değerler üzerinde yapılan aritmetik işlem neticesinde sonuç büyük olan türde dönecektir.
int s1 = 10;
double s2 = 5;
double sonuc = s1 + s2;
```
- Burada senin verdiğin `int`'i bakmış ikisine de demiş ki ulan `double` `int`den daha büyük o zaman ben `int`i dönüştürüyorum ve `int` olan değeri `double` mış gibi algılıyorum yani orada bilinçsiz tür dönüşümü yapıyorum sonucu da `double` döndürüyorum.

***
# 96) Aritmetik Operatörlerde Kritik Yapalım 2
- `byte` ile herhangi bir sayısal tür örneğin `int` ile yapılan sayısal işlemi ele aldığımızda kapsam alanı büyük olan yani `int`'de sonuç dönmesini bekliyoruz.

- Genel prensibimiz iki farklı türdeki sayısal değerler kendi aralarında aritmetik işleme tabi tutuluyorsa sonuç kapsam alanı büyük olanın türünde dönecektir.

```C#
(byte) * (int) = ?
int s1 = 3;
byte s2 = 123;
int sonuc = s1 - s2;
```

***
# 97) Aritmetik Operatörlerde Kritik Yapalım 3(Mülakat Sorusu)
- Aynı türlerdeki sayısal değerler üzerinde yapılan herhangi bir aritmetik işlem neticesinde sonuç aynı türde döner.

- Amma velakin iki `byte` arasında yapılan sayısal/aritmetik işlemlerde sonuç her daim `int` olarak dönecektir. 

- Normalde iki aynı türdedeki sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç aynı türde dönecekken, bu iki değer `byte` ise sonuç her daim `int` dönecektir. Böyle kabul edilmiştir... İstisnadır...

```C#
(byte) * (byte) = ? (İstisna! - Mülakat!!!)
byte s1 = 10;
byte s2 = 5;
int deger = s1-s2;
System.Console.WriteLine(deger);
```

<img src="6.png" width="auto">

***
# 98) C#'da Matematiksel İşlemlerde Öncelik Sırası Nasıldır?
- Matematiksel kuralların hepsi programlama da geçerlidir.  

- İşlem öncesi dediğimiz kanunlar kurallar parantez mevzuları aynen birebir yazılımda da geçerli olacaktır.

- Matematik prensipleri programlama da %100 geçerlidir.

***
# 99) C# Karşılaştırma Operatörleri Nelerdir?
- İki sayısal değer arasında büyüklük, küçüklük ve eşitlik durumuna göre karşılaştırma yapan ve sonuç dönen operatörlerdir.

- Ayriyeten metinsel değerlerde de eşitlik durumunu kontrol edebiliriz.

- Karşılaştırma operatörlerimiz;
    * `<` (küçüklük) Soldaki ifade sağdakinden küçük mü? `x < y`
    * `>` (büyüklük) Soldaki ifade sağdakinden büyük mü? `x > y`
    * `<=` (küçük veya eşitlik) Soldaki ifade sağdakinden küçük mü veya eşit mi? `x <= y`
    * `>=` (büyük veya eşitlik) Soldaki ifade sağdakinden büyük mü veya eşit mi? `x >= y`
    * `==` (eşitlik) Soldaki ifade sağdakine eşit mi? `x == y`

<img src="7.png" width="auto">

***
# 100) Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri Nedir?
- Karşılaştırma operatörleri sayısal değerler arasında yahut metinsel ifadelerde de iki değer birbirleriyle karşılaştırılıyorsa geriye `boolean` türde yani `true` ya da `false` döndürecektir.

- Karşılaştırma operatörleri geriye her daim bool türde bir değer döndürecektir.

```C#
Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri
//Karşılaştırma operatörleri geriye her daim bool türde bir değer döndürecektir.
int i1 = 123;
int i2 = 321;
bool sonuc = i1 > i2;
```

***
# 101) C# Mantıksal Operatörler Nelerdir?
- Yazılım sürecinde kod yazarken algoritmalar oluştururken genellikle çok kullandığımız o algoritmadaki mantık boyutlarında olmazsa olmaz diyeceğimiz operasyonlarımız operatörlerimiz mantık operatörleridir.

- Belirli şartların durumunu değerlendirip kendine göre sonuç döndüren operatörlerdir. Ve, Veya, Ya da operatörleridir.

- Günlük hayatta beşeri hayatta biz bunları kullanıyoruz Yani kullanış dilimizde var. Birilerinden bişey isterken birilerine talimat verirken ya da aldığımız emirleri yerine getirirken oradaki Ve, Ya da Veya ya dikkat ediyoruz.

- Tüm şartları değerlendirip kendine göre sonuç döndüren operatörlerdir.

- Ve veya'dan farklı kendine göre farklı şekilde değerlendirir. Veya bambaşka durumları değerlendirir.

- ve(`&&`) operatörü, tümmm şartların yerine getirilmiş olmasını isterrrr. 
    * Anne bana mutfaktan patates ve köfte getir dedin. Şimdi annen sana patates ve köfteyi getirirse ve mantığına göre hem patatesin gelmesi gerekecek hem de köftenin gelmesi gerekecek Eğer ki bu ikisinden biri ya da ikisi de gelmezse sen razı olmazsın.
    * İkiside geldiği sürece iki koşul/şart doğrulandığı yerine getirildiği sürece ve doğrulanmış olacaktır.

- veya(`||`) operatörü, şartlardan en az bir tanesinin yerine getirilmiş olması yeterlidir.
    * Anne bana mutfaktan patates veya köfte getirir misin dedin. Şimdi annen sana ya patatesi getirebilir ya da köfteyi getirebilir sen razı olursun tamahkarsın yani sıkıntı yok patatesi de getirebilir, ikisini de getirebilir, köfteyi de getirebilir, sıkıntı yok ama en az bir tanesinin gelmesine razısın.
    * İki şarttan en az bir tanesinin sağlanması gerekmektedir.

- yada(`^`) operatörü şartlardan kesinlike bir tanesinin yerine getirilmesini isterr...
    * Diyelim ki sınıftayız yan sınıfla kavgaya gideceğiz. Sen veya sen benle geleceksin dediğimde ikisinden biride gelebilir olur ikiside gelebilir olur ama ikisi de gelmezse olmaz. Veya kullanıyorsam şartlardan birinin gelmesi yeterlidir.
    Yada da ise sen ya da sen geleceksin dediğim zaman ya sen geleceksin ya da sen geleceksin ikiniz aynı anda gelemezsiniz ikinizin gelmeme durumu da olmaz ikinizin aynı anda gelme durumu da olmaz.
    * En fazla bir tanesinin ve en az da bir tanesinin yerine getirilmesini ister.

- Küçük bir çocuk var yanınızda parayı verdiniz dediniz ki al yeğenim bana parliament ve marlbora al dediniz.
    * Gitti parliament getirdi marlbora getirmedi OLMADI
    * Gitti marlbora getirdi parliament getirmedi OLMADI
    * Gitti ikisini de getirmedi OLMADI
    * Gitti marlbora getirdi parliament getirdi OLDU
    
- Küçük bir çocuk var yanınızda parayı verdiniz dediniz ki al yeğenim bana parliament veya marlbora al dediniz.
    * Gitti parliament getirdi marlbora getirmedi OLDU
    * Gitti marlbora getirdi parliament getirmedi OLDU
    * Gitti marlbora getirdi parliament getirdi OLDU
    * Gitti ikisini de getirmedi OLMADI

- Küçük bir çocuk var yanınızda parayı verdiniz dediniz ki al yeğenim bana parliament ya da marlbora al dediniz.
    * Gitti parliament getirdi marlbora getirmedi OLDU
    * Gitti marlbora getirdi parliament getirmedi OLDU
    * Gitti marlbora getirdi parliament getirdi OLMADI
    * Gitti ikisini de getirmedi OLMADI

```C#
Mantıksal Operatörler
// Tüm şartları değerlendirip, kendine göre sonuç döndüren operatörlerdir.
ve &&
//ve(&&) operatörü, tümmm şartların yerine getirilmiş olmasını isterrrr.
//Patates ve Köfte
// true   && true

veya   ||
//veya(||) operatörü, şartlardan en az bir tanesinin yerine getirilmiş olması yeterlidir.
//Patates veya Köfte
// true/false || false/true

yada ^
//ya da  ^ operatörü şarlardan kesinlikle birtanesinin yerine getirilmesini isterrr...
//true ^ false veyahut false ^ true
```