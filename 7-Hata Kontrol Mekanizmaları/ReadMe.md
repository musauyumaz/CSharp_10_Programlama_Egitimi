***
# 170) Hata Kontrol Mekanizmaları Nedir? Ne Amaçla Kullanılır?
- Artık bir yazılımın temel doğasında/fıtratında olan bir şeydir hata.

- Yazılım süreçlerinde en çok aldığımız ve esas olan birşey varsa o da hatadır.

- Şimdi sen geliştirdiğin yapılanmada ister istemez mükemmel muazzam bir strateji yapsan da beklenmeyen noktalarda kah gözünden kaçan noktalarda kahta yapmış olduğun hesaplamaların yanlışlığından dolayı yazılım sürecinde ister istemez birçok hatayla karşılaşacaksın. İşte bu hataları biz nasıl manipule edeceğimizi nasıl karşılayacağımızı hata kontrol mekanizmaları başlığı altında a'dan z'ye inceliyor olacağız.

- Bir yazılımcının hata dediğimiz kavram esasıdır. Yani günlük hayatta çok karşılaştığımız için artık bize yabancı değildir hata. En nihayetinde olayı şöyle düşünün ilk başta çok hata yapacaksınız ve yaptığınız hatalardan panik olmamanız lazım. Çünkü biz bunları daha nasıl yöneteceğimizi bilmiyoruz. Öğrendikten sonra farkettikten sonra hata türlerini gördükten sonra daha çok önümüz görülebilir hale gelecek daha çok böyle gözümüz açılacak diyecez ki ya arkadaş benim aldığım bu hatalar tamam bunlar çözülebilir şeyler. Hata dediğin şey zaten bu işin doğasında var.

- Biz günlük hayatta bir bardağa su doldururken bile yanlışlıkla gidip suyu yere masaya dökebilen insanlarız. Dolayısıyla ince hesap gerektiren bu tür yazılımsal durumlarda hata mı yapmayacağız? Bir mimari boyutta yazılım geliştireceksin ve hata yapmayacaksın? Bu gayet doğal hata yapacaksın önemli olan bu hatanın mahiyetini bilebilmek bunu yorumlayabilmek bunu değerlendirebilmek.

- 3 tür hatamız vardır;
    * Derleyici/Söz Dizimi Hataları
    * Runtime/Çalışma Zamanı Hataları
    * Mantıksal Hatalar

- Hatanın aslında bir yazılımcının yolundaki taş değilde ta işinin kendisinin olduğunu göreceğiz. Yazılımcı bir yerden sonra yapıları öğrenir. Bir yerden sonra bir amaca hizmet eden algoritmanın tasarısını koyar. Koduktan sonra yoldaki problemleri çözerek o yolu kazıyarak yolu inşa eder. Yani bir yerden sonra bizim işimiz hata çözmek oluyor. İster istemez işin bu oluyor. Ya mimaridleri öğreniyorsun vs. vs. Algoritmayı oluşturduğunda işin artık oradaki hataları temizlemek oluyor. Onun için bu konu bizim için çok önemli.

***
# 171) Hata Türleri - Derleme/Syntax/Sözdizimi Hatası
- Ferah ol... Hata bizim özümüzde var...

<img src="1.png" width = "auto">

- Programlama dili kurallarına aykırı olan hatalardır.
    * Örneğin Değişken tanımlama kurallarına uymadan değişken tanımlamaya çalışırsan kodunu derleyemezsin. Çünkü syntax hatası alacaksın.

- Özellikle gelişmiş editörler(VS) sayesinde söz dizimi hataları derlemeye gerek bile kalmaksızın fark edilebilmektedirler.

- Hatanın bulunduğu satır derleyici tarafından rapor edilir.

- O yüzden fark edilmesi ve çözülmesi ennnnn kolay hata türüdür.

