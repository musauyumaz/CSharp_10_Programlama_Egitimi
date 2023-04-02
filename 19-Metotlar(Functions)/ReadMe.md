---
modified: 2023-03-31T15:21:54.882Z
title: 381) Metot Nedir? Bir Programcı Gözünden Ne İşe Yarar?
---

***
# 381) Metot Nedir? Bir Programcı Gözünden Ne İşe Yarar?
- Prosedürel programlamanın artık Object Oriented'a geçişini zorlayacak olan konudur metotlar.

- Nihayetinde metot sınıfın bir member'ıdır.

- Günlük hayatta biz metoda terminolojik açıdan yöntem/yordam/function diyebilmekteyiz. Yani bir fiili/eylemi/fiiliyatı temsil eden kelimelerdir.

- Örneğin ben günlük hayatta ben bir aşçıyım yemek yapıyorum yapmış olduğum yemekte kullandığım uyguladığım yöntem benim metodolojimi temsil eder. Yani metot dediğin kavram fiiliyatın ta kendisidir. onun terminolojik karşılığıdır/izahıdır.

- Diyelim ki ben bir akademisyenim araştırma yapıyorum yapmış olduğum araştırmalarda hatta akademik kaynağı elinize aldığınızda oradaki yapılan araştırmayla ilgili ya da yöntemle ilgili bilgi verilir size der ki buradaki araştırma şu metodoloji kullanılarak yapılmıştır. Bunu şöyle düşünebilirsiniz bir veri üretilmesi gerekiyor akademik dalda hangi yöntemle hangi terminolojiyle üretildiği ilgili kaynakta yazar. Biz buradaki istatistiksel verileri anket metodolojisini uygulayarak gerçekleştirdik. Yok efendime söyleyeyim gözlem metodolojisini uygulayarak gerçekleştirdik. 

- Metot dediğimiz yapılanma fiiliyattır/yöntemdir. Sen nasıl ki bir yemeği yaparken bu yöntemi kullanıyorsun yani oradaki metodu uygulamış oluyorsun. 
 
- Yazılımda gerçekleştirdiğimiz, fiili olarak gerçekleştirdiğimiz tümmmmmm operasyonlar bir metottur. Yazılıma geldiğimizde senin fiili açıdan gerçekleştirdiğin tüm operasyonlar bir metodolojidir haliyle bunların hepsi metot içerisinde olması gerekmektedir.

- Matematiğe gidersek eğer matematikte fonksiyonlar dediğimiz konular vardı fonksiyon yazılımdaki metodun ta karşılığıdır. Matematikteki fonksiyon ne yapıyorsa yazılımda da metotlar aynısını yapıyor. Metotlara bir diğer ismi fonksiyonda diyebiliyoruz birebir aynı isimle kullanılabilmekte. Şimdi sen matematikte diyorsun ki ya kardeşim benim elimde bir f(x) fonksiyonu var burada x'e verilen değer içeride bir bağıntıya/fiiliyata tabi tutulur. İşte metotta da böyle olacak yazılım açısından olayı değerlendirdiğinde sen diyeceksin ki benim elimde X diye bir metodum olacak bu metot şu operasyonları gerçekleştirecek diyeceksin yani yazılımda sen bir fiiliyat/operasyon gerçekleştireceksen bir algoritma yapacaksan `for` döngüsü `while` döngüsü `try - catch` mekanizması vs. yani kodu yazmak istiyorsan bunu metot içerisinde yapman gerekiyor.

- Sen bir operasyon gerçekleştirecen bir kod yazacaksın bunu metotlarda yapman gerekiyor.

- Metot prosedürel programlamanın temel elemanıdır. Bir iş/fiiliyat/operasyon yapan en küçük program parçacıklarıdır. 

- Metotlar bir yandan da Object Oriented'da object dediğimiz yapılanmanın temel member'ıdır. Dolayısıyla çok kritik bir konudur

