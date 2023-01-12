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

***
# 45) İsimlendirme Kuralları - Name Convention(Pascal Case/Camel Case /Snake Case)

<img src = "16.png" width="auto">

## Pascal Case
- Her kelimenin ilk harfi büyük yazılmalıdır.
    * AdSoyad
    * TcKimlikNo
    * Satislar
    * DogumTarihi

<img src = "17.png" width="auto">

- Kısaltma iki harfliyse her iki harfte büyük yazılmalıdır.
    * In/Out = IO
    * InOutStream = IOStream

<img src = "18.png" width="auto">

## Camel Case
- İlk kelime haricindeki tüm kelimelerin baş harfi büyüktür.
    * satisDurumu
    * personelAdi
    * orderId
    * userName
    * user
    * userNamePassword

<img src = "19.png" width="auto">

## Snake Case
- Tüm kelimeler küçük olarak başlamalı ve araları _ karakteri ile ayrılmalıdır.
    * kullanici_adi
    * isim_soyisim
    * personel_giderleri

<img src = "20.png" width="auto">

***
# 46) Değişken İsimlerini @ Operatörüyle Tanımlama
- Bir değişkenin ismi sade bir şekilde de olabilir ya da başına @ işaretini koyduğumuzda da olabilir.

- @ işareti kelimenin başında özel karakter anlamına gelmemektedir. Ama kelimenin içinde kullanırsanız özel karakter anlamına gelmektedir hata alırsınız.

- Değişken isminin başına getirilen @ özel bir karakterden ziyade anlamlı bir karakter haline geliyor.

- Değişken isimlerinde programatik keyword kullanılmaz! Eğer ki bir değişken isminde programatik olarak kullanılan bir keywordü vermek istiyorsanız eğer bunu @ operatörü ile ezebilir ve öylece verebilirsiniz.

- Eğer ki programatik keyword kullanacaksanız başına @ işareti koyarak programatik keywordü ezebilir ve artık o keyword programatik keyword değil normal bir metin olduğunu ifade edebilirsiniz. 

- @ operatörü ile anlamlı keywordleri değişken ismi olarak kullanabiliyorsunuz.

- Programlama da bir keyword'e karşılık gelen metini değişken ismi olarak kullanmak istiyorsanız onun başına @ işaretini/operatörünü koymanız gerekmektedir.

<img src = "21.png" width="auto">

***
# 47.1) Tanımlanmış Değişkene Değer Atama
- Tanımlandıktan sonra değer atayabiliriz çünkü bir değişken tanımlamadan değer atayamayız.

- Tanımladığımız değer türlü değişkenler, değerleri, tür bilgileri belleğin Stack kısmında tutulur.

- Tanımlama esnasında değişkene değer atayacaksam eğer assign/atama operatöründen(=) faydalanırım Örneğin `int x = 5;` 

- Assing(=) operatörü atama işleminin sorumululuğunu üstlenir.

| int | = | value |
|---|---|---|

- `=` Assign operatörü diye geçer atama operatörüdür. Matematikteki = ile alakası yoktur. Matematikte 3 = 3 dediğimiz operatör oradaki eşitlik anlamına gelir. Yazılımda ise C# dilinde `=` operatörü atama yapar

- `=` Assign operatörü sağdaki tarafra verilen değeri soldaki değişkene, field, property'e vs. atar.

- Bir değişkene değer atayacaksanız değişken sol tarafta olmalı atayacağınız değer sağdan gönderilmelidir. Assign operatörü (`=`) sağındaki değeri soldundaki değişkene gönderecektir.

- Bir değişkene değer atarken bellekte ilk olarak verdiğin türde bir alan tahsisinde bulunulur ve compiler kodu işlerken daha sonlandırmadan atayacağın değeri burada tahsiste bulunulmuş alana atar.

<img src = "22.png" width="auto">

- Normalde değişkeni tanımlarken sadece tanımlayacaksam konsepti değişken adının sonunda `;` ile sonlandırıyorum. Yok eğer tanımlama yaparken değer de atayacaksam artık değerin sonunda `;` ile konseptimi sonlandırıyorum.
    * `int x;` 
    * `int x = 123;`

<img src = "23.png" width="auto">

- Eğer ki bir değişken ismi assign operatörünün(`=`) solunda çağırılıyorsa o alana değişkenin kendisi gelecektir. Yani o alan tahsisi gelecektir. Onun için senin atadığın değer ilgili değişkene yani oradaki alana gönderilmiş olacaktır.

- Değişken ismi assign operatörünün(`=`) soluna geliyorsa oraya değişkenin kendisi gelir değeri atadığında bulunan alan tahsisinin içine değer koyulur.
 
<img src = "24.png" width="auto">
<img src = "25.png" width="auto">
<img src = "26.png" width="auto">
<img src = "27.png" width="auto">

