***
# 188) Programlamada Nedir Bu Döngüler? Ne Amaçla Kullanılır?
- Tekrar eden yapılanmaları tekrar eden kodlarımızı tekrar etmesi gereken programlarımızı bir koşula bağlı olarak yani kombinasyona bağlı olarak belirli sayıda tekrarlayabilen işleyebilen yapılara döngü diyoruz.

- Döngü dediğimiz yapı fiziksel olarak dönen ve üzerinde işlem yapılan yapılanma değil. Döngüden kastımız burada dönmesinden kasıt belirli bir koşula belirli bir kombinasyona bağlı olması koşul doğrulandıkça o kombinasyonun koşulu doğrulandıkça bu döngü kendi içerisindeki kodları tekrar eder tekrardan tetikler. Tekrardan tetikleme operasyonu neticesinde buna en güzel isim döngü olarak verilmiştir.

- Döngü yapısı programlamanın temelini teşkil eder. Temel yapıtaşlarından birisidir. Değişkenler nasıl yapıtaşlarından birisi `if else`, `switch`, akış kontrol mekanizmaları hata kontrol mekanizmaları bunlar programlama dilinin kendi fıtratında olan bir temel yapıtaşıysa dögü de aynı şekilde programlama dilinin dahilinde olan bir yapıtaşıdır. Hatta bir programlama dilinde döngü yoksa ki mümkün değil o programlama dilinde hiçbişey yapamazsınız.

- Siz yapısal olarak han daavranış olarak şöyle bir ihtiyaca sahip olabilirsiniz en temelde olayı değerlendirelim. Diyelim ki ekrana 10 defa kendi adımı yazdıracaksam 10 kez `Console.WriteLine("Musa UYUMAZ")` yazarak yazıdrabilirim. Şimdi bir yazılımcı probleme öyle ya da böyle çözüm bulur. Sıkıntı değil. İster 10 defa teker teker yazarsın biz buna ameleus felsefesi diyoruz. Ya da biz burada kodları tekrar etmektense bunlardan bir tanesini numune olarak alır derim ki 1'den 10'a kadar bir kombinasyon oluşturur ve ilk değerimi sayısal bir değeri birer birer arttırarak 10'dan küçük olduğu her bir durumda bu kodu tekrar ettiririm. Dolayısıyla tekrar eden bu tarz kodları döngülerle tek satırda tek tanımlama da belirli kombinasyona dair yani oradaki koşula bağlı bir şekilde istediğim kadar tetiklettirebilirim.

- İstediğin kadar tetiklettirebileceğin bir yapılanma varken bunu manuel bir şekilde yazmak doğru değildir. Döngüler yapısal olarak koşula bağlı belirli sayıda bu koşul sağlandığı sürece ilgili kodu tekrarlayan yapılardır. Ben öyle bir kombinasyon koyacağım ki ortaya benim istediğim sonucu bana verecek tek satırlık/konseptlik/algoritmalık işlem olacak. 

- Döngü dediğimiz yapılanma sizin kodlarınızdaki analitik çözümleri hızlı bir şekilde yapmanızı sağlayan yapılanmadır.

- Temelde 3 tane döngümüz vardır.
    * `for` döngüsü
    * `while` döngüsü
    * `do while` döngüsü

- `foreach` bir döngü değildir iterasyondur.

```C#
# Döngüler Nedir?
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");   
```

***
# 189) ‘Hangi Döngü Nerede Kullanılır’ Yanlış Bir Sorudur! Doğru Soru ‘Hangi Döngü Nereye Yakışır’
- Yapısal olarak biz 3 tane döngü yapısını inceleyeceğiz.
    * `for` döngüsü
    * `while` döngüsü
    * `do while` döngüsü

- Hangi döngü nerede kullanılıyor sorusu yanlış bir sorudur. Çünkü hepsi bir kombinasyona bağlıdır. Hepsi bir mantığa göre çalışmakta o kombinasyondaki sonucun doğrulanmasına göre çalışan yapılanmalardır. Yani birini diğerinin yerine kullanabilirsin. Ya da sadece birini öğrenip diğerlerini öğrenmeyebilirsin. Programlama hayatın boyunca da onu kullanbilirsin.

- Döngülerde hepsi birbirlerinin yerine kullanılabiliyor. Ama bazı senaryolara bazı döngüler daha yatkındır. Örneğin ardışık bir sayım işlemi oluyorsa `for` döngüsü daha yatkındır daha çok yakışır. Ya da sonsuz bir yapılanma söz konusuysa `while` ya da `do while` daha çok yakışacaktır. `do while` ise böyle manevratik takla atacağımız belirli bir mantığa göre işleyen bir yapılanmadır. Hepsi birbirinin yerine oturabilmekte nihayetinde hepsinde bir temel bir mantık/kombinasyon işlemekte ama daha çok yakılan yönleri vardır ya da böyle yakışmayan yönleri vardır ama yakışmayan yerde de yine istediğin döngüyü kullanbilirsin.

- Hangi döngü nerede kullanılmalıdır? sorusu YANLIŞTIR! Doğru soru hangi döngü nereye/hangi senaryoya daha çok yakışır...

- Sen bir çözüm bulacan elindeki senaryoya göre bir tane döngüyü seçmen lazım rastgele gözün kapalı seçebilirsin sıkıntı yok ama hangisi daha çok yakışır sorusunu soracaksın cevabını arayacaksın.

- 1'den 100'e kadar sayman lazım bunun için `do while`de de yapabilirsin `while` de de yapabilirsina ama ardışık işlemlerde `for` döngüsünü kullanman bu senaryoda daha çok yakışacaktır.

- Sonsuz bir denetleme yapman lazım sonsuza giden bir durum yani sonunu bilemeyeceğimiz sonunu hiçbir zaman tahmin edemeyeceğimiz durumlarda işlem yapmam gerekiyorsa işte burada `for` ile de yapabilirsin `do while` ile de yapabilirsin. Ama `while`'ı daha çok severiz biz böyle durumlarda. Diğerleriyle yapamazsın anlamına gelmiyor.

- Bu döngülerin hepsi bir kombinasyona bağlı bir şekilde çalıştıkları için ennnn nihayetinde birbirlerinin yerine kullanılabilirler...
 
- Senaryoda istediğin dönügüyü seçebilirsin `for`la çözebildiğini `while`la da `do while`la da çözebilirsin. `do while`la çözdüğünü `for`la da çözebilirsin vs. 

- Nihayetinde bunlar senaryoya uygun iskeletler değil bunlar kombinasyonla sadece tetikleme yapıyor. Bir kombinasyonu var orada ona göre tetikleme yapıyorsa sen buna istediğini kullan. Madem ki bişey döndüreceksin madem ki belirli bir kod tetikleyeceksin istediğin döngüyü kullanbilirsin buradaki önemli olan hangisi daha çok elindeki senaryoya uygundur hangisi daha çok yakışıyor ona bakacaksın.

- Döngülere birbirinden farklı yapılar olarak bakmayacaksın. Birbirlerinden ayrılar farklılar tamam ama senaryo senaryo bakmayacaksın. Diyeceksin ki bu döngülerin hepsi aynı. Aynı şeyi öğreniyorum aynı işi yapabileceğim yapılanmayı öğreniyorum sadece bunlar senaryolara yakışabilecek durumları vardır onun dışında hepsinin kurallarını bildikten sonra kullanımlarıyla aynı sonuçları üretebilirim diyeceksin

<img src="1.png">

***
# 190) For Döngüsünü İnceleyelim
- Prosedürel programlama da döngü yapılarından birisi de `for` döngüsüdür.

