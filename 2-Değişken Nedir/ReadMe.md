***
# 36) Değişken Nedir? Bir Programcının Değişkene Neden İhtiyacı Olur?

- Bizler yazılım oluşturacağız peki amaç yazılım oluşturmak mı? hayır amaç ne : Elimizdeki verileri oluşturduğumuz yazılımlarla doğru bir şekilde işleyip sonuçlar elde edebilmek.

- Sen Facebook'ta yapsan, Twitter'da yapsan, Instagram'da yapsan xyz bir muhasebe uygulaması da yapsan farketmiyor elinde bir veri var varolan bu veriyi doğru bir şekilde işleyip çıktısını almak senin amacın/çaban/gayretin.

- Amaç burada bir veriyi doğru bir şekilde işleyebilmek doğru bir şekilde işlerken bu veriyle ilgili operasyonları gerçekleştirebilmek yazılımın amacı budur hangi yazılım olursa olsun.

- Değişken bu yazılım sürecinde bir amaca hizmet eden yapılanmadır.

- Yazılımlar verileri doğru bir şekilde işleyip çıktı veren yapılanmalardır. Burada merkeze veriyi alırsak bu veri yazılımın neresindedir? İşte işlenecek bir veri var ve bunu yazılımda bir yerde tutmam lazım.

- Bilgisayarda RAM dediğimiz bir kısım vardır. RAM'e geçici bellek ya da önbellek deriz. O anki çalıştığımız verileri RAM'e koyuyoruz.

- Dolayısıyla işlem yapma esnasında işlem yapılan/işlenen veri RAM'de tutulur.

- RAM kendi içerisinde bölümlere ayrılmış bir yapılanmaya sahiptir.

- Yazılımda biz şunu yapıyoruz diyoruz ki kardeşim benim elimde 5 diye bir değer var bu 5 değerini benim RAM'e koyup oradan daha sonra yazılımda işleyebilmem gerekiyor. Yazılımın RAM'deki bu 5'i alabiliyor kendi bünyesinde işleyebiliyor ya da ürettiği 5'i yine RAM'e koyabiliyor.

- Yani yazılım veri tutmaz. Yazılım veriyi RAM'den alır RAM'e yerleştirir. Yazılım da veri tutulmaz RAM'de tutulur.

- Yazılım da yapılacak işlemlerin en küçük en merkezi noktası olan veriyi biz RAM'de tutarız.

- Bir yazılımda işlenecek veriyi RAM'de tutabilmek için değişkenler kullanılır...

- Değişken dediğimiz yazılım adına RAM'e veri koymamızı ve ihtiyaç doğrultusunda o RAM'deki veriyi elde etmemizi sağlayan yapılardır.

- Yani sen bir veriyi işleyebilmek için o veriyi yazılıma koyabilmen için onu gidip RAM'e koyman lazım o yazılım adına. İşte o yazılım adına veriyi RAM'e koyan yapılanmaya değişken denir.

- Adı üstünde değişken değişebilir.

- Bir programcı verisini tutabilmek için değişkene ihtiyaç duyar.

- İşlenecek veriler veritabanında tutulur doğru ama siz yine bunu işleme esnasında yine bu verileri RAM'e almamız gerekecektir.

- İşlem boyutundayken veritabanındaki bir veriyi sen işleyemezsin. RAM'deki veriyi işleyebilirsin.

- Biz iş yapıyorsak %100 RAM'de çalışmalıyız.

- Bir yazılımın RAM'de çalışabilmesi, RAM'e değer koyabilmesi, RAM'deki bir değeri elde edebilmesi için değişkenleri kullanacağız.

- Değişken bir programcının yazılımda işleyeceği veriyi RAM'de o program adına tutabilmesi için kullandığı bir yapılanmadır.

- Yazılımda işlenecek veriyi yazılım adına RAM'e yerleştirebilmek için biz programcılar değişkenleri kullanırız.

<img src = "1.png" width="auto">

***
# 37) Value Type - Primitive Type - Değer Tipli Değişkenler
- Değişkenler bilgisayarda yazılım adına RAM'de veri tutan yapılardır. Yeri geldi mi bu değerler üstünde işlem yapmamızı sağlayan bu değerleri elde etmemizi sağlayan yeni üretilen değerleri yazılım adına tekrardan RAM'de depolamamızı sağlayan yapılardır.