- Dikkat 
    * Bir değişkene atanan en son değer geçerlidir.
    * Eğer atama varsa tahsis edilen alandaki tutulan değer değiştirilir. Yeni bir alan tahsisinde bulunulmaz. Yani tutulan değer ezilir.
    ```C#
        int a = 5;
        a = 15;
        a = 20;
    ```
<img src = "28.png" width="auto">

# 47.2) Tanımlanmış Değişkene Değer Atama
- Tanımlanmış olan değişkene türüne uygun bir değer atılmalıdır.

- değişken int ise int değer, string ise string değer atanmalıdır. 

<img src = "29.png" width="auto">

***
# 48) Değişkene Değer Atama Kuralları
- 4 Kategori de değer türlerimiz var 
    * Metinsel Değerler
        - `string` keywordü ile tutulmaktadırlar.
        - `string` keywordunde tutulan metinsel değerler çift tırnak(`"...."`) içerisinde tutulmalıdır.
        - `"Musa"`, 
        - `"12345678901"` Bir sayısal ifade metinsel olarak tutuluyorsa eğer yazılım açısından o metinsel bir ifadedir. Yani üzerinde matematiksel işlem yapılmayan ve `"Hüseyin"` `"Ahmet"` vs. gibi metinsel ifadelerden farkı olmayan bir değerdir.
        - Metinsel ifadelerde herşeyi tutabilirsiniz. Örneğin `"Musa 23 Yaşındadır."`
        - Çift tırnak (`""`) içerisine yazılan tümmmm değerler string keywordüyle karşılanmalıdır.  `string x = "asfsafasdafasf";`

    * Karaktersel Değerler
        - `char` keywordü ile tutulmaktadırlar.
        - Karaktersel değerler tek tırnak(`''`) içerisinde yazılmalıdır.
        - Örneğin `char x = 'M';`, `','`,`'.'`,`'?'`
        - İçerisinde sadece tek bir karakter barındırabilir.

    * Mantıksal Değerler
        - `bool` keywordü ile tutulmaktadırlar.
        - Mantıksal ifadeler direkt olarak `true` ya da `false` ile belirtilir.
        - Örneğin `bool medeniHal = true;`
        - `true`:1'e karşılık gelir yani doğruya karşılık gelir.
        - `false`:0'a karşılık gelir yani yanlışa karşılık gelir.

    * Sayısal Değerler
        - Değer babında en kompleks değerlerdir diyebiliriz. Çünkü çok fazla sayısal değerimiz var.
        - Sayısal ifadelere değer atarken direkt olarak değeri göndeririz.
        - Sayısal ifadelerde bir değer default/varsayılan olarak integer(`int`) kabul edilir.
        - Örneğin `1000`

    * Ondalıklı Sayılar
        - Tümm ondalıklı sayıları karşılayabilirler. 
        - `float`, `decimal`,`double`
        - `float` türünde bir küsuratlı değer tutarken ilgili değerin sonuna f ya da F getirilmelidir. örneğin `3.14f` ya da `3.14F` `float f = 3.14f;`
        - `double` türünde bir küsuratlı değer tutarken ilgili değerin sonuna d ya da D getirilmelidir. örneğin `3.14d` ya da `3.14D`
        - `decimal` türünde bir küsuratlı değer tutarken ilgili değerin sonuna m ya da M getirilmelidir. örneğin `3.14m` ya da `3.14M`
        - Ondalıklı türlerde bir değer default olarak `double`'dır ve default olduğundan dolayı ondalıklı bir değeri double ile tutarken d ya da D'yi kullanmak zorunda değiliz!

<img src = "30.png" width="auto">

- Soldaki tür neyse sağdaki değerle/değerin türüyle eşdeğer olmalı. 

- Bir sayısal tür değer aralığına girmeyen değeri tutamaz! Compiler hata verir!

- Sayısal ifadelerin kendi aralarında tür dönüşümü sırasında veri kaybı soz konusu olabilir.

- Dolayısıyla değeri karşılayabilecek en uygun tür neyse onda tutulması mantıklıdır.

<img src = "31.png" width="auto">
<img src = "32.png" width="auto">

***
# 49) (_a, _b) = (a, b) Tuple Türüyle Değer Atama
- Tek bir syntax üzerinde birden fazla değişken tanımlamamızı sağlayan bir nesnedir.

- Örneğin; `(int a,int b,type c, type d,...)z;`

- Tuple değişkenin içerisinde birden fazla aynı türde veyahut farklı türde değişken tanımı olur.

- Tuple dediğimiz nesne içerisinde bir veya birden fazla nesne tanımlayabildiğimiz tek bir tanımlık nesnedir.
    * `(int a,string b) c = (5,"ahmet")` 
    * bizim bunlara erişebilmemiz için `c.a` => değişkeni getirecektir. `c.b` => string türdeki değişkeni getirecektir.