- Genellikle kombinasyonel olarak ardışık işlemlerde kullanılan bir döngü yapılanmasıdır

- Örneğin ben 1'den 100'e kadar yazdıracaksam 1'den 100'e kadar olan bütün sayıları birer birer, ikişer ikişer, beşer beşer, on yedişer on yedişer olsun ardışık nihayetinde bunlar için `for` döngüsünü kullanbilirsiniz.

- Ardışık bir işlem ardışık bir algoritma yapacaksanız ardışıklık üzerinden gidecekseniz algoritmanız üzerinde `for` döngüsünü kullanabilirsiniz.

- Prototip `for(int i = 0; i<10 ; i++) {}` Döngü de 3 tane parametremiz olacaktır. Bu parametreleri `;` ile ayırıyoruz.
    * ilk parametre de Genellikle başlangıç değeri ismi verilen değişken tanımlanabilir. İlk parametre olmasa da olur. `for` döngüsünde başlangıç değeri dediğimiz değişken eğer tanımalanacaksa burada tanımlanabilir. Bu birinci parametre kısmı başlangıç değeri ya da ilk değer denilen değişkeni tanımlamak için vardır ama illa kullanmak zorunda değilsin.
    * İkinci parametre de kombinasyonun şartını yazdığımız yer.
    * Üçüncü parametre de genellikle başlangıç değerinin değerini arttırmak ya da azaltmak için burası kullanılır.

- `for` döngüsü parametreleri zoraki yapmak zorundasın demiyor.

- `for` döngüsü belirli bir ardışık algoritmalarda kullanılan bir döngü. Ardışık algoritmalarda bir ardışık işleme başlayabilmek için ilk değere ihtiyacımız var.

- Genellikle for döngüsünde başlangıç değeri olarak `int` bir sayısal değer tanımlanır işte 0'dan ya da 1'den başlatılır ardından şart ilk değere yani başlangıç değerine bağlı bir şekilde şart kontrol edilir. Biz ilk değere yani başlangıç değerine bağlı şart yazmak zorunda da değiliz.

- Örneğin sen ilk değerde 1 değerini tanımladın `int i = 1` dedin şartta da diyorsun ki elimdeki bu i 10'dan küçük olduğu sürece/küçükse diyorsun. i değeri 10'dan küçük olduğu sürece tetiklenecek yani kendi scopeları içerisindeki kodlar tekrarlı bir şekilde işleyecektir.


- Başlangıç değer ya da ilk değer atama kısmı : Ardışık algoritmalalarda genellikle bir ilk değere ihtiyaç vardır İşte bu ihtiyacı burada tanımlayabiliriz. Amma velakin bu tanımlama zorunlu DEĞİLDİR!!!
    * Burası illa sayısal bir değer olmak zorunda değil. Sen bunu metinsel/char/boolean tanımlayabilirsin yani burası bir değişken tanımlama alanı.
    * Genellikle buradaki kombinasyonda kullanacağımız değişkeni tanımlarız.
    * Başlangıç değeri burada tanımlanıyorsa eğer illa ki bir değerin atanması gerekmektedir.

- Şart Kısmı : Herhangi bir şart koşul ifadesi tanımlanabilir. Lakin genellikle ilk döngü olarak tanımlanan değişken durumu burada kontrol edilir. Yani bir şarta bağlanır. Şart `true` olduğu sürece döngü tetiklenecektir. 
    * Genellikle biz başlangıç değeri olarak tanımlanan değişken üzerinden bir şart koyarız. Zorunlu değildir ama bu şekilde şart koyarız.
    * Şart `true` olduğu sürece döngü dönecektir. İçindeki kodları tetikleyecektir.

- Arttırma Kısmı : Herhangi bir değişken üzerinde işlem yapabiliriz. Genellikle bir başlangıç değeri üzerinde bir arttırma yahut azaltma işlemi yapılır. Amma velakin bir değerinin dışında diğer arttırma ve azaltma işlemleri de ihtiyaca binaen yapılabilmektedir. Veee illa ki kullanmak zorunda da değiliz. Arttırma ve azaltma operasyonlarını biz başka yerde yapabiliriz.
    * Genellikle başlangıç değerinin değeri arttırılır.

- Scope Kısmı : Şart `true` oldukça bu scope tetiklenecek ve döngü çalıştırılmış olacaktır.

<img src="2.png">

- `for` döngüsünde parametleri tanımlamak zorunda değilsin. Peki neden oluşturuldu parametreler? Bir algoritma oluşturuyorsun o algoritma da kullanılan parametrelerin onun kalıbında olması kontrol açısından daha kolaylaştırıcıdır.

- Kombinasyonda yapacağın işlemin sadece o işleme özel parametrelerse bunların koordinasyonun yapıldığı noktanında tek bir merkezden yönetilmesi esasında bizim içinde bir avantajdır.

- Temelde biz bir başlangıç değeri tanımlarız ardından bir şart uygularız ilgili başlangıç değişkenine ve ardından ilgili başlangıç değişkeninin değerini arttırırız.

- Compiler kodları tek tek işlerken bir geliyor `for` ahanda `for` şimdi döngüye girecez. İlk olarak `for` u gördükten sonra;
    1. Akış ilk olarak başlangıç değişkeni tanımlama kısmına girecektir. Eğer ki bir değişken tanımlama ifadesi varsa ilgili değişkeni tanımlayacaktır.
    2. Ardından koşula gidecek ve koşulu değerlendirecektir.
    3. Eğer ki koşul `true` ise döngüye girecektir.
        * Koşul kontrol edildikten sonra döngü ilgili değeri arttıracak parametreye gidecek ve yapılan aritmetik işlemi değişkene uygulayacaktır.
        * Sayısal değeri arttırılmış ya da azaltılmış yani değiştirilmiş/değiştirilmemiş olan değişkenden sonra yeniden koşulu kontrol edecek ve ardından `true` ise 3 değilse 4. adımlar tekrar edecektir.
    4. Yok eğer koşul `true` değil ise döngüden çıkacaktır.

- I. adıma bir kereye mahsus girecektir `for` döngüsünde 2. ve 3. adımlar kendi aralarında durmadan paslaşacaktır. Yani ilk önce `for` döngüsüne girdiğinde 1. adıma gidecek değişkeni tanımlayacak 2. adıma gidecek şartı kontrol edecek ardından eğer `true` ise döngüye girecek değilse döngüden çıkacak. Döngüye girerse eğer işlemini bitirdikten sonra değişkenin değerinde değişiklik yapmaya gidecek değeri değiştirecek ya da değiştirmeyecek daha sonra koşula geri dönecek koşul eğer hala sağlanıyorsa bir daha döngüye girecek daha sonra geri bir daha değişkenin değerinde değişiklik yapmaya gidecek daha sonra koşula tekrar gidecek vs şeklinde paslaşma yapacak ta ki koşul `false` olana kadar buradaki işlemler tekrar edecek ve döngü tetiklenmiş olacaktır.

- Yapısal olarak `for` döngüsü bir kombinasyona bir ardışık operasyonlarda kullanılabilirliğe daha yatkın bir döngüdür. Nihayetinde burada arttırma azaltma işlemlerini çok fazla yaparız. O yüzden ardışık operasyonlarda çok kullanırız diye nitelendiriyoruz.

<img src="3.png">

***
# 191) For Döngüsü Kritik Yapalım 1
- Başlangıç değeri her daim tanımlanmak zorunda değildir ama tanımlıyorsanız eğer bir değer atanmak zorundadır.