- Yazılması gereken konseptte kodu inşa etmediğiniz sürece syntax hatası alacaksınız. Bu hata derleme sürecine hata verecek bir hatadır. Yani derleme esnasında ortaya çıkacak hatalardır. Compiler bakacak kodu derlerken hop kardeşim sen burada bu kurallara uymamışsın burada böyle bir kod yok burada böyle bir syntax yok diye seni uyaracaktır. Normalde bunu ilkel editörler kullanırken compiler seviyesinde öğrenebiliyoruz ama gelişmiş editörler sayesinde söz dizimi hataları uygulamayı/kodu derlemeye gerek kalmaksızın anında fark edilebiliyor ve direkt bizlere sunabiliyor.

- Gelişmiş editörler diyor ki Sen burada kodunu yazdın ben bunu derlemeye göndermem çünkü sen burada hata yaptın diyor.

- Gelişmiş editörler(Visual Studio, Intellij Idea) yapılan derleyici hatalarını/syntax hatalarını derlemeye göndermeye gerek kalmaksızın zaten direkt bizlere sunan bir editördür.

- Hatanın bulunduğu satır direkt derleyici/editör tarafından bizlere sunulmaktadır. Normalde derleyici compiler tarafında söyler. Şu satırda şu noktada bir hatan var diyecektir. Gelişmiş editörlerde direkt koda nokta atışı yapacak hatanın nerede olduğunu bizlere sunacaktır.

- Örneğin : Bir `class`ın scope'ları olmalıdır. Eğer ki scope'ları silersen sana hata verecektir.
    * Bir keywordü bambaşka şekilde yazarsan/bozarsan/semantiğe aykırı bir keyword yazarsan/var olan imzayı bozarsan/olması gereken yerde olması gereken şeyi bulundurmazsan/bir şeyi olmaması gereken yere koyarsan bu tarz yerlerde biz syntax hatası alırız.
    * C# büyük küçük harf duyarlılığına sahip bir dildir. Bu yüzden bir keywordü dikkat etmeden yazarsan söz dizimi hatası alırsın.
    * Değişken tanımlama kurallarında özel karakterler değişken isimlerinde belirtilemezdi. Eğer ki belirtirsen hata alırsın.

- Gelişmiş Editörlerin altını çizdiği hatalara biz derleyici/syntax/söz dizimi hataları diyoruz. Direkt altını çizdiği yer bizim hatamızda odaklanacağımız yer olacağı için fark edilmesi en kolay hatadır. Direkt ne yapacağını hani hatayı gördün tüh burada yanlışlıkla bunu buraya yazmışım ya da özel karakter kullanmışım diyebildiğin için çözümü de en kolay olan hata türüdür.

- Hataları bilebildiğimiz/görebildiğimiz/anlayabildiğimiz/farkına varabildiğimiz için çözülmesi ve fark edilmesi ennnnn kolay hata türüdür.

<img src="2.png" width = "auto">

***
# 172) Hata Türleri - Run-Time(Çalışma Zamanı) Hataları
- Kodunuzu yazdınız;
    * Syntax'da bir problem yok,
    * kodun semantiği kusursuz,
    * çalışma zamanında patlamaya sebeb veren hatalardır.
    * Kodunuz derleniyorsa,
    * Derlendikten sonra çalışma zamanında hatalar alıyorsanız işte bu hatalara/patlamalara sebebiyet veren hatalardır. 

<img src="3.png" width = "auto">

- Yazılım ayaktayken ortaya çıkan bir takım aykırı durumlardan dolayı programın işletim sistemi tarafından kesilmesiyle/sonlandırılmasıyla sonuçlanır.

- Uygulamayı sen ayağa kaldırdın çalışma zamanında herhangi bir hata bir aykırılık söz konusu olursa işletim sistemiyle hani entegrasyon oluyordu ya hani bir iletişim kuruyorduk nihayetinde işte işletim sistemi kendi üzerinde çalışan yazılımlardan herhangi birinde bir aykırı durum görürse onu çalışma zamanında sonlandırıyor ve sonlandırırken de belirli bir mesaj gönderir.

<img src="4.png" width = "auto">

- Çalışma zamanı hataları programın işleyişinin ortasında direkt kullanıcıyla temas edebilecek hatalardır. 