- Seni bir yazılımın var bu yazılım istediğin gibi basitte olabilir çok devasa ağır yüksek bir yazılımda olabilir farketmiyor. Basit bir hesap makinesi eline al bu hesap makinasında operasyon/fiiliyat/işlem mi gerçekleştireceksin bunları kesinlikle metotla yapmak zorundasın. Aynı şekilde uzaya gönderdiğin bir füzen olsun orada devasa işlemler yapıyorsun buradaki işlemlerde metotta olmak zorunda. Yani metot yazılımın içerisinde fiiliyatı/operasyonu/algoritmayı çalıştırabileceğin tek yer başka bir yer yok. Metodun içerisinde kod yazabilirsin. Metodun dışındaki yerler tanımlama yerleridir. `class`/`struct`/`interface` tanımlarsın mimariyi oluşturursun ama kodu yazmazsın kodu yazdığın operasyonu/algoritmayı gerçekleştirdiğin yer metottur.

- Programlama açısından bir işi yapan en küçük programlama parçacığı metottur. 

- Örneğin yazmış olduğumuz kod otomasyonel bir kod olsun ve makinalara hitap eden ve hükmeden bir kod olduğunu düşünelim. Şimdi makinalara hitap eden hükmeden kod fiiliyat açısından hangi işi yapıyorsa orada bir metot tetikleniyor diye düşünebilirsiniz. Şöyle bir kod yoktur. Makinaya şunu diyemezsiniz ya hadi kapıyı aç kodunu çalıştır diyemezsiniz. Çünkü öyle bir kod yoktur. Makinaya kapıyı aç metodunu yazarsınız o metotla makinanın kapısı bir şekilde açılır. Metot işlem yapmanı sağlayan bir program parçacığıdır. Yani senin kapıyı açabilmen için oradaki motorları çalıştırman lazım belirli bir açıya kadar kapı dönecek işte döndüğü zaman durdurman lazım burada aslında çok fazla parametre var ve buradaki operasyonların hepsini bir bütün olarak program parçacığı olarak değerlendirirsek işte biz bunu metot olarak yazılımda tasarlıyoruz. Dolayısıyla sen otomasyonel bir sistemde kapıyı açan kodlarını/operasyonlarını yazdığın yapılanma kesinlikle metot olmak zorunda. Facebook'ta beğen butonu var değil mi? Beğen butonuna tıklandığında oradaki içeriği beğeniyor. İşte oradaki beğenme aktivetisinde bulunan yapılanma kesinlikle bir metot olmak zorunda. Youtube'a girdin Youtube'da gittin yorum yazdın değil mi? Yorumu yazdın dedin ki senin yapacağın videonun falan diye orada bir güzel yazdın yorumunu ardından enter'a bastın ya da yorum yap dedin oradaki yorumu alıp ilgili videoya yerleştiren o operasyonun sorumluluğunu üstlenen yapılanma kesinlikle bir metot olmak zorunda.

- `class` dediğimiz yapılanma var `interface` dediğimiz yapılanmalar var. Bilmediğin onlarca yapılanma var. Bunların hiçbirinde kod yazamazsın. Bunlarda en fazla yapabileceğin şey yapı tasarlamak. Yani ilgili örneğin `struct`. `struct` değer türlü nesneler oluşturmanı sağlayan bir yapılanma. E peki bu değer türlü nesne oluşturmanı sağlayan yapılanma bir operasyon yapar mı yapmaz.`struct` belki devas bişeymiş gibi gözükebilir sana ama operasyon yapmana müsaade etmez. Senin operasyon yapabilmen için nerede çalışıyorsan çalış bir tane metoda ihtiyacın var.

- Bir programcının yazılım içerisinde genel mimarisel tasarım genel böyle algoritmik yapılanmadan bahsetmiyoruz. Mimarisel tasarım ileride design pattern'ları göreceğiz. Hani belirli mimarisel kod tasarımlarımız vard. Bunların dışında özel spesifik algoritmalar/programlar/program parçacıkları/fiiliyatları yazarken bir yazılımcının kesinlikle metoda ihtiyacı vardır. Yani biz metotlar sayesinde kodlarımızı yazabiliyoruz algoritmalarımızı oluşturabiliyoruz.

- İleride property dediğimiz yapılanmalar olacak Object Oriented'da `class` memberlarında bunu göreceksiniz. Şimdi property dediğimiz yapılanmanın içerisinde de kod yazabiliriz orada herhangi bir algoritma yapabiliriz. Property özünde compiler seviyesinde bir metot olduğunu bilmeliyiz.