- Şartımız herhangi bir şart olabilir mesela `true` şimdi şart kısmı normalde şart dediğimiz bir kıyaslamadır kıyaslama neticesinde sonuç `bool` dönecektir `true` ya da `false` eğer sen direkt gelir buraya `true` yazarsan bu döngü hangi değer olursa olsun farketmiyor sürekli sonsuza kadar şartı koşulu `true` olacağından dolayı sonsuz döngü olacaktır.

- Compiler kodun akışında `for` döngüsünü gördüğü zaman öncelikle başlangıç değerini ya da ilk değer dediğimiz değişkeni tanımlama alanına gelecektir. Varsa ilgili değişken tanımlayacaktır tanımladıktan sonra koşula bakacaktır. Koşul `true` olduğu sürece döngüye girecektir. Yani scope içine girecektir. Daha sonrasında değişken değerini değiştime alanına gelecek daha sonrasında ise tekrar koşula bakacaktır.  Koşul `true` olduğu sürece yine döngüye girecektir. Böyle böyle koşul `false` olana kadar devam edecek koşul `false` olduğunda ise döngüden çıkacaktır.

- Ardışık operasyonlarda geliştirilen algoritmalarda `for` döngüsü daha efektiftir. Çünkü hızlı bir şekilde ardışık yapılanmayı sana verecektir

```C#
#for Döngüsü
for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine("Musa UYUMAZ");
}
```

***
# 192) For Döngüsü Kritik Yapalım 2
- Başlangıç değişkenine verilen değer ne ise ona göre bundan sonraki mantıksal kombinasyon şekillenecek.

- `for` döngüsündeki esas mantıktır. `for` döngüsünün parantezleri içerisindeki formülü çözdüğünüz zaman ilgili operasyon o formüle göre tetiklenecektir.

- Biz mümkün mertebe 0'lardan 1'lerden başlatıp olayı ele almayı severiz. Çünkü hesaplaması kolay oluyor.

- Matematik niye var? Minimize edilmiş rakamlarla siz devasa major yapılanmaları göresiniz diye var.

- `for` döngüsündeki mantığı diğer döngülerde de aslında aynı `for` döngüsündeki mantığı kurduğunuz zaman operasyon bitiyor.

- `for` döngüsünde kombinasyona odaklanacaksınız çünkü kombinasyon önemli.

```C#
#for Döngüsü - İnceleme 2
//Serhat değerini 10 kere ekrana yazdıralım.
#Ameleus
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");
System.Console.WriteLine("Serhat");

#Döngü ile
for (int i = 0; i < 50; i += 5)
{
    System.Console.WriteLine("Serhat");
}
```

***
# 193) For Döngüsü Kritik Yapalım 3
- Bir `for` döngüsünde illa hep artış yapmak zorunda değilsiniz. Algoritmayı tersine de alabilirsiniz.

- `for` döngüsündeki kombinasyona ne kadar hakim olursan ne kadar oradaki kombinasyonu çözebilecek analitiğe sahip olursan döngüyle falan problemin kalmıyor.

- Eğer ki ardışık işlemlerde artış yapılıyorsa i'nin değeri genellikle `<`(Küçüklük) durumuyla değerlendirilir. Yani sen burada küçüklüğüne bakıyorsun çünkü o artıyordur bişeyden küçük olduğu sürece oradaki şart doğrulanacaktır. O küçüklük bir gün aştığı zaman yani küçük olmadığı zmaan oradaki döngüden çıkacaktır.

- Yok eğer ardışık işlem eksiliş gösteriyorsa i'nin değeri genellikle `>`(Büyüklük) durumuyla değerlendirilir. Nihayetinde orada büyüklük durumu yani orada i büyüktür belirli bir eşiğe kadar gelecektir bundan büyük oldukça tetiklenecektir. Bu eşiğe eşit ya da küçük olduğu durumlarda tetiklenmeyecektir. 

```C#
#for Döngüsü - İnceleme 3
//Serhat değerini 10 kere ekrana yazdıralım.
for (int i = 50; i > 0; i -= 5)
{
    System.Console.WriteLine("Serhat");
}
```

<img src="4.png">

***
# 194) For Döngüsü Örnek Yapalım 1
- Hangi senaryo da hangisini kullanmalıyızdan ziyade hangi senaryoya hangisi daha çok yakışır diye sorulduğunda eğer ki bir ardışık operasyon varsa `for` döngüsü direkt aklımıza gelecek.

- Benden problem ne istiyorsa benim onu karşılayabilmem lazım.

- İlla değerler sizin için önemli değildir aslında kombinasyon önemli.

- Mümkün mertebe analitik çözüm getirmeye çalışıyorsunuz.

- Kompleksliği analitiklik olarak algılayan yazılımcılar var bu böyle değildir alakası da yoktur. Analitiklik basitlik demektir. Ne kadar basit çözebilirseniz. Ama basitlik profesyonel olmayan kod anlamına gelmiyor Analitiklik, Basitlik, Profesyonellik bunlar birbirine bağlı yapılanmalar. Öbür türlü komplekslik dışarıda bambaşka yapılanma işte komplekslik istemediğimiz sonuç zaten Analitik yazılan Basit yazılan kod profesyoneldir. Dolayısıyla her ikisinide kapsar. Yani kompleks olmaması gerekiyor. Onun için kompleks yapacağım yazdığım kodu daha değerli göstereceğim diye derdiniz o olursa biraz saçmalamış olursunuz. Mümkün mertebe en doğru hamlelerle en doğru verilerle çalışmaya özen göstereceğiz

```C#
#Örnek 1
//1'den 10'a ladar olan sayıları alt alta ekrana yazdıralım.
#1. Çözüm
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine(i);
}

#2. Çözüm
for (int i = 50; i < 60; i++)
{
    System.Console.WriteLine(i - 49);
}
```

***
# 195) For Döngüsü Örnek Yapalım 2
- Herşeyi sen bilemzsin problem sana vermeli. Problem sana vermeli. Problem ne istediğini sana vermediği sürece o da ayrı bir problem.

- Bir ardışıklık söz konusuysa aklına `for` döngüsü gelmeli. `while`lada `do while`lada yapabilirsin. Ama `for` döngüsü bu senaryoya en yatkını.

- Senaryo => 1 ile 40(Dahil) arasındaki çift sayıları toplayarak sonucu ekranda gösterelim.
    * `for (int i = 1; i <= 40; i++)` Bu kombinasyon her bir turda 40 ile 1 arasındaki bütün değerleri i değişkeni üzerinden bana veremeyecek mi verecek.
        + Burada başlangıç değerine ve bitiş değerine sen karar vermeyeceksin yazılım karar verecek.
    * Bir sayının çift olma durumunu ilgili sayıyı 2'ye bölerek öğrenebilirim.
    * İlgili sayıyı ikiye böldükten sonra kalanın 0 olup olmamasını nasıl değerlendiririm? Burada bir karşılaştırma değerlendirme var değil mi yani akış kontrol mekanizmaları.
    * `for` içerisinde her şeyi kullanabilirsin. `if`, `switch`, `try catch` vs.
    * Gerek olmayan bişeyi yazmayın. Gördüğün algoritmada şartla bakma. Algoritmaya mantıkla bak akılla bak.

```C#
#Örnek 1
//1 ile 40(Dahil) arasındaki çift sayıları toplayarak sonucu ekranda gösterelim.
int toplamSonuc = 0;
for (int i = 1; i <= 40; i++)
{
    if (i % 2 == 0)
    {
        toplamSonuc += i;
    }
}
#İkinci Çözüm
int toplamSonuc = 0;
for (int i = 0; i <= 40; i += 2)
{
    toplamSonuc += i;
}
System.Console.WriteLine("Toplam Sonuç : " + toplamSonuc);
```