- Yani sen kullanıcın diyelim ki Word'ü kullanıyorsun yazdın yazdın yazdın orada bir aykırı durum oluştu yazılımsal boyutta karşına bir hata çıktı işte o hata çalışma zamanı hatasıdır.

- Bilgisayar kullanıcıları oynadığı oyunlarda çalıştırdığı programlarda çalışma zamanı hatalarıyla çok fazla karşılaşabilirler.

- Ve hiçbir yazılımcı son kullanıcının hatayla karşılaşmasını istemez...

- Genellikle kültürden kültüre boyutu değişse de bir hatayla karşılaşan son kullanıcı derinden kulak kaşındırabilir.

- Böyle bir durumda çalışma zamanında alınabilecek olan hataları yönetmek ve bir şekilde manipule etmemiz gerekecektir.

- Son kullanıcıya bir yazılımın hatayı göstermesi kullanıcı kullanım esnasındayken hatayla karşılaşması ticari açıdan da sıkıntı yaratacaktır. Nihayetinde kullanıcının tercihi nasıl ki bir insan mont alırken kaliteli bir markadan kaliteli bir mont alıyor aynı şekilde kullanıcı senin yazılımını kullanabilmesi için tercih edebilmesi için hatalardan arındırılmış arayüzü güzel kullanıcının işlemlerine hızlıca ve efektif boyutta eşlik eden bir yazılım olması gerekiyor. Arada böyle hata fırlatan kullanıcıyı böyle iş yaparken durduk yere böyle ekranlarla oyalayan bir yazılımı hangi kullanıcı tercih edebilir ve nihayetinde şöyle düşünün siz hangi yazılımı yazarsanız yazın elbette bir rekabete girdiğiniz başka bir marka tarafından aynı yazılım üretiliyordur. Mümkün mertebe bir yazılımın son kullanıcıya hata göstermemesi gerekiyor.

- Senin çalışma zamanında alacağın olası hataları bir şekilde tespit edebilmen lazım ve tespit edebildiğin durumlarda alınabilecek olası çalışma zamanı hatalarını kullanıcıya çaktırmadan göstermeden manipule etmen lazım.

<img src="5.png" width = "auto">

- Çalışma zamanı hataları genellikle kullanılan mimari de öntanımlı mesajları verecektir.
    * Örneğin Olmayan bir dosyayı yazılımınızda açmaya çalıştığınızda mimarinizde olmayan dosyayı yazılımla açmaya çalıştığınıza dair ön tanımlı bir mesaj varsa bunu verecektir. Yoksa bu hatayı işletim sistemi seviyesinde verecek. İşletim sistemi tarafından hatanın karşılığı hangi mesajsa İşletim sisteminde tanımlanmış o mesaj verilecektir. 

- Eğer ki alınan hatanın mimaride bir karşılığı yoksa işletim sistemi dili kullanılacak ve daha kompleks bir açıklamayla karşılaşılacaktır.

- Bir yazılım kendisinde çalışma zamanında alınan hataları işletim sistemi seviyesinde mesajlarla veriyorsa bu mesajlar çok anlamsız ve kompleks bir türde olabilir. Dolayısıyla biz bunları da istemeyiz. 
    * Şimdi kullanıcı orada örneğin metinsel bir değer yazması gereken yere sayısal bir değer yazdı diyelim ya da bununla ilgili arkada çalışan kod metinsel çalışan bir kod olduğu için sayısal değerde hop patladı. Şimdi biz burada şunu yazmalıyız kullanıcı şunu görmeli; Ya kardeşim işte metinsel yazman gereken yere sayısal bir değer yazdın diye görmeli. Bunu görmeyipte işletim sistemi seviyesinde karman çorman bir hata alıyorsa kullanıcı da neden hata yaptığını bilemez ve bunu loglama sistemleri de olacak ileride mimarisel yapılanmalarda yazılım hata veriyorsa verilen hata bir yere kaydedilir ki biz yazılımcılar daha sonraki süreçte onu daha sağlam bir şekilde geliştirelim onları minimize edelim diye loga baktığında da birşey anlamazsın işletim sistemi seviyesindeki mesajlardan.