<img src = "33.png" width="auto">

- Tek bir değişken içerisinde birden fazla değişken tutan konsept tuple konseptidir.

- Tuple Stack'teki davranışı diğer değişkenlerde olduğu gibi aynıdır.

- Nesnenin değerden farkı değerlerle bir araya gelmesidir.

- Tuple nesne olarak tutulur.

- Oluşturduğumuz değişkende sıralı bir şekilde yani buradaki değerlere karşılık gelecek şekilde değerlerini atamak zorundayız.

```C#
    (_a, _b) = (a, b) Tuple Türüyle Değer Atama
    int a = 5;
    int b = 10;

    (int x,int y) c = (5,10);
    (int yas,string adi,bool medeniHal) kisi = (23,"Musa",true);
    kisi.yas = 5;

    (int x,char y) z;

    z = (5, 'a');
```

***
# 50) Literal Düzenlemeler(C# 7.0)
- Kompleks sayısal ifadeleri _(Alt tire) ile düzenlememizi sağlayan özelliktir. `int sayi = 1_000_000;`

- Değişkenlerimizin değerlerini alt tire(`_`) ile daha görsel daha hoş okunabilir semantik kullanabiliriz.

***
# 51) Değişken Türüne Uygun Default Değer Atama
- Tüm değişkenlerin bir default değeri vardır.

- İleride OOP dediğimiz yaklaşımı gördüğümüzde class içerisinde tanımlanan değişkenlerin default değerlerinin otomatik atandığını konuşacağız...

- default keywordü : içerisine verilen türün varsayılan değerini geriye döndürür.

- Main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz.

- Main içerisinde oluşturduğunuzun ilk değerlerini Compiler kendisi veremez. Class'ta verir


- Metinsel değerlere null atanır null değersiz demektir. Null ile boş arasında fark vardır. Null boş demek değildir. Boşluk space dediğimiz bir karakterdir. Null değeri yok anlamına gelir.
    * `string` : `null`
    * `char` : `\0`
- Sayısal ifadelerin hepsinde varsayılan 0 söz konusudur.
    * `int` : `0`
    * `float` : `0`

- boolean'da ise false'tur.
    * `bool` : `false`

- Elimizdeki değişkene default değerini biz atamak istersek `default(değişken türü)` 'nü atama yaparız.
    * `bool x = default(bool)`
    * `int y = default(int);`
    * `string z = default(string);`  	
    * `char c = default(char);`

<img src = "34.png" width="auto">

```C#
//default keywordü : içerisine verilen türün varsayılan değerini geriye döndürür.
bool x = default(bool);
int y = default(int);
string z = default(string);
char c = default(char);
//Main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz.
// Main içerisinde oluşturduğunuzun ilk değerlerini Compiler kendisi veremez. Class'ta verir
```

***
# 52) Default Literals (C# 7.1)
- C# 7.1 versiyonuyla gelen Default Literals özelliği sayesinde biz değişken türlerine uygun default değerleri atarken kullandığımız `default` keywordünü daha spesifik halde kullanabilmekteyiz.

- Önceden default keywordünden sonra parantez içinde türü belirtirken artık bu şekilde değilde direkt default keywordüyle değişken tipine uygun default türü atamaktadır. 

- `default` keywordünü hangi değişkene karşı assign ediyorsan otomatik sana o değişkenin varsayılan değerini geri döndürecektir.

```C#
bool x = default;
decimal y = default;
```

***
# 53) Tanımlanmış Değişkenin Değerini Okuma
- Bir değişkenin değerini okuyabilmemiz için öncelikle ilgili değişkeni tanımlamamız gerekiyor ardından değer atamamız gerekiyor.

- Bir değişkenin değerini elde edebilmek için değişkenin isminden/adından faydalanmaktayız.

- Bir değişkenin adı assing(`=`) operatörünün sağında yahut metotların parametrelerinde çağırılıyorsa ilgili değişkenin değeri gönderilir.

- `Console.WriteLine()` ekrana çıktı veren, ekrana bişey yazmamızı sağlayan bir komuttur
    * Console bir sınıftır/class'tır. Bu sınıfın üzerinden direkt bir member'a erişilebildiği için `static` bir yapılanmadır. Bu static member'ın bir metot olduğunu buna erişirkende static yapılanmadan faydalanıp erişebildiğimizi `.`'nın modifier access operatörü olduğunu metotların parametre alabildiğini ileride göreceğiz.

- `Console.WriteLine(x)` => metodun parametresinde çağrıldığı için x'in kendisi değil değeri gidecektir.

- `int y = x;` => x assign'ın sağında kaldığı için y değişkenine x'in değeri atanacaktır.