- Yazılımda çalışırken değişken sayesinde yazılımda işleyeceğiniz veriyi değişken vasıtasıyla RAM'e yerleştirip orada işleyeceksiniz ya hani işlerken RAM üzerinde tutmanız gerekecek ya Dolayısıyla RAM diyor ki bize ya kardeşim sen bana vereceğin değerin türünü bildirmek zorundasın.

- C# programlama dili diyor ki benim RAM'e yerleştireceğim verinin türü neyse onu başta bildirmen gerekiyor ki ben ona göre bir alan tahsisinde bulunayım.

- C# programalama dilinde mantık şöyledir. RAM'de örneğin int bir alan tanımlanırsa oraya sadece int türde bir değer atanmak zorundadır.

- C# diyor ki ya kardeşim senin vereceğin değeri benim RAM'e yerleştirebilmem için bu değerin nasıl koyulacağını int mi, string mi, char mı, ahmet mi, mehmet mi senin burada bildirmen gerekiyor. İşte burada türler karşımıza çıkıyor.

- C# programalama dilinde RAM'de veri tutabilmek/depolayabilmek için tanımlanacak olan değişkenin türü/veri türü bildirilmelidir.

- Diyelimki bir değeri işliyoruz ve bu değer için değişken tanımlıyoruz. Ben değeri hangi türde gönderiyorsam yani hangi türü tahsis ediyorsam o türde bir alan tahsis edilecek ve ona göre ilgili alanda tutulacaktır.

- Tür elimizdeki veriye göre bildirilir.

- Elimizdeki verinin türünü elimizdeki veri belirliyor. RAM'de hangi değeri tutacaksan o elindeki veriden türü çıkartıyorsun.

- C# RAM'e diyor ki ya kardeşim ben bu veriyi işleyecem böyle bir alan tahsisinde bulunmak istiyorum oraya bu veriyi koyacam bu verinin türü şu. İlgili RAM'e o türde bir alan tahsisinde bulunuyor.

- Bir değişkenle RAM'de alan tahsisinde bulunulduğunda buna Değer türlü değişken diyoruz. Yani yuttuğu değer bir normal değer olan değişkenlere Değer türlü denmektedir.

- RAM'de alan tahsisi bulunan bu değişken içerisinde 3, 5, hüseyin, hilmi gibi değerler tutuyor. Değişken içerisinde değer tutar. İşte tuttuğu değerin karşılığında bir alan tahsisi yapan değişkenlere biz Değer Türlü değişkenler diyoruz. Normal bir değer 3, 5, yaşın, adın, doğum tarihin gibi normal değerler.

- Referans türlü değişkenler değer tutmaz değerden daha fazlasını tutarlar.

- Örneğin bir değişken var benim adımı tutuyor bu değer türlüdür çünkü adım bir değerdir. Ama bir değişken daha var komple beni tutuyor. Ha ben bir değer değilim değerlerin bütünüyüm. Adım, yaşım vs var. 

- Hem adım hem ben birer veriyiz ama adım bir değer türlü veriyken ben farklı bir veri türüyüm biz buna nesne deriz. İşte nesneleri tutan değişkenlere de referans türlü değişken diyeceğiz.

- Değer türlü değişkenler sade ve sadece bir değeri tutan değişkenlerdir. Yani adimiz, soyadimiz, doğum tarihimiz gibi değerleri tutarlar. 

- Adının yaşının doğum tarihinin hepsinin bir değeri var yaş sayısaldır. adın metinseldir. adının baş harfi chardır. İşte biz bunun gibi yapıları tutan değişkenlere değer türlü değişken diyeceğiz.

- Primitive Type en ilkel türdür. Primitive yani türetilmemiş ham sade bir veri. Örneğin byte bir primitive türdür. Lakin byte'lardan meydana gelmiş olan decimal türü ise primitive değildir byte'lardan türemiştir. Lakin value type'dır...

- Hiçbirşey olmasa bile var olan tür Primitive türdür. Mesela decimal olabilmesi için byte'ların olması gerekir. byte'lardan meydana gelen decimal normal value type'dır. byte ise tek başına bir veri hiçbirşey olmadan tek başına varolan bir tür olduğu için primitive dir. Bir yandan da value type'dır.