***
# 196) For Döngüsü Örnek Yapalım 3

<img src="5.png" width="auto">

- Senaryo Klavyeden girilen sayının faktöriyelini bulan programı yapalım.
    * Birinci Çözüm olarak 1'den başlayıp sayıya kadar olan sayıları çarpıp elde edebiliriz.
    * İkinci Çözüm olarak sayıdan'dan başlayıp 1'e kadar olan sayıları çarpıp elde edebiliriz.

- Bir döngünün içerisindeki aritmetik işlemleri toplayan, çarpımların sonuçlarını toplayan kendisinde tutan sayısal ifadeler döngünün dışında tanımlanır. Zaten bu algoritmanın gereğidir. İçeride durmadan değeri ezmektense dışarıda tanımlanmış bir değişkende ilgili değerleri toplamayı yeğleriz.

```C#
#Örnek 3
//Klavyeden girilen sayının faktöriyelini bulan programı yapalım.
System.Console.WriteLine("Faktöriyelini alacağımız sayıyı girelim.");
int sayi = int.Parse(Console.ReadLine());
int faktoriyel = 1;

#1. Çözüm
for (int i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}
System.Console.WriteLine("Faktöriyel : " + faktoriyel);

#2. Çözüm
int faktoriyel = 1;
string sonuc = "";
for (int i = sayi; i > 0; i--)
{
    faktoriyel *= i;
    sonuc += i + (i == 1 ? " = " : " x ");
    if (i == 1)
        sonuc += i + " = ";
    else
        sonuc += i + " x ";
}
System.Console.WriteLine("Faktöriyel : " + sonuc + faktoriyel);
```

***
# 197) For Döngüsü Varyasyonları 1
- İlk varyasyonu `for(int i = 0; i < 10; i++) {}`
    * İlk parametrede bir başlangıç değeri tanımlarız.
    * İkinci parametrede başlangıç değerine bağlı bir şart oluşturuyoruz genellikle ama illaki bağlı olmak zorunda değil.
    * Üçüncü parametrede ise başlangıç değerini arttırdığımız operasyonunu gerçekleştirdiğimiz alanı tanımlıyoruz.

- Bu varyasyonda hiçbişey zorunlu değil istersen başlangıç değerini tanımla tanımldaıktan sonra şartı bambaşka bişey üstünden ver illa başlangıç değeri üzerinden vermek zorunda değilsin. Herhangi bir değişkenin değerini burada arttırıp azaltabilirsin. İlla ki başlangıç değerini arttırıp azaltmak zorunda değilsin.

- Burada amaç Bir döngüde operasyonel olarak kullanılan tüm parametrelerin tek bir çatı altında toplanması hani bakınca tek bir seferde görebilmektir. Zaten buradaki parametrelerin hiçbiri zorunlu değil.

```C#
#Varyasyonlar
for (int i = 0; i < 10; i++)
{
    
}
```

***
# 198) For Döngüsü Varyasyonları 2
- Başlangıç değerini tanımlamadan direkt dışarıda da tanımlayabilmektesiniz. Başlangıç değerini dışarıda tanımladıktan sonra `for` döngüsünde Başlangıç parametresini boş geçip ardından koşula odaklı bir şekilde değerinizi yazıp başlangıç değerini burada yönetiyor olabilirsiniz.

- Değişkenin değerinin dışarı da tanımlandığı ve içeriye herhangi bir şekilde tanımlama yapılmaksızın direkt koşullarda ve arttırma azaltma noktasında kullanıldığı bir varyasyon.

```C#
#Varyasyon 2
int i = 0;
for (; i < 10; i++)
{
    
}
```

***
# 199) For Döngüsü Varyasyonları 3
- Başlangıç değerinin dışarıda tanımlayarak gene içeride referans gösterebiliyorsunuz. Amma velakin burada bişeye dikkat etmemiz gerekiyor her ne kadar dışarıda tanımlanısada içeride hata verecektir. Çünkü yine başlangıç değeri tekrardan bir değer ataması yapılmak zorunda.

- Dışarıda tanımlıyorsan bir değişkeni içeriye verdiğin taktirde içeride bir daha buna bir değişken başlangıç değeri ataman gerekiyor diye uyarmaktadır.

- Bu varyasyonda dışarıda tanımlanan değişkeni `for` döngüsünde başlangıç değeri olarak göstermek istiyorsak eğer yine bu değişkene bir başlangıç değeri atamamızı zorunlu kılmaktadır... Yani içeride bu başlangıç değerini vermemiz gerekmektedir.... Aksi taktirde derlenmeyecektir kodumuz.

```C#
#Varyasyon 3
int i = 0;
for (i = 0; i < 10; i++)
{
}
```

<img src="6.png" width="auto">

***
# 200) For Döngüsü Varyasyonları 4
- `for ( ;i < 10;)`
- `for` döngüsünde başlangıç değerini dışarıda tanımlayabiliyorduk aynı şekilde başlangıç değerinin arttırıp azaltma işlemini de yani değişim işlemini de burada yapmak zorunda değiliz. buradan da kaldırıp boş geçebiliriz. Eğer burayı da boş geçiyorsak arttırıp azaltma işlemini de yani değişim işlemini içeride yapabiliriz. Ya da duruma göre uygun bir noktada i'yi/başlngıç değerini arttırıp azaltmanız gerekecektir.

- Varyasyon olarak dışarıda tanımlayıp ne buraya bildirmek zorundasınız ne de burada arttırmak zorundasın.

```C#
#Varyasyon 4
int i = 0;
for ( ;i < 10;)
{   
    i++;
}
```

***
# 201) For Döngüsü Varyasyonları 5
- Şart kısmı illaki başlangıç değerine bağlı olmak zorunda değildir.

- Şart kısmını genellikle başlangıç değerine bağlı olarak kullanırız ama her zaman değil.

- Buradaki parametrelerde illaki normal yüzeysel tanımlar yapılan içeriklerde olduğu gibi illa başlangıç değerin olacak illa şartın ona göre olacak illa arttırman olacak vs. Bunlar olmak zorunda değil hepsi opsiyonel hepsi senin iradene bağlı ama genellikle biz başlangıç değerini tanımlar ona bağlı bir şekilde koşul oluştururuz.

```C#
#Varyasyon 5
string adi = "Serhat";
for (int i = 0; adi == "ahmet"; i++)
{
}

int a = 10;
for (int i = 0; a != i * 2; i++)
{
    Console.WriteLine("Musa");
}
```

***
# 202) For Döngüsü Varyasyonları 6
- Başlangıç değerini vermek zorunda değiliz. Aynı zmaanda koşulu da vermek zorunda değiliz. Hatta arttırma azaltma miktarını da bildirmek zorunda değiliz. Bu şekilde bir `for` döngüsü tanımlanabilir.

- Bu döngü sonsuz döngüdür. Scope'undaki kodlar durmadan işler.

- İçerisinde bulunan ilgili kodları sonsuza kadar ebediyyen yazdıracaktır. 

```C#
#Varyasyon 6
for (; ; )
{
    System.Console.WriteLine("Musa");
}
```

***
# 203) For Döngüsü Varyasyonları 7
- Bir şart belirtiyorsanz bu şarta uygun bir şekilde hareket edecektir. Amma velakin siz başlangıcı ya da artış azalış miktarını belirttiniz ama şartı belirtmiyorsanız bu yine bir sonsuz döngüye alamet olacaktır.

```C#
#Varyasyon 7
for (int i = 0; ; i++)
{
    System.Console.WriteLine("Musa");
}
```

***
# 204) For Döngüsü Varyasyonları 8
- `for` döngüsünün başlangıç değerini tanımlama kısmında birden fazla değişken tanımlaması yapabilmekteyiz. 