- Tanımlanmış değişkenin değerini biz değişkenin ismi üzerinden okuruz. Bu yüzden değişkenin adı anlamlı olmalıdır. 

- Bir değişkende bir değeri alacaksan eğer o değişkenin isminden alacaksın. Yaşını tuttuğun değişkene x maaşını tuttuğun değişkene y dersen ulan x'miydi y'miydi diyene kadar direkt yaş ve maaş isimlerini kullanman daha mantıklı olacaktır. 

<img src = "35.png" width="auto">

***
# 54) Tanımlanmış Değişkenin Değerini Okuma - Kritik 1
- Bir değişken assign operatörünün(`=`) sağındaysa değeri gelir.

- Bir değişken ismi assign operatörünün solundaysa kendini getiriyor.

- Değişkenler sürekli değişebilir amma velakin her zaman bir değişkenin değeri son atanan değerdir. Önceki değerler ezilecek/silinecektir.

```C#
int a = 5;
int b = 10;
int c = b;
int d = a;
b = a;
c = b;
```

<img src = "36.png" width="auto">
<img src = "37.png" width="auto">

***
# 55) Tanımlanmış Değişkenin Değerini Okuma
- Bir değişkenin kendisini kendi değerine atama yaparsak eğer assing operatörünün(`=`) sol tarafında kalan yere değişkenin kendisi yani bellek adresi gelecektir. assing operatörünün(`=`) sağ tarafında kalan yere ise değişkenin değeri yani bellek adresinde tutulan değer gelecektir. ve değişkenin önceden var olan değeri silinecek ve gelen değer değişkene set edilmiş olacaktır.

```C#
int a = 5;
a = a;
```

<img src = "38.png" width="auto">

***
# 56) Değeri Olmayan Değişkenler!
- Bir değişkeni Main metodu içerisinde oluşturduğunuzda bu değişken için Stack'te bir alan tahsisinde bulunuldu amma velakin içerisinde herhangi bir değer yok.
`int a;`

- Class içerisinde tanımladığımız değişkenlerin varsayılan default değerleri atanacaktır. Ve bu default değerlerde;
    * Metinsellerin `null`
    * Sayısalların  `0`
    * Mantıksalların `false`
    * Charların `\0` 'dır.

- Varsayılan değeri olmayan ya da değeri olmayan değişkenle hiç bişey yapamazsınız.

- Örneğin;
    * İlk başta bir değeri olmayan değişkeni bir yerde çağıramazsınız. `Console.WriteLine(a);`
    * Bir başka değişkene değerini atayamazsınız. `int b = a;`

- Class içerisinde tanımlanan değişkenlerde varsayılan değer otomatik atanmaktadır. Lakin main içerisinde tanımlanan değişkenlerde varsayılan değer atanmadığı için böyle boş tanımlanan değişkenlerde ilk değeri manuel vermediğimiz sürece işlem yapamayız!

- Bir metot içerisinde tanımlanan değişkenlerin ilk değerlerini manuel olarak vermeyi alışkanlık haline getiriniz... Çünkü programın rahatça işlenebilir ve kodlanabilir olması için

<img src = "39.png" width="auto">

***
# 57) Değişken Davranışları Genel Bakış(ref için farkındalık)
- Değişken davranışsal olarak RAM'de kendi türüne uygun alan tahsisinde bulunuyor ve bulunduğu alana göre uygun türlerde değerleri o alanda tutup o değerleri o alandan alıp işlememizi sağlıyor. Yani değişken benim yerime yazılımda veri tutan yapılanma.

- RAM'e direkt yazılımcı olarak erişemiyoruz. Aslında erişebiliyoruz yani pointer'ları kullanarak erişebiliyoruz ama bu erişim sürecinde biz değişkeni kullanarak işimizi daha da kolaylaştırıyoruz. Değişkenler bizim yerimize hem bellek optimizasyonu yapıyor hem nerde alan tahsisi yapacağını bilebiliyor. Böylece ilgili türde bir alan tanımlıyor ve verdiğim değeri direkt oraya koyuyor. Sen uğraşmak zorunda kalmıyorsun ve istediğin zaman ilgili değeri sana getiriyor. Yani yazılımda lazım olduğunda da ilgili değeri alıp işleyebiliyorsun. 

- İşte bu süreçte davranışsal olarak değişkenler isimleri üzerinden hareket ediyor.

- Bir değişkenin ismini assign operatörünün(`=`) solunda çağırıyorsak değişkenin kendisini(bellekteki adresini/kısmı/ o alanı) getirir. dolayısıyla bir atama işlemi yapabilirsin o alana. Eğer değişkenin ismini assign operatörünün(`=`) sağında çağırıyorsak değişkenin değerini/bellekteki değeri getirir. Dolayısıyla sen bu değer üzerinde gönderebilirsin/işlem yapabilirsin.
    * Değişkenin Kendisi`a`  `=` Değişkenin Değeri geldi. `a`