- Value typelar primitive typler'ı kapsarlar.

- Değişken tanımlarken RAM'e tutulacak veriye uygun bir alan tahsisinde bulunulması gerekmektedir. RAM'de alan tahsisinde bulunabilmek için ilgili değişkenin türünden hareket edilir.

- RAM'de alan tahsisinde türü belirlemek yine değişkenin türünden belirlenecektir.

- Bir türde tanımlanmış alana farklı bir türde değer atayamazsınız.

- RAM'de değişkenler sayesinde değer tutabilmekteyiz. Değişkenler değer türlüyse yani değer tuttuğumuz değişkenlerse bu değerin karşılığını türünü RAM'e bildirmek zorundayız.C#'ta RAM diyor ki ya kardeşim ben senin tutacağın veriyi ben bilmem sen bana bildireceksin ben buraya bir veri koyacam sen bunun altın mı dolar mı gümüş mü olacağını ne olduğunu bildireceksin ki ben ona göre koyup ona göre sana geri vereyim. Dolayısıyla burada değişkenlerdeki türler RAM'de tutulacak verilerin hangi türde olduğunu bildiren yapılanmalardır. Biz bunları bildirmek zorundayız. RAM'de çalışırken hangi türlerle çalıştığımızı bildirmek zorundayız.

<img src = "2.png" width="auto">

- string metinsel ifadeleri tuttuğumuz değişken türüdür.

- Sayısal türlü değişkenlerin maksimum ve minimum değerleri vardır bu aralıklarda değişkenlerin değerlerini girebilirsiniz. Elinizde tutacağınız sayısal ifadenin boyutuna göre değişken türünü belirlemelisiniz. 

- Mesela 3 değerini tutacaksınız. byte'da tutabilirsiniz int'de de ama RAM'de bu kadar alan tahsis etmek var bir de 3'e en yakın sınırlarda olan alanı tahsis etmek var hangisi daha mantıklı/ az maliyetli olacaktır? 
    * Tabiki de kendisine yakın olan yani alana tam sınırında girebilen değişken türünü tercih etmeniz en doğrusu olacaktır. Bunlar optimize kod yazarken/ yazılımın daha hızlı/performanslı çalışması için dikkat ettiğimiz kurallardır.

<img src = "3.png" width="auto">

***
# 38-) Değer Türlü Değişkenlerde Primitive Kontrolü - Isprimitive
- Bir türün primitive olup olmadığını 'typeof(value type).IsPrimitive' ile inceleyebiliriz.

- Bunun için 'typeof' keywordünü kullanıyoruz. 'typeof' keywordünde hangi keywordü/türü denetleyeceksek parantez içine onu yazıyoruz ardından '.' operatörü (member access => üye erişimcisi, kodun devamını getirecek olan erişimi sağlayacak olan bir operatör olduğunu inceleyeceğiz) ile 'IsPrimitive' komutunu çağırarak Primitive olup olmadığını kontrol edebiliriz.

- IsPrimitive komutu verilen türün  Primitive olup olmadığını true ya da false olarak bizlere geri döndürecektir.

- 'decimal' bir primitive tür değildir. Çünkü arkada 'byte''lardan daha doğrusu int türlerden oluşturulur/meydana gelir. Değer türlüdür amma velakin 'Primitive' değildir. Buna nazaran 'int' ve 'byte' hem değer türlüdür hem de  'Primitive''dir Yani herhangi bir başka türden meydana getirilmezler.

<img src = "4.png" width="auto">

***
# 39) Değişken Türleri Nelerdir? Detaylı İnceleyelim
- Değişken türleri değişkenlerde tanımlama yaparken bir değer tutarken RAM'de bunun türünü bildirmemiz gerekiyordu.

- Örneğin ahmet değerini tutacaksam eğer oluşturacağım değişken üzerinden RAM'e kardeşim ben sende 'string' türde bir değer tutucam bilgin olsun.

- Sayısal türlerde tutacağınız değer hangi aralığa giriyorsa en yakın aralığa gireni tercih etmeniz uygulamanın bellek yönetimi/maliyeti/performansı açısından her zaman size avantaj sağlayacaktır.