<img src="6.png" width = "auto">

- Dolayısıyla çalışma zamanı hatasında olması gereken durum hataların önceden prograncılar tarafından tespit edilip daha anlaşılabilir bir şekilde düznelenmesi gerekiyor.

- Olması gereken ise çalışma zamanı hatalarının çmceden tespit edilip programcı tarafından daha anlaşılabilir bir şekilde düzenlenmesidir.

- Sen bir yazılım geliştirdin geliştirdiğin yazılımda çalışma zamanında alabileceğin olası hatalı durumlar varsa bunlar senin önceden tespit etmen, öngörebilmen ve bir şekilde önlem alman lazım. Ya da anlamlı şekilde manipüle etmen lazım. 

- Tabi bunun içinde çalışma zamanı hatalarının sağlam bir öngörüyle tespit çalışması yapılması gerekmektedir. 

<img src="7.png" width = "auto">

- Çalışma zamanı hatalarını önceden kestirmek oldukça zor olabilmektedir.

- Nihayetinde sen bir yazılım yaptın ama yani önceden bunun süreçte verebileceği hatalar belki 1 dk sonra belki 3 gün sonra verebileceği hataları öngörebilmen bazen zor olabiliyor.

- Bu hataları öngörebilmek genellikle testerların işidir.

- Yazılımcı olarak sen bunu görüyorsun uygulamayı yapabildiğin kadar yapıyorsun uygulamayı koydun. Tester dediğimiz testçi arkadaşlara verdin artık onlar durmadan test ediyor uygulamanın hangi çalışma zamanı durumlarında hataları var bunların hepsini test ede ede  yani kullanarak kullanıcı olarak test ederek bunlar uygulamadaki çalışma zamanı hatalarını rapor ediyorlar ve tespit edilenler biz yazılımcılar tarafından tespit edilen noktaya göre uygun çözümlerle manipüle ediliyor.

- Uygulama mümkün mertebe test edilerek çalışma zamanı hataları tespit edilmeli ve programcı tarafından tanımlanmalıdır.

- Diyelim ki iki sayıyı toplayan bir yazılım geliştirdin ve tester'a yolladın. Şimdi iki sayıyı toplayan ve bu iki sayının dışarıdan kullanıcı tarafından girildiğini varsayalım. Toplama işlemi sayısal türlerde yapılır. Şimdi kullanıcının girmiş olduğu değerler ya sayısal değilse sayısal olmadığı durumda patlıyor işte bak semantikte bir sıkıntı yok. Sen Ahmet'le Mehmet'i toplamaya çalıştığında aritmetik işleme tabi tutmaya çalıştığında orada uygulama patlıyor. Gittin testera verdin tester bunu deniyor 3'ü girdin 5'i girdin sonuç olarak orada 8 değeri döndü bunda sıkıntı yok birde tester dedi ki ya ben burada metinsel değer yollayıp toplayabiliyor muyum dedi ve ahmetle hilmiyi toplamaya çalıştı ve program orada patladı ve tester sana yani kodu yazana rapor ediyor senin yazmış olduğun bu uygulama da şu noktada şu cinste değerleri girdiğimde patlıyor bak ya bunları engelle sadece tek bir cinste veri girilebilsin. Ya da patlama oluyorsa düzgün bir şekilde kullanıcıyı uyaralım. İşte tester dediğiniz durmadan ilgili yazılımı dener. Deneme yanılma yöntemleriyle de hangi durumlarda hangi değerlerde hangi parametrelerde bu yazılımın çalışma zamanı hatası verdiğini tespit ederler.

- Tüm bunlara rağmen gözden kaçan durumlar olması oldukça normaldir. Dolayısıyla bir programın gelişimi sahadaki belli bir sürece bağlıdır.

- En nihayetinde Facebook olsun instagram olsun bunlar senin benim sayemde gelişti. Yani sen bşey yapıyorsun hop patlıyor orada değil mi adamlara rapor gidiyor onu düzeltiyorlar. Yani milyarlarca insanın günlük hayatta kullandığı bir yazılımda aldıkları hatayı 3 5 kişilik arkadaki ekip ne kadar hangi ömürle kaç tane kaç kere denemeyle test edebilir ki?