- Benzer olarak metotlarda/fonksiyonlarda da aynı özelliği sergilemektedir. 
    * `X(a)` Değişkenin değerini göndermiş olacaktır...

- Değişkenin davranışında değişkenin kendisini göndermesiyle değerini göndermesi arasındaki farkı `ref` keywordünde göreceğiz.

<img src = "40.png" width="auto">

***
# 58) Değişkenlerin Faaliyet Alanları(Scope Kavramı)
- Scope : faaliyet alanı,kapsam.

- Programlama dillerinde Scope değişken ve fonksiyonların kapsadığı context'i belirler

- Değişken ve fonksiyonların erişilebilirlik sınırlarını belirleyen alandır.

- Tanımlamalarda ve algoritmik çalışmalarda karşıklılığı önleyen bir sınır çizer.

- Bir scope'ta tanımladığın bir değişken farklı bir scope'da aynı isimde yine tanımlanabilir ve scope'lar fark yarattığı için karışıklılığı önleyecektir.

- C#'ta scope'lar Süslü Parantez (`{}`) ile ifade edilmektedir.

- Bir scope içerisinde tanımlanan değişkene o scope içerisinde her yerde erişilebilir.(Tabi tanımlandıktan sonra) Aynı zamanda bu scope içerisinde oluşturulan diğer scope'lardan da erişim sağlanabilir. Eğer ki farklı bir scope'dan değişkene erişmeye çalışırsan erişim sağlayamazsın.

- Hatırlarsanız eğer bir scope'da aynı isimde birden fazla değişken olamaz demiştik. Halbuki farkli scope'larda aynı isimde değişken olabilir...

- Scope'lar iç içe tanımlanabilir.

- Scope'lar iç içe erişim gösterebilirken yatay düzlemde erişim gösteremezler.

- Bir değişken sade ve sadece tanımlandığı scope'un içerisinde erişilebilir ve kullanılabilir.

- Bir değişkenin nerede tanımlandığına dikkat edilmelidir. Bir değişkeni nerede tanımladıysanız o erişilebilir olacağı noktayı iyi seçmeniz lazım.

<img src = "41.png" width="auto">
<img src = "42.png" width="auto">

***
# 59) Custom Scope Oluşturmak
- Scope'ların kullanıldığı alanlar;
    * class'lar
    * interface'ler
    * metotlar
    * namespace'ler
    * Akış Kontrol yapılanmalarında (if,switch)
    * döngülerde (for,while,do while)
    * iterasyonlarda (foreach)
    * Hata kontrol yapılanmalrı(try-catch)

- Kendimiz kodun içinde metodu faaliyet alanlarına bölebiliyoruz.

- Herhangi bir koda bağlı olmaz ve istediğiniz kadar Custom Scope oluşturabilirsiniz.
    * `{
            {
                {
                    {
                        {
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    `

***
# 60) Değişmezler/Sabitler(const)
- Bir değeri işleyeceksek bunu RAM'e koymamız lazım bunuda değişkenler sayesinde gerçekleştirmekteyiz.

- Biz kodu inşa ederken yazılımda bir veriyi en doğru şekilde işleyip sonucu üretebilmek. İşleyeceğimiz veri her daim değişiklik göstermeyebilir. Bazen sabit değerlerle de çalışmamız gerekebilir. 

- Hiçbir zaman işin iradesini kul hakkı boyutuna bırakmayacağız.

- Sabitler değişmeyen değerleri/değişmeyecek değerleri/değişmemesi gereken değerleri tutmak için oluşturulmuş yapılardır.

- Bazen kod yazarken bazen katsayılarınız matematiksel sabitleriniz olacak. Örneğin en barizi Pi sayısıdır. Eğer sen yapmış olduğun uygulama da Pi sayısıyla ilgili işlem yapıyorsan bunu değişkene değil sabite ataman lazım. Çünkü yanlışlıkla Pi değerini değiştirirsen yapacağın hiçbir hesabın tutmayacağına eminiz.

- Süreçte var olan değeri değiştirilemez, değiştirilmeye çalışıldığı taktirde compiler tarafından hata verilir. 

- Bir değişkene koyduğun değeri süreçte değiştirebiliyorsun ama sabite koyduğun değer bir tanedir. Ondan sonra süreçte sen onu değiştiremezsin korunaklıdır o değer.

<img src = "43.png" width="auto">

- `const` keywordüyle sabitlerimizi tanımlayabiliyoruz.

- Constant

- Değişmeyendir.

- Prototip olarak değişkenlere çok benzer lakin davranışsal olarak değeri bir daha değiştirilemez.