- Örneğin 1000 değerini tutmak istiyorum bunu tutacak olan değişkeni bunu RAM'e koyacak olan değişkeni tanımlarken sbyte ve byte'da tutamayız çünkü aralık dışında kalmaktadır. Amma velakin short veri tipinde tutabiliriz. Biz bunu int'tede tutabiliriz. Amma velakin büyük bir alanı ziyan etmiş oluruz.

- Bir ev yapacaksın yapacağın evin metrekaresi 100m2 olacağını varsayalım ama sen 500m2 lik bir alanı harcıyorsun oraya beton döküyorsun ne kadar mantıklı olabilir? Programlama da aynı şekilde tutacağın değer neyse ona en yakın sınırdakini tutta bari geri kalan alanlara daha rahat başka alanlar tahsis et. 

- Biz yazılımcılar bonkör insanlar değilizdir. Yani mümkün mertebe işi sınırlandırırız. En uç noktada işi törpüleriz ki fazladan bir açık/sızıntı/lüzumsuz bir veri tahsisi söz konusu olmasın. Biz cimriyizdir yani bellekte bir alan tahsis ederken mümkün mertebe elimdeki veriye uygun olanı tahsis ederim lüzumsuz yere alanlar tahsis ediyorsam ben kötü programcıyımdır.

- Profesyonel hayatta aradaki farkları tolere etmeniz bellok optimizasyonu açısından da ciddi bir fark yaratacaktır.

- string metinsel ifadeleri tuttuğumuz değişken türüdür. char'da ise sadece tek bir karakter tutabiliriz.

<img src = "5.png" width="auto">

***
# 40) C# Temel Kuralları
- Main fonksiyonun {} parentezleri arasında biz kodlamayı öğreneceğiz.

- {} => Scope/faaliyet alanı

<img src = "6.png" width="auto">

## C# Dil Özellikleri
1. C# programlama dili büyük küçük harf duyarlılığına sahip olan bir dildir. => Ahmet AhMet ahmet AHMET bu dördü birbirinden farklıdır.

2. C# programlama dili tip güvenliği olan bir dildir. RAM'e değişken aracılığıyla koyacağımız verinin türünü önceden bildirmemiz gerekiyordu. Bildirmeden hareket edemiyorduk illa bildirmem gerekiyordu ve bildirdiğim tür ne ise o türde bir veriyi koymam gerekliydi işte buna tip güvenliği denir.

<img src = "7.png" width="auto">

***
# 41) Değişken Tanımlama
- Değişken tanımlamak bir konsept meselesidir.

- Bir değişken tanımlamak istiyorsanız öncelikle değişkenin modelini/prototipini oluşturmanız gerekiyor.

- Prototip : degisken_turu degisken_adi; => ilk olarak değişkenin türünü bildiriyoruz daha sonrasında ise değişkenin adını ve en son ; ile konsepti kapatıyorum.
    * int x;
    * string adi; Bu uygulama derlendiğinde bellekte string türde adi isminde bir değişken tanımlanmış olacak.
    * int yas; Derlendiğinde bellekte int türünde yas isminde bir alan tutacaktır. 

<img src = "8.png" width="auto">

```C#
#region Değişken Tanımlama
    int yas;
    bool medeniHal;
    string soyadi;
#endregion
```

<img src = "9.png" width="auto">

***
# 42) RAM'in Yapısı(Stack)
- Temelde iki tane yapılanmadan oluşmaktadır.Bu yapılanmalar Stack ve Heap'tir.

- Bu yapılanmalar RAM'in temelde kullandığımız iki alanıdır.

- Stack => İçerisinde değer türlü değişkenleri tutabildiğimiz bölümdür.

- Heap => Nesneleri tutabildiğimiz bölümdür.

<img src = "10.png" width="auto">

- RAM'in yapısında birçok bölüm vardır. Bunlardan bir tanesi Stack'tir. 

- Stack içerisinde farklı değerler tutabilmektedir. İçerisinde tuttuğu yapılar;
    * Değiken türü, adı ve değeri
    * Metot isimleri(Bellek adresleri)

- Stack sadece değişkenin değerini değil ,değer türlü değerleri değil Değer türlü değişkenleri de burada tutuyor bunların türlerinin bilgisini de burada tutuyor ve aynı zamanda adlarını da tutmaktadır.
    * int a = 5 => hepsi Stack'te tutulur