- Nihayetinde bakarsanız eğer başlangıç kısmı bir değişken tanımlama kısmı ve burada bir değişken tanımlanmakta dolayısıyla biz , diyerek birden fazla değişken tanımlaması yapabilmekteyim.

- Eğer ki `for` içerisinde birden fazla değişken ihtiyacınız varsa tabikide bu değişkeni dışarıda tanımlayabilirsiniz. Tabiki ezilme pahasına da olsa içeride de tanımlayabilirsiniz ama hani şöyle kalıba baktığında direkt göreyim istiyorsan başlangıç kısmında normal değişken tanımlar gibi tanımlayabiliyorsunuz.

- Aynı şekilde bu değişkene `for` döngüsü içinde erişerek kullanabiliyoruz. Gerek şart kısmında gerek artış kısmında gerekse scope kısmında.

- Bu yapılanmaya baktığımızda `,` ile sen bir değişken daha oluşturdun hem şarta da ekleyebiliyorsun. Şarta normal mantıksal yapılanmayla ekledik. Artış kısmında da `,` ile  diğer değişkeninde değerinde artış azalış yani değişiklik sağlayabiliyoruz.

- Bu şekilde birden fazla tanımlama yapabiliyorsan yine bu şekilde birden fazlasınında değerini arttırıp azaltabilirsin.

- Birden fazla değişken durumunda `,` ile bunları arttırma azaltma kısmında ayırdığımıza dikkatinizi çekerim. 

- İçeri de ise her ikisine de erişim sağlayabiliyoruz.

```C#
#Varyasyon 8
for (int i = 0, i2 = 0; i < 10 && i2 < 5; i++, i2++)
{
    System.Console.WriteLine(i);
    System.Console.WriteLine(i2);
}
```

***
# 205) While Döngüsünü İnceleyelim
- `while` döngüsü `for` döngüsüne bakarak daha sade daha ilkel ilk varyasyonlardan biri gibi.

- Hiçbirşeyi yok sadece bir scope'u ve parantezi var. `while(........) {}`

- `while` döngüsünün parantezinde sadece Şart var ne bir başlangıç değeri var ne bir başka arttırma azaltma noktası var.

- `while` döngüsü şart doğrulandıkça tetiklenir...

- Şart doğrulandığı sürece `while` döngüsü tetiklenecektir.

- `while` döngüsü sadece şarta bağlı bir döngüdür. Şart doğrulandıkça tetiklenecektir.

- `for`a nazaran daha ilkel ve sade bir döngüdür.

- `while` döngüsü programlamanın ilk tasarlanmış döngüsüdür.

- `for` olmayan dil vardır ama `while` döngüsü tüm dillerde vardır. Hiçbir döngü yoksa `while` döngüsü varsa bütün işlemlerini bu döngüyle yapabilirsin. Keza `for` döngüsüyle `while` döngüsüyle ne yapabiliyorsan onuda yapabiliyorsun. 

- Genellikle sonsuz döngülerde yahut süreci bilinmeyen durumlarda kullanılan bir döngüdür. Amma velakin istediğiniz yerde kullanabilirsiniz.

- `for` döngüsünü nerelerde kullandıysan `while` döngüsünü de birebir o noktalarda kullanabilmektesin.

<img src="7.png" width="auto"> 

***
# 206) While Döngüsünü For İle Kıyaslayalım 
- `for (int i = 0; i < 10; i++) {}` `for` döngüsünün genel iskeleti bu şekilde bir başlangıç değişkenimiz var bir şartımız var ve ilgili değişkenin artış azalış miktarını belirttiğimiz bir operasyonumuz var.

- `while (true){}` `while` döngüsü ise görüldüğü üzere sadece bir şarttan ibaret. Yani buraya sadece şart yazıyoruz.

- `while` döngüsünde `for` gibi çalışmak için kombinasyonu kendimiz oluşturmalıyız.

<img src="8.png" width="auto"> 

- Kombinasyonu oluşturabilmem için `while` döngüsünün parantezleri içinde parametreleri yok yani bir başlangıç değeri tanımlayabileceğim bir artış azalış miktarını belirleyebileceğim bir alan yok. Dolayısıyla `while` döngüsünde başlangıç değerimi dışarıda tanımlıyorum devamında ise şartım neyse parantez içine bunu yazıyorum daha sonrasında ise artış miktarını her bir döngü döndüğünde kendi içerisinde değeri arttırsın. Yani scope içine yazıyorum. 

<img src="9.png" width="auto"> 

- Compiler yukarıdan gelecek bakacak `while` döngüsü diyecek ki şarta bakacak eğer ki `true` ise döngüye girecek. Diyelim ki işlemini bitirdi bitirdikten sonra yine şarta bakacak `true` ise yine döngüye girecek yine şarta bakacak döngüye girecek şarta bakacak ta kii `while` döngüsü şart `false` olana kadar tetiklenecektir.

<img src="10.png" width="auto"> 

- Yapısal olarak `for`dan farkı vardır ama işleyiş olarak mantığı kurduğunuz an hiçbir fark olmayacaktır. Hani sonuçta aynı sonuçları elde edebilirsiniz.

```C#
#while Döngüsü - for İle Kıyaslama
        
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("Musa");
}
System.Console.WriteLine("**********************************");

int _i = 0;
while (_i < 10)
{
    System.Console.WriteLine("Musa");
    _i++;
}
```

***
# 207) While Döngüsü Kritik Yapalım 1
- Senaryo :Ekrana 10 kere "Merhaba Dünya" yazdıran bir program yazalım

- 1'den 10'a kadar saydırmak belki `for` ile daha kolay olabilir amma velakin operasyonel olarak `while`da nasıl yapılır buna bakacağız.

- `while` döngüsü şarta bağlı bir şekilde içindeki kodu yazdıran bir döngü. İçindeki kodu şart `true` olduğu sürece çalıştıracaktır/tetikleyecektir.

- Bu senaryoya göre yapacağımız manevralar `for` dakiyle aynı mantıkta olacaktır. Yani benim süreci takip edebileceğim kontrol edebileceğim bir sayısal değer oluşturmam gerekiyor. Ardından buna uygun bir kombinasyonsa koşul yapıyorum. Ve ardından tabikide sayısal değeri attırmam gerekiyor ki sonsuz döngüye girmesin.

```C#
#İnceleme 1
//Ekrana 10 kere "Merhaba Dünya" yazdıran bir program yazalım
int i = 1;
while (i <= 10)
{
    i++;
    System.Console.WriteLine("Merhaba Dünya");
}
```

***
# 208) While Döngüsü Kritik Yapalım 2
- Senaryo : Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım.

- `while` döngüsünde arttırma azaltma işlemlerini yaparken yaptığınız yere dikkat edin. Arttırıp azaltacağınız değer algoritmada o an kullanacağımız bir değerse algoritmada kullanılacak değer önceden işleme tabi tutulmamalıdır.

- Bu senaryoya göre sayıyı yazdırmadan önce sayıya müdahale edersem yanlış çıktılar alırım. Yani bir mantıksal hata yapmış oluruz. Böyle bir algoritmada sayının değeri işlem yapıldıktan sonra değiştirilmelidir.

- `while` döngüsünde çalışırken arttırma azaltma işlemlerini nerede yapıldığına iyi dikkat etmeniz gerekiyor.

```C#
#İnceleme 2
//Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım.
int sayi = int.Parse(Console.ReadLine());
while (sayi >= 0)
{
    //sayi--;
    System.Console.WriteLine(sayi);// Bu senaryoda 
    sayi--;
}
```