- Özünde static yapılanmadır.

- Sabit değerlerimizi tutacağımız değişkenlere biz Constant diyeceğiz.

- Sabitler ilk değerini alır bir daha değişmez.

<img src = "44.png" width="auto">

- Static Uygulama bazlı veri depolayabildiğimiz bellekte bir alandır. Bu alana bir değer koyabilmen için senin bunu `static` keywordüyle işaretlemen gerekir.

- RAM'in alanları;
    * Stack
    * Heap
    * Static

- Static alana koyulan bir değer/değişken evrenseldir. Scope dinlemez. uygulama bazlıdır. Yani sen her yerden ona erişip işlem yapabilirsin.

<img src = "45.png" width="auto">

- static değişkenler adı üzerinde değerleri değişebilir lakin constlar sabittir.

- const fıtrat olarak bir static'tir. Ama sabit olan bir statiktir. Yani yapısal olarak static'te tutulur.

- static değişkenlerde adı üzerinde değeri değişebilen static değişkenlerdir. Static'te olsa değişkendir nihayetinde.
 
- İleride static konusunu incelerken biz orada nesneyi de bilmeliyiz. Nesne üzerinden erişilebilir yapılarla nesneye ihtiyaç duyulmayan yapılar arasında farkı static koyacaktır.

<img src = "46.png" width="auto">

- `readonly` sadece okunabilir değişkenler tanımlamaktır.

- const'tan farkı sadece tanımlandığı yerde değil, ayrıca constructor içerisinde de değeri atanabilir. Dependency Injection deseninde çok sık tercih edilir.

- Eğer ki const ile bir değişmeyen tanımlıyorsanız tanımlama aşamasındayken değerini atamak zorundasınız başka bir varyasyon yok ama readonly'de constructor dediğimiz bir metot olacak bunun içerisinde de değer atayabiliyorsunuz ya da anında atayabiliyorsunuz. Başka yerde atama yapamıyorsunuz.

- const diyor ki ben tanımlanır tanımlanmaz bana değer atamalısın readonly diyor ki ben tanımlanır tanımlanmaz bana direkt değer atamalısın ya da bir tek constructor'da atayabilirsin. Başka bir yerde atayamazsın.

- ayrıca static değildir readonly

- constlar tanımlanır tanımlanmaz değerlerini almak zorundadırlar.

<img src = "47.png" width="auto">

- Senin oluşturduğun bir değişkenin değerini senin kodunu kullanan başka bir developer'a değiştirtmemen gerektiği durumlarda onu const yaparız.

- Değişmemesi gereken değerleri sabitleyeceğiz.

- `const degisken_tipi degisken_adi`

- Bir const tanımlandığında STACK'te ilgili türde alan tahsis edilecektir ve ilk atanan değer dışında bir daha değer kabul etmeyecektir.

- const'lar değiştirilemez lakin istenildiği kadar okuanbilir/değerleri elde edilebilir...

<img src = "48.png" width="auto">

- const değişkenler tanımlama aşamasında değerlerini isterler... Aksi taktirde hata alınır...

***
# 61) Global Değişkenler
- Aslında bildiğiniz değişkenin ta kendisi ama konumlandığı/koyulduğu yere göre bir değişken ya global oluyor ya da local oluyor. İsmi değişiyor oradaki sorumluluğu/yapısı/işleyişi değişmiyor.

- Terminoloji de bir değişken class scope'u içerisinde tanımlanıyorsa buna global değişken diyoruz... Method scope'ları içerisinde tanımlananlara da local değişken diyoruz.

- Bir değişken class elemanıysa buna global değişken diyoruz.

- Aslında hangi scope'u baz alırsanız ona göre bir değişken local ya da global olur.

```C#
class Program
{
    //Bir değişken class scope'u içerisinde tanımlanıyorsa buna global değişken diyoruz...
    int a;//Global Değişken
    int b;//Global Değişken
    int c;//Global Değişken
    static void Main(string[] args)
    {
        int z;//Local Değişken

        {

        }
        {
            {

            }
        }
    }
}

```

***
# 62) Değişken Tanımlama Varyasyonları
- Değişkenleri tanımlarken iki varyasyonda değişkenler tanımlanabilmektedir. 
    1. Değişkenin tipini yazıyorsun ve ardından bir isim veriyorsun ister hemen değer atayabiliyorsun istersen daha sonra değer atayabiliyorsun
        - `int a = 5;`
        - `int b = 10;` 
    2. Aynı türden birden fazla değişken oluşturulacaksa eğer bu değişkenleri tek imzada aşağıdaki gibi tanımlayabiliriz. Buradaki varyasyonda da ister hemen değer atayabilir ister daha sonra atama yapabilirsiniz.
        - `int a = 5, b = 10;`
        - Dikkat edilmesi gereken husus aynı türden olmaları gerekmektedir.