- Son kullanıcın da almış olduğu hataları log mekanizmalarıyla toplayıp nerelerde hangi durumlarda hangi değerlerde hangi parametrelerde çalışma zamanı hataları alınıyormuş tespit edilebilir. İşte bu da artık yapılan yazılımı süreçteki kullanıcıdan gelen dönütlere bilgilere bağlı olacaktır. Zaten hayatta böyle birisi araba üretiyor ürettiği araba ilk ürettiğiyle 2000'de ürettiği segmentle şimdiki ürettiği segment arasında tank farkı var neredeyse. Diğeri yürürken dağılacak ama şimdiki arabalar bayaa hani gelişmiş vaziyette. İşte burada gelişim sürecini tamam bilim ilerletiyor ilerletmesine ama kullanıcılardan gelen trafiklerden gelen kaza oranlarından gelen bütün raporların değerlendirilmesi sonucu gelişiyor. işte bazı şeylerin artık sahaya sürülmesi gerekiyorsa da sürülüyor.

- Bu süreçten toplanan loglar ve son kullanıcı dönütleri değerlendirilerek çalışma zamanı hataları tespit edilip arındırılabilir.

- Sahaya sürülmüş bir yazılımda bu sahadaki sürecinde toplanan loglar ve son kullanıcı dönütleri değerlendirilerek çalışma zamanı hataları gene tespit edilebilmekte.

<img src="8.png" width = "auto">

- Tespit edilen çalışma zamanlarının manipülasyonunun oldukça önemli olduğunu söyledik.

- Nihayetinde bodoslama kullanıcıya vermektense hatayı ilgili patlamayı sen manipüle edip sen kullanıcıya başka bir şekilde başka bir hata vermen daha doğru olacaktır. Hani kullanıcı onu bir yazılımın gereği gibi düşünsün. Hani bir patlama hata değilde yazılımın gereği olan bir uyarı gibi düşünmesini sağlaman lazım.

<img src="9.png" width = "auto">

- Yazılımdaki hata kontrol mekanizmalarını devreye sokarak...

- Hata kontrol mekanizmaları çalışma zamanı hatalarını kullanıcıya hissettirmeden yakalayabilmek ve ilgili hatayı manipüle edebilmek için var olan bir yapıdır.

- `try catch` yapılanmasını hata kontrol mekanizmasının ta kendisidir.

- Hata kontrol mekanizması çalışma hataları için vardır. Syntax/semantik hatalar için `try catch` yapılanmasını kullanamazsınız ya da mantıksal hatalarda da gidip `try catch` yapılanmasını kullanamazsınız. Onların çözümleri başka. Ama bizim ticari açıdan kritik arz eden çalışma zamanı hatalarının bir şekilde manipüle edebilmek için işte `try catch` dediğimiz hata kontrol mekanizmaları bunlar için soz konusudur. Çalışma zamanı hatası için söz konusudur.

<img src="10.png" width = "auto">

- Çalışma zamanı semantik açıdan/syntax açısından herhangi bir problemin olmadığı bir durumda alınan hatalardır. Bunlar kullanıcıya gösterilmeksizin manipüle edilmesi gereken hatalar çünkü ticari açıdan risk taşıyor. Risk taşıdıklarından dolayı bunları çalışma zamanında olası olan bu hataları bir şekilde manipüle etmemiz lazım işte bunu da yapabilmek için hata kontrol mekanizmlarını yani `try catch` bloklarını kullanmamız gerekecek.

***
# 173) Çalışma Zamanı/Run-Time Hata Durumları​na Örnek Verelim
- Olmayan bir dosya olmayan bir nesne üzerinde işlem yaparken alınan hatalardır.

- Olmayan bir dosyayı açmaya yahut üzerine yazmaya okumaya vs. çalışmak

- Olmayan değer üzerinde işlem yapmaya çalışmak 

- Uygun olmayan formatlarda çalışmak.

- Veritabanı bağlantısının kopması.