- Sen kod yazabiliyorsan algoritma operasyon yapabiliyorsan %1000 metodun dışında başka bir yerde çalışamazsın. Daha da ileride şey göreceğiz Nesnelerde kod yazabildiğimiz algoritmalarımızı oluşturabildiğimiz `constructor` yapılanmasını göreceğiz. `constructor`da bir metottur. Yani sen kod yazıcan,`if` yazıcan döngüler oluşturacaksın yok efendime söyleyeyim `try - catch`ler `switch - case`ler bilmemneler bunları yazabilecek kodun içerisinde bir yer arıyorsan kesinlikle bunun bir metot olması lazım.

- Biz bugüne kadar programlamayı öğrendiğimiz programlamayı öğrenirken yapmış olduğumuz işleri fiiliyatları operasyonları yazdığımız yer Main metoduydu. Main'de bir metottur. Çünkü şu ana kadar öğrendiklerimizi metodun dışında yazamazdık. Haliyle main bir ana metottur.

- Bir yazılımın var bu yazılımın içerisinde fiiliyat yapan en küçük bir kod parçacığıdır diyebiliriz. Yani burada bir algoritma/operasyon/fiiliyat mı yapacaksın işte bunları yapmanı sağlayan yapılanma metottur. Kodun diğer yapılanmaları işte Object Oriented'da öğreneceğimiz diğer yapılanmalar hep mimarisel açıdan tasarımla alakalıdır.

- Kodun içinde uzaya da füze göndersen hesap makinesi de yapsan hangi yazılım olduğu önemli değil herhangi bir kodun içerisinde 2 ile 2'yi toplamak istiyorsan yani bir fiiliyat/operasyon/iş değil mi bu. Bu işi yapabilmem için benim metoda ihtiyacım var. Metot koymadan yapamayız. Al yazılımı çöpe at bu vakit.

<img src="1.png" width="auto">

***
# 382) İşlevsel Açıdan Metot Bize Ne Kazandırır?
- Metot prosedürel programlamanın temel elemanıdır yani olmazsa olmaz yapılanmadır.

- Bir iş yapan en küçük iş parçacıklarına biz metot diyoruz. Buradaki işten kastımız algoritma/operasyon bir başka deyişle kodun içinde fiiliyat yani eylemde bulunmak istiyorsanız sen kesinlikle bir metotla çalışman gerekmektedir.

- Biz şu ana kadar bütün operasyonlarımızı Main metodunun içinde gerçekleştirmiştik.

- Biz yapacağımız fiiliyatlar algoritmalar operasyonlar her neyse bunların hepsi aynı kapıya çıkacak yani sen kodun içerisinde bir iş yapmak istiyorsan bu iş kesinlikle bir metodun içerisinde olmalıdır. Geri kalanı tasarımsal kısmıdır. Yani senin kodun içinde algoritmayı yazabilmen için gerekli tasarımı uygulaman lazım. İşte burada yeri gelecek `namespace` oluşturman lazım yeri gelecek bir `class` oluşturman lazım ki artık ilgili `class`ın içerisinde bir metod oluşturup kodunu yazabilesin.

- Metot dediğimiz yapılanmalar sınıfların elemanlarıdır. Birde ileride `struct` denilen yapılanmalar göreceğiz. Metotlar hem `struct`larda hem de `class`larda eleman olarak tanımlanabilmektedir. Yani kodun içerisine senin bir metot oluşturabilmen için ya bir `class` dediğimiz yapılanma içerisinde bu metodu tanımlaman lazım ya da ileride göreceğin `struct` dediğimiz yapılanma içerisinde tanımlaman gerekecektir. C# 9.0'da `record` dediğimiz yapılanmalar geldi bunlar fıtrat olarak `class`lar. Ama davranışsal olarak farklı `class`lar. Dolayısıyla bu `class`ların içerisinde de metotlar tanımlayabiliyoruz.

- Yani sen bir metot tanımlamak istiyorsan ya `class`ın içerisinde tanımlayacaksın ya da `struct`ın içinde tanımlayacaksın. Bunun dışında dediğim gibi metot operasyonu/eylemi gerçekleştirmek için çalıştığın alanı sana veriyor bu geri kalan yapılanmalar tanımlama aşamaları yani kodu inşa etmeni sağlayan yapılanmalar. Kodu operasyonu gerçekleştirdiğin fiiliyatı uyguladığın yer metodun ta kendisi.