***
# 209) While Döngüsü Kritik Yapalım 3
- Senaryo : 0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım.

- Birşeyi 2'ye böldüğünde kalan 1 ise bu sayı tek sayıdır. 0'sa çift sayıdır. Bu tarz algoritmalarda etkisiz elemanı kullanmalıyız.

- Eğer ki senin içeride kullanmış olduğun değer bir yandan arttırman ya da azaltman gereken değerse işlemden önce/algoritmadan önce onu işleme tabi tutmamalısın/çalışma yapmamalısın. Aksi taktirde sen oradaki çalışmayı bozarsın. Doğru değerle çalışmak için ilk önce bir çalışayım ardından değeri değiştireyim.

- `while` döngüsünde ya da `for` döngüsünde döngüden bağımsız hani bu biraz daha manevratik görebileceğiniz bir yapılanma değeri toplarkende direkt `toplam += i++;` diyebilirsiniz. Nihayetinde `i++` operatörü ilk i'nin değerini döndürecek sonra i'nin değerini 1 arttıracaktır. Amma velakin bu senaryoda maalesefki işe yaramayacaktır. Çünkü i değerinin mod değeri 1 ise artacaktır değilse sonsuz döngüye girecektir.

```C#
#İnceleme 3
//0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım.
int i = 0, toplam = 0;
while (i <= 100)
{
    //i++;
    if (i % 2 == 1)
        toplam += i;
    i++;
}
```

***
# 210) While Döngüsü Kritik Yapalım 4
- Senaryo : Klavyeden girilen sayının faktöriyelini hesaplayalım.

- Bir formülasyonda kullanacağımız değeri arttırıp azaltma işlemini önceden yapmayacağız o formülasyondan/algoritmadan/koddan önce yapmayacağız sonra yapacağız. Öncesinde arttırıp azaltırsak eğer değerle oynadığımız için işlemin sonucu değişecek ve ortaya mantık hataları çıkacaktır.

```C#
#İnceleme 4
//Klavyeden girilen sayının faktöriyelini hesaplayalım.
int sayi = int.Parse(Console.ReadLine());
int faktoriyel = 1;
while (sayi > 0)
{
    faktoriyel *= sayi--;
    // sayi--;
}
```

***
# 211) While Döngüsü Kritik Yapalım 5
- Senaryo : O anki tarihin saniye değeri 5'in katıysa eğer tarihih ekranda gösteren uygulamayı yazalım.

- Tarih değerini direkt `while(...)` Şart kısmında kontrol edersek eğer şart sağlanmadığı anda `false` döneceği için döngüden çıkacaktır. Yani bir süreklilik arz eden bir kod olmayacaktır.

- Sonsuza giden bir algoritma da içeride kontrol yaparken `while` daha şık olacaktır.

- `for` döngüsüyle de yapabilirdik ama sonsuza gitmemiz gereken durumlarda `while` daha şık olduğundan `while`ı tercih ediyoruz

```C#
#İnceleme 5
//O anki tarihin saniye değeri 5'in katıysa eğer tarihih ekranda gösteren uygulamayı yazalım.
while (true)
{
    if (DateTime.Now.Second % 5 == 0)
        System.Console.WriteLine(DateTime.Now);
}
```

***
# 212) Do While Döngüsünü İnceleyelim
- `while` döngüsüne inanılmaz derecede benzer.

- `while` döngüsünde yapı `while(...ŞART...) {İlgili Çalışacak Kodlar}` `do while` döngüsünde ise `do{Çalışacak kodlar}while(...ŞART...)`

- `while` döngüsü şart `true` oldukça döngü tetiklenecektir. `do while` döngüsü ise yine aynı mantıkla şart `true` oldukça tetiklenecektir.

- Aralarında küçük bir teknik vardır onun dışında birebir aynı çalışıyorlar. 

- `while` döngüsü önce şarta bakar daha sonra kodu çalıştırır davranışı bu şekildedir. Yani önce şarta bakar şart `true` ise kodu çalıştırır yok `false` ise kodu çalıştırmaz. 

- `do while` döngüsü ise önce kodu çalıştırır sonra şarta bakar.

- `do while` döngüsü kodu bir çalıştırır ondan sonra şarta bakar `while` döngüsü ise şarta bakar kodu çalıştırır. Aradaki teknik fark budur.

- Hangi durum olursa olsun siz bir kodu `while` ile çalıştırıyorsanız hiç çalışmama ihtimali de var ya da şarta uygun çalışma ihtimali de var. Amma velakin `do while` ile çalıştırıyorsanız şart `true` da olsa `false` da olsa ilgili döngü bir kereye mahsus tetiklenecektir.

- `while` ile yapılan kontrolde şart `true` olursa döngü tetiklenecek, `false` olursa hiçbir zaman tetiklenmeyecektir.

- `do while` döngüsü şart `true` da olsa `false` da olsa ennn az bir kere tetiklenecektir.

- `while` döngüsü şudur. Önce havaya bakarsın duruma göre şemsiye alırsın. Bazen de şunu yaparız önce şemsiyeyi alırız sonra havaya bakarız yağmurlu da olsa yağmursuz da olsa şemsiyeyi bir kereye mahsus alıyorsun.

- Öncelikli işlemler yapılıp ardından şartı kontrol edip daha sonra tekrar edecek durumlar varsa `do while` döngüsünü tercih ediyoruz. Önceden birden fazla veritabanı sorgusu çalıştırılacaksa bu birden fazla veritabanı sorgusunu tek bir `string` üzerinde yazıyorduk. Bunları `do while` ile işleme sokuyorduk. Diyorduk ki al sen bunu çalıştır ilk önce 1.sini çalıştırıyordu daha sonra kontrol ediyordu ikincisi var mı varsa bir daha çalıştırıyordu. Bak şimdi zaten ilk verdiğin zaten vardır. `do while` 'daki `while` ikinciye bakıyordu var mı daha diye varsa eğer bir daha giriyordu ikinciyi tetikliyorduk daha sonra bir daha soruyordu var mı diye diye o şekilde kullanıyorduk o senaryolarda.

`do while` döngüsü ile `while` döngüsü amcaoğludur :)

<img src="11.png" width="auto">

***
# 213) Do While Döngüsünü While İle Kıyaslayalım
- `while` şarta bakar daha sonra kodu tetikler `do while` ise ilk baş kodu tetikler daha sonra şarta bakar.

```C#
#do while döngüsü
while (false)
{
    System.Console.WriteLine("while döngüsü");
}
do
{
    System.Console.WriteLine("do while döngüsü");
} while (false);
```

***
# 214) Döngüleri Scope'suz Kullanma
- Herhangi bir döngü `for`, `while` `do while` fark etmiyor yapacağı işlem eğer tek satırlık tek konseptlik işlemse scope'suz tanımlayabilmekteyiz.

- Tek satırda yazılan kodlarda genellikle kodun maliyetini vs düşürmek için kullanıyoruz.

- İlgili döngüye ait birden fazla komut işleyecekseniz bunların hepsinin scope içerisine alınması gerektiğine dikkat ediyorsunuz.

```C#
#Scopesuz Döngüler
for (int i = 0; i < 10; i++)
    System.Console.WriteLine("Musa UYUMAZ");

while (true)
    System.Console.WriteLine("");

do
    System.Console.WriteLine("asfdasfdsad");
while (true);
```

***
# 215) Sonsuz Döngüler Nelerdir?
- Bu kavram bazen bizim için bir hataya girmiş olduğumuz farkında olmadan iradesizce girmiş olduğumuz bir hatayı tarif ederken bazen de bazı operasyonlarda irademizle kasıtlı bir şekilde kullandığımız bir durumu tarif etmektedir. 