- Çalışma esnasında varolan bağlantının kopması durumunda.

- Başta olmayan bir bağlantı derleme zamanında zaten yok. Zaten kuramazsın derleme zamanında sonra eğer hiç veritabanı bağlantısı yoksa. Ama varolan bir veritabanı bağlantısı süreçte koptuğunu düşünürsek bu çalışma zamanında bir hataya sebep olacaktır. Ya da bunun gibi başka bağlantıların entegrasyonel yapılanmaların birbirinden kopması bağlantıların kesilmesi uzaktan dinlediğimiz servislerin yanıt vermemesi gibi durumlar çalışma zamanlarında hatalara sebep olacaktır.

<img src="11.png" width = "auto">

- Çalışma zamanındaki olası parametrik değerler üzerinde olası vermiş olduğumu değerler üzerinde alınan çalışma zamanı hatalarını iyi tespit edip bunlara göre önlem almamız gerekiyor.

- Önemli olan problemin ne olduğunu bilebilmek. Sen zaten problemin ne olduğunu biliyorsan gerisi artık teferruata kalır. Problemi tespit edebilmek sıkıntı. Yazılım süreçlerinde her daim bizim problemimiz yani bizim asıl gayemiz problemi teşhis edebilmek. Problemi çözmek değil Problemi çözmekte sıkıntı yok.


```C#
Çalışma Zamanı Hata Durumları Örnek

System.Console.WriteLine("Lütfen birinci sayıyı giriniz.");
int sayi1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
int sayi2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
```

- Olası hatayı verebilecek olan kodu keşfettikten sonra bunların üzerinde manipülasyon işlemi yapabilmemizi sağlayacak olan yapılanma `try catch` yapılanmasıdır.

***
# 174) try - catch Mekanizması Teorik Anlatım
- Runtime'da alınan hataları manipüle etmemizi/karşılamamızı/kontrol etmemizi sağlayan bir programatik yapıdır.

- Programalama dilinin dahilindedir.

- Runtime'daki patlamalarda hata durumlarına ilgili hatayı kontrol etmemizi/doğru manipülasyonlar ya da istediğimiz manipülasyonları yapmamızı sağlayan yapılanmaya `try catch` yapılanması diyoruz.

- Çalışma zamanında alınan olası hataları kontrol etmemizi, karşılamamızı, manipüle etmemizi sağlayan bir yapılanmadır.

- Gelen bir şeyi doğru bir şekilde manipüle etmek mesela dövüş sanatında karşıdan gelen saldırıyı manipüle edip ya sonlandırabiliyor ya da karşıdan gelen saldırıyı manipüle edip aynı etkiyi kendisine döndürüyor. Yani manipülasyon demek gelen etkiyi istediğiniz gibi birşeye dönüştürebilmek dolayısıyla burada bir patlama oluyor. Burada bir etki oluşuyor oluşan bu etkiyi başka bir şeye dönüştürmek kullanıcıya hissettirmeden bir mesaj vermek bir patlama değilde sanki yazılımın doğal bir süreciymiş gibi yazılımda bir refleks göstermektir manipülasyon. İşte biz bunu `try catch` yapılanmasıyla gerçekleştiriyoruz.

- `try - catch` yapılanamsı, uygulama sürecinden yaşanan olası hatayı kullanıcıya hissettirmeksizin farklı bir durum ya da olağan bir mesaj gibi göstermemizi sağlayan ve bunun yanında patlamaya/hataya dair bizlere bilgi sunan ve böylece bu bilgiler eşliğinde kayılar/log oluşturmamızı sağlayan bir programatik yapılanmadır.

- Uygulama da ister istemez hatalar alacağız. İşte bu alacağımız hatalar çalışma zamanında alınıyorsa bunları biz kontrol ederken `try - catch` yapılanamsını kullanıyoruz.