- Basit bir hesap makinesinde 2 ile 2'yi toplamaya çalıştığınızda buradaki iş/fiiliyatta bir metodun içinde olduğunu söyleceksiniz. Benzer mantıkla devasa bir yazılım uzaya füze gönderdin giden füzenin işte veri alıyor değil mi bu verileri alıp işleyip sana bu verileri gönderen kodun içindeki alanında bir metot olduğunu bileceksin. Çünkü bu da bir eylem 2 ile 2'yi toplamakta bir eylem. Eylem mi var kodun içerisinde kesinlikle metodun içerisinde çalışmamız gerektiğini artık biliyoruz. 

- Hangi dile giderseniz gidin bu dillerin hepsinde operasyonlarınız kesinlikle metotlarda gerçekleştirilmekte. Hatta biz bu metotlar sınıf ve `struct` elemanları dedik. İleride bu sınıf ve `struct` elemanlarının altında bir de property dediğimiz diğer elemanları da inceleyeceğiz. Property'lerde özlerinde bir metot olduğunu konuşacağız. Nihayetinde property'lerde yapısal olarak içerisinde algoritmalar yani fiiliyatlar yapmamızı sağlayan yapılardır. Dolayısıyla bunu yapmanı sağlayan yapı kesinlikle metottur dediğim halde property bununla denk geldiğinde şunu bilmen gerekir. Property özünde yani compiler seviyesinde bir metottur.

- Metot bir kodun içerisinde operasyonel anlamda iş gerçekleştiren en küçük program parçası.

- Bir kodun var bu kodun içerisinde bir fiiliyatta/algoritma da bulunacaksan işte bunu yapmanı sağlayan metodundur.

- Metot dediğimiz yapılanma kodun içerisindeki tekrarları ortadan kaldırmamıza yaramaktadır. En önemli unsurlarından birisi de budur. Hem operasyon yapmanı sağlıyor hem de kodun içerisinde tekrar eden kodları tek seferlik tanımlayıp inşa edip ondan sonra her seferinde metot üzerinden bir daha inşa etmeye gerek kalmaksızın çağırmanı sağlayan bir yapılanmadır metot dediğin yapılanma.

<img src="2.png" width="auto">

- Şimdi bir operasyonunuz var. Diyelim ki bir sayılar dizisi oluşturdunuz ve buna da elemanlarını rastgele olarak döngüyle beraber atadınız ve sonra bu dizideki elemanları teker teker ekrana yazdırdığınızı varsayalım Peki bu operasyonu 3 defa art arda yapmak istersek ne yapacağız. Şimdi bu operasyonu 3 kere art arda yapabilmenin yolları birden fazla. Örneğin bu yapılanmayı döngüye alabiliriz. Ama diyelim ki biz arada farklı işlemler yapıyoruz. Yapmış olduğumuz bu farklı işlemler neticesinde ben aynı kodu bir daha tetikleyecem. Yani döngüyle hep belirli bir konsepti tetiklemeyecem. Belirli noktalarda hani sabit bir konsept üzerinde olmayan tekrarları yapmam gerektiği durumlarda benim buradaki tekrarlara ya manuel şekilde gerçekleştireceğim. yani tekrar sayısı kadar yazacağım. Kodu tekrar etmek çokta tercih edilir bir durum değildir. Nihayetinde siz burada yönetilebilirliği düşürmüş oluyorsunuz. Burada çıktıyı alırsınız sıkıntı yok ama bu kodun yönetilebilirliğine baktığınızda çıktıdan ziyade kaynağa baktığınızda yönetilebilirlik oldukça zayıf çünkü tekrarlarımız var. Eğer ki bir kodun içinde tekrarlar varsa bu kod bir sorgulanmalı. Evet kodun içinde tekrarlar var ve ben bunu döngüye alamıyorum çünkü arada farklı işlemler var ve bu farklı işlemler neticesinde benim bu kodu tekrarlı bir şekilde çağırmam lazım. İşte böyle bir durumda ben bu kodu yani tekrar eden kodu metoda alırız. Bir metot haline getiririz ve bu kodları lazım olduğu taktirde bu metodu ilgili yerlerde çağırırız. Bu şekilde tek seferde yazdığım kaynağı lazım olduğu taktirde tekrara düşmeden tekrar tekrar tetikleyebileceğim. Çağırmakla kodu tekrar yazmak arasında fark var. Tekrar tetiklemek bizim zaten amacımız bu ama tekrar tekrar kodu inşa etmek bu maliyetli ve kaçtığımız bir durum. Yani kesinlikle bir kodu tekrar tekrar yazmamanız lazım. Bir kere yazmanız lazım. Lazım olduğunda ilgili yerden yazmış olduğunuz yerden çağırmanız lazım. İstenmeyen hal burada kodun tekrar etmesidir. Ben bu kodu bir metod haline getirip buralardaki tekrarları bu metot üzerinden çağırırsam işte ideal koda bu şekilde erişmiş olurum.