- Bir döngünün kombinasyonun eğer ki sonsuza kadar olma ihtimali/olma durumu ya da koşulu sonsua kadar sağlama durumu söz konusuysa o döngü hiçbir zaman sonlanmayacağından dolayı sonsuz kere çalışacak yani sonsuz bir döngüye girecektir. Bir başka deyişle bir döngünün sonlanması için kombinasyonel bir koşul var Eğer ki o koşul asla ve asla sağlanmayacak durumdaysa o döngüye de sonsuz döngü denmektedir. Yani her türlü bir döngünün sonlanmasını sağlayacak koşul doğrulanmış bir şekilde doğru bir mantıkla inşa edilmediyse sonsuz döngüye gireceksiniz.

- İnşa edilen kodlarda bazen biz yazılımcılar açısından yanlışlıkla girilen ya da belirli mantıksal hatalardan dolayı istemsizce girilebilen döngülerdir. Bazen de bazı operasyonlarda sonsuzluk durumunda kontrol etmemiz gereken bazı durumları kontrol edebilmek için irademizce kullandığımız bir döngü yapılanmasıdır.

- Şimdi sen bir yazılımcı olarak sen kod yazıyorsun. Yazmış olduğun kodu daha pratik yazabilmek için döngüleri kullanıyorsun. İşte döngülerde kombinasyon oluşturuyorsun yeri gelecek sonsuz döngü kullanacaksın yeri gelecek sonsuz döngüden kaçınacaksın oradaki koşulla ilgili döngü yapacağın işlemden sonra sonlandırabilecek bir şekilde düşünebilirsin. Dikkat edilmesi gereken nokta sonsuz döngülerde tüm yapılanmalarda nasıl kontrol edebileceğini bilmek yani ihtiyacın olduğu durumda sonsuz döngüyü nasıl kullanacaksın ve bunu nasıl kontrol altına alacaksın bunları bilmen gerekiyor.

***
# 216) For İle Sonsuz Döngü Nasıl Yapılır?
- `for` döngüsünde sonsuz döngüye girmek istiyorsanız koşulu ilelebet `true` yapacak şekilde ayarlamanız gerekiyor. 

- Şimdi sen `for` üzerinden sonsuz döngüye giriyorsan dikkat etmen gereken noktalar var.
    * Döngü ne kadar sonsuz bir döngü gibi gözükse de esasında sonlu bir döngüdür. Çünkü bir başlangıç değeri var önemli olan bu değil amma velakin artış miktarını uyguladığın operasyonun var elbetteki birgün buradaki değer türün değer aralığını aşacak ve patlayacaktır. Bu durum döngünün sonu olacağı anlamına geliyor.

- Eğer ki biz `for` döngüsüyle sonsuz döngüye gireceksek eğer başlangıç değeriyle artış azalış miktarını belirtmeyiz.

- `for` yapılanmasında biz sonsuz döngüye girdiğimizde birgün çıkmakta isteyebiliriz. İşte bu çıkma operasyonu yani sonsuz bir döngüde denetleme yaparken `for`da çıkmak istiyorsan ileri de inceleyeceğimiz manevratik keywordleri kullanabiliriz. Ya da bizim şartı bir şekilde kontrol edecek yapılanmaya ihtiyacımız olacaktır ve o yapılanmayı da bir şekilde inşa etmemiz gerekecektir.

- Sonsuz döngüye girdim ve sonsuza kadar bir aksiyonu sonsuz boyutta arıyorum ve birgün bulduğunuz anda sonsuz döngüden çıkmanız mı gerekiyor o zaman şart kısmına bağlayıcı bir değişken atamanız lazım. Eğer ki birgün döngü içinde aradığınızı bulursanız işte bu değişkenin tam tersini bu değişkene atarsın. İşte böyle bir durumda burada döngü değişir. Al sana döngü `bool` olduğundan dolayı ilgili `for`un şartını buradaki döngüye bağlarsın. Şimdi normalde senin aradığın aksiyon neyse sonsuzlukta aradığın herhangi bir operasyon olabilir her neyse onu bulana kadar o `true` olana kadar değişkenin değeri değişmeyeceğinden sonsuz döngüye sokacaktır. Bulduğun zamanda içeride değişkenin değeri değişeceğinden dolayı değişkenin tersini alarak döngüye atıyoruz. yani `true` iken `false` oluyor yani burada bir sonraki turda değişkenin değeri değiştiği ve şartı karşılamadığı için sonsuz döngüden çıkmış oluyoruz.

- `while`, `do while`, `for` döngüsü olsun bunlardaki sonsuz yapılanmalarda yapısal olarak fark vardır ama teknik olarak maliyet olsun kaynak tüketimi olsun bunlar gibi durumlara istinaden herhangi bir artısı ya da eksisi olduğu kanaatinde değiliz. Dolayısıyla istediğin herhangi bir döngüyü istediğin herhangi bir noktada kullanablirsin.

***
# 217) While İle Sonsuz Döngü Nasıl Yapılır?
- Sonsuz döngü diyince fıtrat olarak bu olaya en yakın olan `while` döngüsüdür.

- `while` döngüsü yapısal olarak bir sonsuz döngüye girebilecek bunun için zaten öncelikli bir hazırlığa sahip olan döngü diyebiliriz. Nihayetinde direkt şart `true` olduğu sürece sonsuz döngüye girmiş olacaktır.

- `for` döngüsündeki gibi ekstralar olmadığı için ekstradan parametre kısımları vs oladığı için direkt şartı `true` yaptığınızda sonsuz döngüye girebilirsiniz. Herhangi bir patlama durumu yok bişey yok nihayetinde içerideki algoritmada herhangi bir çalışma zamanı hatası almadığınız sürece `while` döngüsüyle sonsuz döngüye zaten direkt giriş yapabiliyoruz. Burada önemli olan sonsuza girdiğimiz zaman `while` döngüsünde bunu nasıl kontrol edebildiğimiz.

- Diyelim ki biz sonsuz bir işlem yapıyoruz ve bir ara bu işlemi sona erdirmek istersek işte burada `while` döngüsünden çıkarmamız gerekecektir. işte böyle bir durumda dışarıda bir durum/state tanımlarız. İşte bu `while` sonsuzluğunun şartını bu değişkene bağlarız. Bu değişkenin değerini içeride değiştirirsem eğer sonsuzu kontrol edebiliyorum. Sonsuz döngüyü. Birgün aradığınız her neyse bulduğunuzu varsayarsak ya da ilgili algoritma bir şekilde gerektiği noktaya vardığını düşünürsek buradaki değişkenin tersini tekrardan değişkene atarak döngüden çıkmasını sağlıyoruz.

- `while` döngüsü ekstradan bir işlem gerektirmeden direkt zaten sonsuz döngüye girme fıtratına sahip. Önemli olan sonsuzu kullanırken iradeli kullanabilmek ve daha da önemlisi olan sonsuzluk esnasında bunu yönetebilmek ve yeri geldi mi bu sonsuz döngüden çıkabilmek.

```C#
#Sonsuz Döngü - While
bool durum = false;
while (!durum)
{
    if (true)
    {
        durum = !durum;
    }
}
```

***
# 218) Do While İle Sonsuz Döngü Nasıl Yapılır?
- `do while` döngüsü bütün operasyonlarda `while`la birebir aynı mantıkta aynı kurallarda çalışmaktadır. `do while`ın yapılanması da/altyapısı da/fıtratı da gene sonsuz döngüye çok yatkındır.