- Stack'te tutulan değişken ismini nadirde olsa referans dendiğini görebilirsiniz.(Değer türlü olsa bile)

- a referansı dendiğinde tuttuğu değere referanslık eden isim.

- Metotların bellek adresleri de Stack'te tutulur.

- Metotlarımızı oluşturuyoruz. Metotlar oluşturulduğunda belleğin Stack kısmında tutulurlar. Metodu ismi üzerinden çağırabilirsin o isminin bellekteki karşılık gelen bellek adresi Stack'te tutulur.

<img src = "11.png" width="auto">

***
# 43) Değişkenler RAM'de Nasıl Tutulur?
- Değişkenler koda yazılır yazılmaz alan tahsisinde bulunmazlar kod ne zaman çalıştırılır ne zaman o alan compiler tarafından derlendikten sonra yani runtime'da/calıştırılma anında/çalışma zamanında kodlara karşılık alan tahsisleri gerçekleştirilir.

- Senkronizasyona göre kodu çalıştırdığınızda genellikle yukarıdan aşağı doğru nitelendirilen konsept konsept ilerleyerek bellekte yerler ayrılır.

- Senkronizasyona göre sırayla Compiler Stack'te tanımlama yapar.

- Yani değişkenler sırasıyla konseptte hangisi öncelikliyse o öncelik sırasına göre Stack'te tanımlanacaktır.

- Stack LIFO (Last In First Out) mantığına göre çalışır. Yani Son giren ilk çıkar.

<img src = "12.png" width="auto">

***
# 44) Değişken Tanımlama Kuralları
## Anlamlı İsimlendirme
- Değişken isimleri süreçte developer açısından bir karışıklığa mahal vermemek için anlamlı olmalıdır.

- Diyelim ki bir personelin yaşını tutacaksam eğer 'int yas, int personelYas' gibi tutacağım değerin anlamını ifade eden bir isim vermem developer sürecinde bize çok faydalı olacaktır.

- Eğer anlamsız bir isim verirsem yaş tutacağın değişkene 'int x, int y, int huseyin' gibi saçma sapan değerler verirsen bu süreçte inanılmaz bir karışıklığa yol açacaktır.

- Kod yazma iradesi bizde ben neyi nerde tuttuğumu düzenli bir şekilde isimlendirebilme hakkına sahibim. Siz bu iradenizi hakkınızı kullanacaksınız anlamlı isimlendirme yapacaksınız.

- Ne yazık ki bazen gerçekten yazılan kodlarda sembolik terimler kullanılan kodlarla karşılaşacaksınız. Bunun gibi karışıklığa sebeb olan şeyler hem sizin açısından hem de başka bir developer açısından kodun analizini yaparken ciddi manada sıkıntı oluşturucaktır. Keza sonraki süreçte kodu yazma esnasında yukarılarda tanımlanan bir değişkeni kodun aşağılarında bir yerlerde çağırmaya çalıştığınızda bile ciddi manada sıkıntı yaşabiliyorsunuz. Kompleks algoritmalarda değişkenlerin isimlerinin anlamlı olmasına özellikle dikkat edeceğiz.

<img src = "13.png" width="auto">

## Özel Karakterler
- Değişken isimleri ' , . vs. gibi özel karakterler barındıramazlar!

- '_' karakteri istisnadır.

- '_' özel karakterler arasında değişken isimlerinde kullanabildiğimiz yegane tek bir özel karakterdir.

<img src = "14.png" width="auto">

## Sayısal İfadeler
- Değiken isimleri sayısal ifadelerle başlayamaz!

- Lakin sayısal ifade barındırabilir.

- Bir scope içerisinde aynı isimde birden fazla değişken TANIMLANAMAZ

<img src = "15.png" width="auto">

```C#
Değişken Tanımlama Kuralları
    //1.Anlamlı isimlendirme
    int yas;
    int personelYas;
    int x;
    int y;

    //2. Özel karakter olmamalı!
    double stok_adedi;
    // double ?av;

    //3. Sayısal İfadeler 
    int sayi1;
    int sayi2;
    // int 3sayi;
        
    //4. Bir scope içerisinde aynı isimde birden fazla değişken TANIMLANAMAZ
```