- Metotlar içerisine yazılan kodun tekrarlı bir şekilde kullanılmasını sağlarlar.... ve bunu yaparken kaynak kodun tekrar etmesini de engellemiş olurlar.... Böylece ideal koda erişmiz oluruz.... 

- İdeal kod mümkün mertebe tekrar etmeyen koddur. Bir başka deyişle de ideal kodlamada tekrar etmeyen tekrarı engelleyen lazım olduğu taktirde bir kere tanımlayıp ondan sonraki her lazım olan noktada bu çağırabilen kodu inşa etmektir bizim amacımız. Örneğin ben bir aşçı olarak bir metodoloji uyguluyorum. Uyguladığım metodoloji sayesinde yemeğimi icra edebiliyorum. Yemek oluşturabiliyorum yani yemeğim ortaya çıkıyor. Şimdi aynı metodu başka bir aşçıya söylediğim zaman metodu birebir uyguladığında aynı lezzet birebir aynı şekilde aynı görüntüde aynı tadında yemek ortaya çıkacaktır. Dolayısıyla bir metot nerede çağırırsan çağır aynı işlemi yapacaktır ve senin yapmış olduğun bu metot bu metodun işlevini bir daha tekrar etmeni engelleyecektir. İşte çağırdığın yerde bu metot işlevsel olarak orayı işleyecek ama kodun tekrarını engelleyecek.

<img src="3.png" width="auto">

- Yazılmış olan bir kodu tekrar çağırmakla, tekrar yazmak arasında fark vardır!

<img src="4.png" width="auto">

***
# 383) Metot Anatomisi Nasıldır? Gelin Metot İmzasını İnceleyelim
- C# programlama dilinde bir metot oluşturabilmek için `class` içinde çalışmanız gerekmektedir.

- Kod dosyasına baktığınızda kodun içinde `class` yapılanmasının scope'unun içinde metodunuzu tanımlayabilirsiniz.

- Metot içinde metot tanımlayamıyoruz ta ki local function'ları öğrenene kadar. Diğer alternatifleri boşvereceğiz ve `class` elemanlarıdır diyeceğiz. Sadece `class` içinde tanımlanabilir diye kabul edeceğiz.

- Bir metot oluşturabilmek için yapmamız gereken bildiriler bulunmaktadır. 

- [erişim belirleyici] [geri dönüş değeri] [metot adı] () {}
    * Bir metot tanımlama sürecinde öncelikle metodun dışarıdan erişilebilirliğini ayarlayan erişim belirleyicisi(access modifiers) dediğimiz yapılanma bildirilir.
    * İkinci olarak tanımlamız gereken geri dönüş değeri vardır. 
    * Sonuncu olarak ise metodun adını bildirmemiz gerekecektir. 
    * Ardından bir metot tanımlaması yaptığımızdan dolayı parantez açıp kapatacağız. Parantezin içerisinde parametre dediğimiz yapılanmalar olacak. 
    * Nihai olarak ilgili metoda dair operasyonel kodlarımızı barındıracak olan kısmı yani scope'larımızı açıp kapatacağız.