- Önemli olan sonsuz döngünü nasıl kontrol edildiğidir. Hepsinde aynı mantık. Dışarıda bir tane değişken tanımlıyorsun. bu değişkeni şarta bağlıyorsun eğer ki sonsuzlukta aradığın şart geçerli olduysa değişkenin değerinin tersini alıp değişkene atıyarak değiştiriyoruz. böyle bir durum söz konusu olduğunda ilgili sonsuz döngü sona ermiş olacak ve compielr yoluna devam edecektir.

```C#
#Sonsuz Döngü - Do While
bool durum = true;
do
{
    if (true)
    {
        durum = !durum;
    }
} while (durum);
```

***
# 219) İç İçe Döngüler Nelerdir?
- Döngüler içerisinde istediğiniz herhangi bir başka döngüyü ya da kendisinden kendi türünden olan bir döngüyü de başlatabiliyorsunuz ve bunun bir derinliği yok yani bir döngü içerisinde başka bir döngü onun içerisinde de bir başka döngü ve bu şekilde  derinlikleri arttıracak şekilde döngüler tanımlayabiliyoruz.

- Normal bir döngü zaten maliyetlidir. İç içe döngüler daha çok maliyetlidir. 

- Döngü yapılanmalarının içerisinde farklı döngüleri biz programatik olarak yeri geldimi kullanıyoruz algoritmalarıza bazen çok sık yer ederler. Döngüler farklı döngüleri de içlerinde barındırabilmektedirler.

- Durduk yere iç içe döngü kullanmayız. Belirli bir amaca hizmet etmesi için yapıyoruz. O anda çalıştığın algoritma her neyse onun için yaparsın vs. Yani gerektiğinden iç içe döngü kullanırsın.

```C#
#İç İçe Döngüler       
for (int i = 0; i < 10; i++)
{
    for (int i = 0; i < 5; i++)
    {
        while (true)
        {
            
        }
    }
}
```

***
# 220) For İle İç İçe Döngü Oluşturma
- İç içe `for` döngüsü yapılanmasında dikkat edilmesi gereken nokta çok bariz belli değişken isimleri. İçteki ve dıştaki döngülerde tanımlanacak olan başlangıç değerleri olarak kullanacağımız değişkenleri tanımlarken biz bunları farklı isimlerde tanımlamaya dikkat etmeliyiz. Mesela diyelim i değişkeni `for` scope'undan her yerden erişilebileceği için bu scope'un içerisinde bir başka i isminde değişken tanımlayamayız. Temel değişken kuralları burada geçerlidir.

- İç içe `for` döngülerinde değişken isimleri farklı olmalıdır.

<img src="12.png" width="auto">

- Döngü yapılanmasında illa `for` içerisinde `for` `do while` içerisinde `do while` kullanacaksınız diye bir kaide yok. İstediğiniz herhangi bir döngünü içerisinde başka bir döngü kullanabilirsiniz.

- İç içe döngülerde maliyet hesaplarken döngüleri tur sayısını hesaplarız ve birbirleriyle çarparız.

- İç içe döngülerde maliyet tüm döngülerin maliyetinin/tur sayısının/periyodik çalışmasının çarpımına eşittir. Bu çarpım totaldeki maliyeti verecektir.

- Maliyet hesabı türden bağımsızdır.

<img src="13.png" width="auto">

- Zaten sen bir algoritma yazıyorsan buradaki maliyet sayısal olarak bir anlam ifade etmeyecek senin algoritmik düşüncen de yapacağın operasyonda hani olayın ne kadar seyredebileceğini görmeni sağlayacak.

- Diyelim ki elimde bir raf var ve bu rafa kitap dizecem şimdi 3 raf var ve 3 tane de dikey raf var. Dikey raflar ile yatay raflar arasında döngüsel çalışma yaparken ilk döngü 1 tur attığında içerideki döngü tam tur atacaktır.

- Dıştaki döngünün her bir turuna karşılık içteki döngü tam tur atacaktır haliyle burada çarpma vardır. Ve mantığı vardır. Dıştaki bir kere tur atacak içteki tam tur atacak. Kısaca bu maliyet dıştakiyle içtekinin çarpımıdır.

```C#
#İç İçe Döngüler - For
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int o = 0; o < 3; o++)
        {
            int p = 0;
            while (p < 4)
            {
                p++;
            }
        }
    }
}
```

<img src="14.png" width="auto">

***
# 221) Foreach Bir Döngü mü?
- Döngülerin aralarındaki farklar aslında mantıksal değil yapısaldır.

- `foreach` bir döngü değil bir iterasyondur.

- Döngü dediğimiz yapılanma bir kombinasyona bağlı bir şekilde çalışıp bir koşulun doğrulanması sürecinde periyodik işlemler yapan yapılanmalardır. Halbuki iterasyon böyle bişey değildir ne kombinasyona bağlıdır ne de şarta bağlıdır. İterasyon dediğiniz itere edebileceği bir sonraki veriyi getirebileceği bir yapılanmadır. Onun için iterasyonlar döngü değildir itere eden yapılanmalardır. 

- Döngü : Belirli bir kombinasyon eşliğinde çalışan ve belirli bir şarta bağlı olan periyodik işlemler gerçekleştiren yapılanmalardır.

- Döngü dediğin yapılanma şart ve kombinasyondan ibarettir.

- İterasyon : İterasyon mantığında ne kombinasyon ne de şart vardır. İterasyonda; sonraki veri, öteki veri anlamına gelen itere etme fiili vardır. Bir veri kümesi üzerinde işlem yapmamızı/verileri elde etmemizi sağlayan yapılanmadır.

- İterasyon felsefesini/kavramını/stratejisini/mantığını benimsemiş yapılanmalarda ne kombinasyon (bir matematiğe göre çalışırsınız) vardır ne de şart vardır. Orada tek olan şey bir veri bütünüdür. Verilerin itere edilebilir yani itere sonrakine geçiş yapabileceği bir kavram vardır orada.

- Kombinasyon falan yok iterasyon bir veri kümesinde verileri tek tek sana elde etmeni sağlıyor.

- Bir kombinasyon bir şart yok onun için döngülerdeki esneklik iterasyonlarda olmayacaktır.

- Döngülerde herhangi bir veri kümesi üzerinde döngüyle dönerken istediğimi noktadan başlayabiliriz ama iterasyonda başlayamazsınız iterasyon baştan başlar ve sona kadar gidecektir.

- `foreach` her ne kadar iterasyon olsa da döngü gibi kullanıldığını da farkedeceksiniz.

- Her döngü işlemi yapan sistem döngü değildir.

<img src="15.png" width="auto">

***
# 222) Döngülerde Neler İnceledik Özetleyelim
- Nedir Bu Döngüler?
- Ders8.2‘Hangi Döngü Nerede Kullanılır?’ Yanlış Bir Sorudur! Doğru Soru ‘Hangi Döngü Nereye Yakışır?’
- For Döngüsü
    * İnceleme 1
    * İnceleme 2
    * İnceleme 3
    * Örnek 1
    * Örnek 2
    * Örnek 3
    * Varyasyonları
        1. Varyasyon
        2. Varyasyon
        3. Varyasyon
        4. Varyasyon
        5. Varyasyon
        6. Varyasyon
        7. Varyasyon
        8. Varyasyon
- While Döngüsü
    * For İle Kıyaslama
    * İnceleme 1
    * İnceleme 2
    * İnceleme 3
    * İnceleme 4
    * İnceleme 5
- Do While Döngüsü
    * While İle Kıyaslama
- Scopesuz Döngüler
- Sonsuz Döngüler
    * For
    * While
    * Do While
- İç İçe Döngüler
    * For
- Foreach Bir Döngü mü?
- Özet