***
# 63) Değişkenler Arası Değer Atama Durumları - Deep Copy

<img src = "49.png" width="auto">

- Değişkenler arası değer atanırken verisel açıdan iki davranış söz konusudur.
    * Deep Copy : değeri klonlayıp, tekrar edip, yeniden oluşturup atayabilir.
    * Shallow Copy : yüzeysel bir kopyalama yaparak atama işlemini gerçekleştirebilir.

<img src = "50.png" width="auto">

- Varsayılım ki Stack'te iki tane değişkenimiz olsun değişkenlerden biri a diğeri b olsun ve a 5 değerine eşit olsun ve ardından b değişkenine a değişkeninin değerini atayalım böyle bir durumda b değişkenine a'daki 5 değeri gönderilecektir.

- Deep copy(derin kopylama) neticesinde eldeki veri çoğalır/klonlanır.

- Deep copy dediğimi derin kopyalama net yani varolan bir veriyi derinden kopyalıyor/klonluyor.

- Deep Copy'de eldeki veri çoğaltılır/klonlanır. Eldeki veri bir iken iki olur.

- Mesela koyun doly Deep Copy yapılmıştır. koyunu klonlamışlar/çoğaltmışlar aynısından bir tane daha oluşturmuşlar.

- Mesela telefonlar fabrika da sürekli modeli çoğaltılıyor deep copy yapılıyor Yani eldeki veri çoğalır/klonlanır.

- Temel değişkenlerde değişkenin değerini bir başka değişkene atadığımızda ilgili değer çoğaltılır.

- Deep Copy'de elimizdeki veri çoğalır bu çoğalma neticesinde RAM'de bir tane veri varken aynı veriden bir tane daha olacaktır.

<img src = "51.png" width="auto">

- Değer türlü değişkenler birbirlerine atanırken default olarak deep copy geçerlidir. Yani veri otomatik olarak türetilir.

<img src = "52.png" width="auto">

- Decimal'deki bir 1000 değerini farklı bir decimal değişkene ya da farklı bir sayısal değişkene gönderirken oradaki değer yeniden üretilecek ve yeniden o değişkene gönderilecektir. Yani derin bir kopyalama yapılıp çoğaltılacak/klonlanacaktır.

<img src = "53.png" width="auto">

- Bir değişkendeki değer başka bir değişkene klonlanıp atandıysa yani iki değer farklı değerlerse tamam birbirlerine eşit olabilir ama farklı değerlerdir. Birbirlerini etkilemezler. İşte bir değişkende yapılan değişiklik diğer değişkene yansımayacaktır.

<img src = "54.png" width="auto">

***
# 64) Değişkenler Arası Değer Atama Durumları - Shallow Copy
- Shallow Copy davranış olarak biraz daha gelişmiş bir yapılanma.

- İki tane değişken olduğunu varsayalım a ve b olmak üzere. Ama bu değişkenlerin değer türlü değil referans türlü olduklarını düşünelim.

- Değişkenler arası değer atamalarında değeri türetmek/çoğaltmak/klonlamak yerine var olanı birden fazla referansla işaretlemeye dayalı kopyalama yöntemidir.

- Bellekte birden fazla referansın tek bir veriyi işaret etmesidir.

- Neticede ilgili değer bir değişikliğe uğradığında tüm işaretleyen referanslara bu değişiklik yansıyacaktır.

- Elimizde bir veri var sen bu veriyi tutan değişkeni bir başka değişkene gönderdiğinde yani atadığın zaman buradaki değer türetilmiyorsa/klonlanmıyorsa var olan değeri sadece diğer değişkende işaretliyorsa biz buna Shallow Copy diyoruz. Yani yüzeysel kopyalama. Aslında referansını kopyalıyoruz.

- Bir tane değerimiz var ve bu değer Heap bölgesinde Heap'teki değeri hem a hem de b ikisi birlikte bu değeri işaretliyor aynı değeri işaretliyorlar. İşte bu yüzeysel bir kopyalamadır.

- Default olarak Shallow Copy referans türlü değişkenlerde geçerlidir.

- Referanslar/birden fazla referans bellekte tek bir veriyi işaretliyorsa bilin ki onlar kendi aralarında yüzeysel/shallow kopyalama yapmıştır.

- Birden fazla referans/değişken aynı türde atama sonucunda farklı değerleri referans ediyorlarsa orada da Deeğ Copy söz konusudur.

- Normalde Değer Türlü değişkenler default olarak Deep Copy edilirler.

- Bu eğitimin ilerideki konusu olan `ref` keyword'ü ile Değer Türlü değişkenlerde nasıl Shallow Copy yapıldığını ele alacağız.