- Erişim belirleyicisi dediğimiz keyword ile ilgili metodu işaretleyeceğiz. Ardından bu metot geri dönüş değeri ne olabilir bunu bildireceğiz ve ardından bu metoda her şeye verdiğimiz gibi bir isim vereceğiz nasıl ki değişkenlere veriyoruz `class`lara veriyoruz aynı şekilde metoda da bir isim vereceğiz. Bir metodun olmazsa olmazı parantezi açıp kapatacaksınız ve son olarak scope yani yapılacak operasyonları barındıracak kodları yazılacağı yer olan scopelarımızı açacağız. 

- Erişim belirleyicileri(access modifiers) ileride göreceğimiz yapılardır. Oluşturulmuş olan bir yapının dışarıdan erişilip erişilmeyeceğini belirlemizi sağlayan komutlardır. Sen bir kod yazdın metot yazdın yazdığın metoda dışarıdan erişilsin mi erişilmesin mi bu dışarıdan kastımız bilgisayarın dışı ya da farklı bir aygıt değil bu bizzat bu kodun içerisinde bu metodun yazıldığı sınıfın nesnesi üzerinden erişilsin mi erişilmesin mi? 

- Dışarıdan erişilmesini istiyorsan yani yazılmış bu fonksiyona metoda erişilsin birisi kullanabilsin istiyorsan bunu `public` ile işaretlemen lazım. Yok eğer erişilmesin kardeşim benim yazdığım metoda bir tek ben erişebilirim başkası erişemez diyorsan `private` ile işaretlemen lazım.

- Metotlar yaptıkları operasyonlar/algoritmalar/işlemler neticesinde geriye değerler dönebilmektedirler. Bu değer programatik olarak yakalanabilir ve programatik olarak işlemlere tabi tutulabilir. Geri dönüş değerini ekranın çıktısıyla karıştırmamak gerekmektedir... Metodun geriye dönmüş olduğu bu değer programatik olarak kullanılabilir. Yani bu metotta yapılan işlem neticesinde Console'a ekrana bir çıktı veriyorsun ya o geri dönüş değeri değildir KARIŞTIRILMAMALIDIR! Geri dönüş değeri dediğin kavram programatik olarak tetiklenen metodun yapmış olduğu işlem neticesinde döndüğü değeri kodun içerisinde devam edebilmek yani o değeri alıp kodun içinde farklı yerlerde kullanabilmektir. Geri dönüş değeri programatik olarak kodun içinde kullanılabilen bir değerdir.

- Sen şimdi ekrana Merhaba Dünya diye bir çıktı verdin. Sen fonksiyon üzerinden vermiş olabilirsin ama bu fonksiyonun geri dönüş değeri değildir. Bu operasyonun gereğinden birisidir. Ekrana bişey yazması mı lazım yapılan algoritma da yani ilgili metodun içerisindeki operasyon ekrana bunu yazması gerekiyorsa bunu yazmıştır. Bu çıktı geri dönüş değeri olmuyor ama geri dönüş değeri dediğimiz kavram programatik olarak yani senin ekrana yazmış olduğun Merhaba Dünya programatik olarak yakalnıp içeride işleme tabi tutulmaz. Amma velakin senin metodun geriye 1/3/5/"Hilmi" dönebilir. Dönen bu değerleri biz programatik olarak yakalayıp işleme tabi tutabiliriz. `if`le `switch`le vs. böyle akış kontrol mekanizmalarıyla kontrol edip farklı algoritmaları tetikleyebiliriz. 

- Programın içerisinde bu metodun yapmış olduğu sonuç neticesinde ben daha farklı işlemler yapacaksam geri dönüş değerini kullanmam gerekecek. Örneğin diyelim ki bir öğrencinin geçip kalma durumunu hesaplayan bir fonksiyon geliştirdiğimi düşünün. Şimdi bu fonksiyon içinde yapmış olduğu işlem neticesinde geriye `true` ya da `false` dönüyor. Bu `true` ya da `false`a göre bu metodun dönmüş olduğu değere göre ben ilgili fonksiyonun değerini yakalayıp gerçek çıktıyı verebiliyorum. Diyorum ki kaldın ya da geçtin kardeşim. İşte bunu yapabilmem için ilgili fonksiyon içerideki işlem neticesinde bu öğrencinin kalıp geçtiğini programatik olarak geri döndürmeli ki ben bunu tekrardan check edip ona göre çıktılar verebileyim.