- `try - catch` yapılanamsının amacı;
    1. Kullancıya alınan hatayı hissettirmemek
    2. Alınan hatanın nedenine dair kullanıcıya bilgilendirmek.
        * orada bir patlama oluyor sen kullanıcıya hissettirmeden güzel bir şekilde manipüle etmen gerekiyor. Ya kardeşim bak sen bunu burada yaptığın zaman bu olmuyor diye kullanıcıyı uyarabilmen lazım bilgilendirebilmen lazım bunu uygulama sona ermeden yapabilmen lazım işte `try - catch` yapılanması ile yapacaksın.
    3. işletim sistemleri aykırı durum yaşandığında uygulamayı sonlandırmak isterler ve sonlandırırlar. `try - catch` yapılanması ile alınan hataya dair bir manipülasyon gerçekleştiriliyor ve uygulamanın kapanmadan devam edilmesi sağlanabiliyor...
        * Alınan her çalışma hatasında uygulamayı sonlandırmaktansa hatayı doğru bir şekilde manipüle edip uygulamanın devam etmesini sağlamak ve bu hataya sebep olan durumlara karşı doğru uyarılarda mesajlarda bulunmak bizim amacımız bu.
        * Örneğin banka sistemlerine giriş yaparken senden sayısal bir değer istiyor telefona mesaj gönderiyor gelen mesaj üzerinden diyor ki işte oradaki sayısal değeri buraya yaz. Oradaki sayısal değerin yerine gidip metinsel karakterlerde yazmaya çalıştığında seni uyarıyor. Hop kardeşim buraya sen metinsel yazamazsın. Yazacağın değerler sayısal olması gerekiyor. işte bu durumu biz arka planda daha gelişmiş yapılanmalarda Validation'lar falan kullanılıyor ama şöyle düşünün sen oraya metinsel bir ifade yazdın gönderdin arkada patlıyor patlayınca manipüle ediyor ve seni uyarıyor buraya sadece sayısal ifadeler girebilirsin diye.

- `try - catch` yapılanması hataları kontrol etmemizi hataları doğru şekilde manipüle etmemizi yönlendirmemizi sağlayan bir yapılanma.

- Prototip : `try {Olası çalışma zamanı hatalarını verebilcecek kodları buraya yazıyoruz...} catch(){try içerisinde olası hata söz konusuysa kodun akışı orada kesilecek ve akış catch bloğundan devam edecektir.}`

- Olası çalışma zamanı hatası veren ve belirli parametlere/değerlere göre çalışma zamanında hata fırlatan kodlarımı `try` bloğu içine yazarız.

- Hata alındıktan sonra yapacağın işlemleri de `catch` bloğu içerisine yazarız.

- Örneğin `Console.ReadLine()`dan gelen `string` ifadeyi eğer ki elimizdeki ifade integer'a dönüştürülemeyecek bir ifadeyse orada biz patlıyorduk. İşte oradaki kodları `try` bloğu içerisine yazacağız. Çünkü runtime'da verilen değerin türüne göre/formatına göre çalışma zamanı hatası üretebiliyor işte ürettiği zamanda `catch` bloğu içerisine Lütfen sayısal değer giriniz diyeceğiz. Ya da beklenmyen bir hata oluştu diyeceğiz. Ama uygulama hata verdiği noktada kesilmeyecek uygulama `catch`den devam edecek ve ondan sonra ne yapıyorsanız artık o işlemden devam edecektir.

- Uygulama da çalışma zamanında alınan hataları yönetmemizi kontrol etmemizi sağlayan yapılanma `try - catch` yapılanmasıdır. Uygulama hata verdiği zaman bu yapılanma sayesinde Runtime'da alınan hata neticesinde manipülasyon edilecektir hata ve hatayla ilgili bize bilgi verecektir. İstediğimiz bilgiyi elde edebiliyoruz. Loglama ya da kayıt işlemlerini yapmamıza imkan tanıyor. Bunun dışında bir de ekstradan uygulamayı sonlandırmadan uygulamanın yaşamasını/uygulamanın ayakta kalmasını devam ettiren bir yapılanmadır. 

```C#
#try - catch Yapılanması
System.Console.WriteLine("Lütfen birinci sayıyı giriniz.");
int sayi1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
int sayi2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
```

<img src="12.png" width = "auto">