- Shallow Copy OOP derlerinde ele alacağımız nesne ve referans arasındaki ilişkide varsayılan davranış olarak kabul edilmektedir. Bu konuyla ilgili eğitimlerimizde değinirken, nesneler üzerinde de ayriyetten Deep Copy'nin nasıl gerçekleştirileceğini de ele alacağız...

<img src = "55.png" width="auto">

***
# 65) object Türü
- Bir değer türüne uygun bir değişkende tutulmalıdır.

- Yazılımda assign operatörünün(`=`) sağ tarafındaki tür neyse sol tarafındaki türde aynı olmalıdır. Sağ ile sol eşit türlerde olmalı. Birbirlerini karşılamalı. Bu sağ sol prensibidir.

- object : Tümmmmm türleri tek başına karşılayabilen bir türdür...

- Tüm türlerin üst çatısı object türüdür. 

- Tüm türler varsayılan olarak object'ten türerler. Referans türlülerde olabilir Değer türlüler de olabilir.

- Birşey birşeyden türediği zaman türeyen türetilen tarafından temsil edilebilir. Yani object'ten string türüyorsa string aynı zamanda object'tir.

- object string'tende geniş olduğu için string'ide kapsadığından dolayı string'i tutabiliyor.

- object bütün değerleri karşılayabilecek evrensel bir tür. Türlerin Adem'idir...

- Object türlerin ademidir. Bu yüzden tümmm türleri karşılayabilmektedir.

- object; referans türlü bir değişkendir... Lakin değer türlü değerleri de karşılayabilir...

- object aynı zamanda nesneleri de işaretleyebilir. 

<img src = "56.png" width="auto">

- Object değişkenler ilgili verileri RAM'de object türde tutarlar. Lakin verinin öz türünü de içerisinde bozmadan saklarlar. Yaniiii object içerisindeki veri kendi öz türünde tutulur.

- object dışarıdan objeye çeviriyor ilgili veriyi ama içeride verinin türünü tutabiliyor.

- Bu durum object içerisindeki veriyi kendi türünde tekrar elde edebiliriz anlamına gelmektedir....

- Bir veriyi object'in içerisine koymaya Boxing/kutulama/objectleme diyoruz. O veriyi object içerisinden kendi türünde elde etmeye Unboxing diyoruz.

- object'e atanan değer object türünde RAM'de saklanıyor ama içerisinde saklanan değer neyse o'dur herhangi bir değişim olmaz. string koyduysan string olarak object'in içerisinde tutulur.

- Bir T türündeki değeri object'e koymaya boxing/kutulama bu değeri T türünde çıkarmaya unboxing denir.

<img src = "57.png" width="auto">

***
# 66) object Türü - Boxing
- object türdeki bir değişkene herhangi bir türdeki değeri göndermek Boxing olarak nitelendirilmektedir.

- object varsa Boxing söz konusudur.

* `int yas = 23;` RAM'de int türünde değişken üzerinden bir alan tahsisi yapar ve oraya 23 değerini koyar. `int` olarak konulur ve çağırdığında da `int` olarak gelir.
* `object _yas = 23;` Bir tane obje açıyor ve içine `int` türdeki 23 değerini yerleştiriyor. Buraya yerleştirilen 23 `int` olarak yerleştirilmiş oluyor.

- Herhangi bir değeri object değişkene atadığınızda o değer otomatik object'te dönüştürülür. Dönüştürülme işlemine Boxing denmektedir.

- Boxing işlemi neticesinde ilgili değer objectin içerisinde kendi türüyle saklanır. Lakin! ilgili değer bizlere object türde gelecektir.

- Burada dikkat ederseniz object türden elde edilen değer üzerinde türüne özgü işlemler gerçekleştirilemez! 
    * Örneğin sayısal bir değer varsa o değer object olarak geleceğinden dolayı matematiksel işlemler yapılamaz!

- Boxing yapılmış yani object türüne atanmış değerin üzerinde kendi türünde işlem yapabilmem için değeri object değilde kendi türünde elde etmem lazım bu olaya Unboxing denir.

- object'te atanan bir değer o objecet türünden çağrılıyorsa sana object(paketlenmiş/kutulanmış) olarak gelecektir. Sen onun üzerinde türüne özgü herhangi bir işlem YAPAMAZSIN!

- Object bir değişkenin içerisindeki değer üzerinde türüne özgü işlemler yapabilmek için o object'in içeriisnde değeri kendi/has/özgün türünde elde etmemiz gerekmektedir. İşte bu işleme de UnBoxing(kutudan çıkarma) diyeceğiz...

- Herhangi bir değer object değişkene atanıyorsa Boxing işlemine tabi tutulur.

- Herhangi bir değer object türe assign ediliyorsa eğer bu işlem Boxing'tir...

<img src = "58.png" width="auto">