- Programlama geleneğinde her yapılanmanın bir ismi vardır. Dolayısıyla metodunda bir ismi olması gerekmektedir.

- Metotlarda da diğer yapılarda olguğu gibi bir isim almaktadırlar. Temel isimlendirme kuralları geçerlidir.

- Metot dediğimiz bu yapılanmalar dış dünyadan parametreler alabilmekte ve bu parametlerdeki değerler üzerinde işlemler gerçekleştirebilmektedir... İşte bu parametreleri parantez içerisinden alabilmekteyiz..... Bir metot illaki parametre almak zorunda değildir. Eğer ki parametre alıyorsa burada alınacak parametrenin türü cinsi belirtilmelidir.  Birden fazla parametre alabilir.
    * Örneğin `(int sayi1)` `(int sayi1, int sayi2)` ,`()`

- Metot dediğimiz yapılanma dışarıdan değerler alıp ki biz bu değerlere parametreler diyoruz. bu parametrelerden gelen değerler üzerinde kendi içinde işlemler gerçekleştirebiliyor. Haliyle bunu yaparken bu parametreleri tanımlayabildiğimiz yegane yer parantezin içidir. Parantez içerisinden biz parametreleri alabilmekteyiz. 


- Scope'lar Metodun gerçekleştireceği operasyonu/fiiliyatı/eylemi/algoritmayı oluşturduğumuz kodladığımız faaliyet alanıdır...

- `[erişim belirleyici] [geri dönüş değeri] [metot adı] ()` => Sen bir metodu ele aldığında hangi dilde olursan ol bu kısım metodun imzası diye geçer.
- `{}` => Metodun gövdesi diye geçer.
    * Bu çok önemlidir. Çünkü ileride `interface`leri ele alırken `interface`lerde metotların sadece imzaları tasarlanır gövdeleri oluşturulmaz. Gövdeleri concrete'lere bırakılır.

<img src="5.png" width="auto">

```C#
static void Main(string[] args)
{
    
}
```

- Main bir metottur. Eğer ki bir metodu hiçbirşeyle işaretlemiyorsan default olarak `private`tır. Ama yine de istersen `private` ile işaretleyebilirsin.
    * `void` geri dönüş değeridir.
    * `string[] args` parametresi vardır. Metot gövdesinden `args`a erişim sağlayabilirsin.

***
# 384) İşlevine Göre Metot Türleri Nelerdir?
- Metodu oluşturabilmek için metot imzasını bilmek gerekiyor. Ama sadece iş bilmekle yetmiyor Bu imza üzerinden yapacağınız işleme göre yapacağınız faaliyete göre metodun türünü varyasyonunu da belirlemeniz gerekiyor.

- Bir operasyon yapmanız lazım ve yapacağınız operasyonu artık bir metotta yapmanız gerektiğinin farkındasınız. Çünkü yapacağınız bu operasyon farklı yerlerde çağırılması temas edilmesi gereken bir operasyon olabilir. Şimdi farklı yerlerin her birinde sen bu kodları tekrar yazmaktansa bunu metot içerisinde yazacaksın. Yazdıktan sonra ilgili metodu lazım olan noktalarda çağıracaksın. Metodun en önemli noktası zaten bu. Yani bir program parçacığı haline gelen bu yapılanmayı sen istediğin yerde tetikleyebiliyorsun.

- Yapacağınız işe göre işin niteliğine göre ya da sonuca göre yazacağınız metot bu imza fıtratında değişkenlik yani varyasyon gösterebilir. İmza değişmez imza aynı olacak sadece farklı varyasyonlarda metot oluşturmanız gerekecektir.
 * Örneğin yapacağın işleme göre bir metot oluşturulacaksa bu işlem dışarıdan parametre alıyorsa oluşturduğun metot parametre alan bir metot olmalı. Ya da ilgili işlemi yaptıktan sonra geriye programatik bir değer döndüreceksen geriye değer döndüren bir fonksiyon olmalıdır.

- Yapılacak işleme göre 4 farklı türde/varyasyonda fonksiyon/metot oluşturulabilmektedir. Bu tüm programalama dilleri için geçerlidir. Tüm türlerin yani varyasyonların imzası yani imza fıtratı gövdesi vs. hepsi aynı. Sadece buradaki yapı değişiyor.
    1. Geriye Değer Döndürmeyen. Parametre Almayan. => Yapacağın işleme göre ilgili metot geriye değer döndürmeyebilir. Aynı zamanda parametre almayanda bir metot olabilir. Yani oluşturacağın metot hem dışarıdan bir değer almıyor hem de geriye bir değer döndürmüyor.
    2. Geriye Değer Döndürmeyen Parametre Alan.
    3. Geriye Değer Döndüren Parametre Almayan => Yapacağın fonksiyon geriye bir değer döndürüyor programatik ama dışarıdan bir değer almıyor.
    4. Geriye Değer Döndüren Parametre Alan 

- Programlamada hangi dilde çalışırsanız çalışın bir fonksiyonu oluşturabilmeniz için yapacağınız işleme göre işlemin niteliğine göre işlemdeki amacınıza göre bu 4 farklı varyasyon üzerinden fonksiyon oluşturmanız gerekecektir.


- `[erişim belirleyici] [geriye dönüş türü] [Metot Adı](......){}` => Tüm varyasyonlarda imzamız yine birebir olacaktır. Bu kalıp üzerinde 4 farklı şekilde fonksiyon yaklaşımı oluşturabilmekteyim

<img src="6.png" width="auto">

***
# 385) Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Almayan Metot Türü
- Metotlar `class` elemanıdır. İleride Object Oriented'da da `struct` dediğimiz yapılanmada eleman olarak kullanacağız.

- Local Function'lara gelene kadar metot içinde metot oluşturmuyoruz.

- Bir metot oluşturmam lazım yapacağım bir algoritma var. Eğer ki bu algoritma dışarıdan herhangi bir parametre almayacaksa ve yapılan işlem neticesinde programatik olarak geriye bir değer döndürmeyecekse geriye değer döndürmeyen parametre almayan metotun içerisinde yapılabilmektedir.

- `[erişim belirleyici] [geri dönüş değeri] [metot adi](...........)`
    * [Erişim Belirleyici] => Metot tanımlarken ilk olarak erişim belirleyicisi dediğimiz keywordü yazıyoruz.
        + Bu oluşturacağım yapının erişilip erişilmemesinin kararını veriyordu.
    * Ardından geri dönüş değerini bildiririz.
    * Ardından metoda bir isim veriyorduk.
    * Ardından parantezlerimizi açarak parametreleri tanımlıyorduk ve scope'umuzu açarak gerekli işlemlerimizi gerçekleştiriyoruz.
    
- Bir metot geriye değer döndürmüyorsa geriye dönüş değerini boş bırakamazsınız. C#'ta bir metodun geriye değer döndürmeyeceğini ifade edebilmeniz için `void` Keywordünü kullanmanız lazım 

- Bir metot geriye değer döndürmüyorsa bunun `void` ile bildirilmesi ZORUNLUDUR!!

- Sen `void`i gördüğün zaman diyeceksin ki bu metot geriye herhangi bir değer döndürmüyor. `void` yerine başka bişey olsaydı örneğin `int`,`string`, `ahmet` diye bir tür işte o zamanda ne yazıyorsa onu geriye döndürmen gerekiyordu.

<img src="7.png" width="auto">

- Eğer ki bir metot dışarıdan değer almayacaksa yani parametre almaycaksa parantez'i açıyorsun kapatıyorsun. İçeriye herhangi parametre bildirisinde bulunmana gerek yok.

- Geriye değer döndürmek demek ekrana çıktı vermek demek değildir bunu unutmayın!!!

```C#
#Geriye Değer Döndürmeyen, Parametre Almayan Metot
private void Metot1()//=> Metot1 isminde bir metot oluşturduk dışarıdan erişilemeyen Metot1 ismindeki bu metot geriye herhangi bir değer dönmüyor ve parametre 
almıyor. Bu metotla istediğinizi yapabilirsiniz. İçeride istersen `for` döngüsüyle milyonlarca dön `switch - case`ler `try catch`ler artık aklına ne geliyorsa 
ihtiyacın neyse onu yap. Sadece geriye bir değer döndürmüyor dışarıdan da değer almıyor. 
{
    System.Console.WriteLine("Geriye Değer Döndürmeyen, Parametre Almayan Metot oluşturuldu");
}
```