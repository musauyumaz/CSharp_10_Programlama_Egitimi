***
# 243) Dizi Nedir? Ne Amaca Hizmet Eder? Bir Programcı Açısından Neye Yarar?
- Diyelim ki bir sınıftayız ve sınıftaki bütün öğrencilerin yaşıyla ilgili işlem yapmak istiyorum. Normalde tek tek her bir öğrencinin yaşlarını tutmalıyım. n adet öğrencim olursa n adet değişken oluşturup bu öğrencilerin her birinin yaşını bu değişkenlerde tutup istediğim işlemi yapabilirim. Şimdi diyelim biz 40 45 kişilik sınıfta olsak yine bunları değişkenle mi tutacağız?

- Birden fazla veriyle çalışmam gerektiği durumlarda bunların herbirine bütün verileri değişkenlerde karşılarsam/tutarsam bu ne kadar efektif olabilir ki?

- Eğer ki programlamada aynı türde birden fazla değere ihtiyacınız varsa bunların her birini değişkenlerle de tutabilirsiniz ya da bunları tek bir değişken altında veri kümesi olarakta toplayabilirsiniz. Tek bir değişkenin altında veri kümesi oluşturmak programlama da dizidir.

- Tek bir değişken altında birden fazla 'aynı türde' değer toplamamızı sağlayan veri kümelerine dizi denmektedir.

- Bir tane değişken tanımlaması yapıyorsun ama bununla birden fazla değer toplayabiliyorsun. Bir sepet ama içerisinde birden fazla ürün koyabiliyorum tabiki de buradaki ürünlerim tek bir türden olan ürünler. İşte bu bir tane bir değişken ama içerisine koyduğum veriler birden fazla işte biz buna dizi diyoruz.

- Dizi bir sepet/veri kümesidir.

- Diziler içerisinde birden fazla aynı türde değer tutabilen yapılardır.

- Diziler içerisinde birden fazla farklı türde değerler tutabiliyorlar mı? Tutamıyorlar bir dizinin türü tek bir tür olabilir birden fazla türdeki veriyi karşılayamaz.

- Birden fazla türde veri tutacaksam üst bir türde tutman lazım `object` gibi ya da kalıtımsal bir üst tür olabilir.

- Prosedürel programlamanın temel veri kümeleridir. Yani yazılımsal boyutta, yazılım adına RAM'de birden fazla değeri tek bir değişken altında bir veri kümesi halinde tutabilirler....

- Diziler, veri kümeleri oldukları için, içlerindeki birden fazla veri üzerinde kümesel işlemler yapmamızı sağlayabilirler...

- Bütün bir toplu veri üzerinde istediğin herhangi bir istatiksel çalışma yapabilirsin. Tek tek verilere erişip herhangi bir çalışmayı yine yapabilirsin. Yani elinde birden fazla veri var ve bunların nerde olduğu belli.

- Diziler koleksiyon yapılarının da oluşturulmasını sağlayan yapılardır diziler.

- Diziler prosedürel programlamanın temel yapıları oldukları için daha gelişmiş yapılar olan koleksiyonlarında temelini teşkil etmektedirler ve gelişmelerine katkıda bulunmaktadırlar.

- Diziler Referans türlü değerlerdir. Yani nesnel yapıdırlar. Özlerinde `class`tırlar..

- Senin oluşturmuş olduğun dizi artık veriden daha büyük bir anlam ifade ediyor. Yani artık bir nesneye karşılık geliyor.  

- Yapısal olarak RAM'de Heap'te tutulurlar...

- Senin yaşını tutuyorsam Stack'te tutuyorum ama senin babanın kardeşinin annenin yaşlarını top yekün bir dizide tutuyorsam bu dizi nesnesi Heap'te tutuluyor tabi içindeki değerlerde uygun bir şekilde Stack'e yerleştirilmiş olacaktır.

- Dizinin kendisi sepet Heap'te tutulur.

- Dizi dediğimiz yapılanmada içerisine birden fazla değer koyabiliyoruz istediğin kadar değer koyabiliyorsun.

- Dizi içerisine her türlü değer koyulabilir. Değer türlü de olabilir Referans türlü de olabilir.

- Lakin her türlü değer koyulabilir ama diziye koyulan değerler topyekün aynı olmalıdır. Bir dizi sade ve sadece tek bir türde değer alabilir.
    * Örneğin senin dizin `int` türde bir dizi ise o zaman aldığı değerlerin hepsi `int` türde olmalıdır. Başka bir türde değer koymak mümkün değildir.

- Dizimizin her türü karşılamasını istersek eğer o zaman `Object` türünde bunları karşılarız öbür türlü gene mümkün değil `Object`te tek bir tür sağlayacağından dolayı gene buradaki prensip olması gereken kural geçerli olacaktır `Object` nihayetinde tek bir tür.

- Dizi içerisine koyulan değerler işlevsel olarak aynı mahiyette olmalıdır.
    * Örneğin yaş dizisine maaş bilgisi aynı türde olduğu halde verilmemelidir.

- Koyduğun bir dizin var içine değer koyuyorsun bu öğrencinin yaşı bir başka değer koyuyorsun müdürün almış olduğu maaş oldu mu yani şimdi? Tamam bir dizin var içinde sayısal değerler var eyvallah ama mahiyetleri farklı? tabiki de böyle olmamalı ya elinde sayısal olan öğrencilerin yaşları olan bir dizi olmalı ya da personellerin maaşlarını tutan bir başka dizi olmalı. Personel maaşlarının içerisinde ne öğrenciye ne de başka birşeye dair sayısal değer olmalı öğrencinin yaşı gibi ev numarası gibi vs. ne de öğrencinin yaşlarını tuttuğun dizinin içerisinde yaşın dışında başka bir değer olmalı tamam ikisi de `int` olabilir ama olmamalı.

- Bir veri kümesi niye vardır yazılımda?
    * Bir çalışma yapacaksın bir istatistik yapacaksın orada bir veri üreteceksin elindeki 3 tane değerden 4. bir türetilmiş değer oluşturacaksın dolayısıyla bu değerler birbirleriyle aynı olmalı sen günlük hayatta bile bir deftere birşey yazarken bir sayfada yazmış olduklarınla öbüründekiler fark yaratabiliyor. Aynı şekilde burada da dizilerde yaratacak.
    * Yazılım süreçlerinde bir destur olmalıdır yani senin yazılımında bir veritabanı bir tablo bir kullandığın sistem herşey tek birşeye odaklı olmalı. ileride biz buna Single Responsibility Principle var tek sorumluluk prensibi her şey tek bir sorumluluğu üstlenmeli tek bir taşın altına elini sokmalı. Yani bu mantık bu prensip hala işliyorsa dizide sadece tek bir mahiyette değer olması gerekiyor.

- Aynı mahiyette olmasına mümkün mertebe özen göstereceğiz eğer göstermiyorsanız kodunuz doğru olabilir ama yanlış bir tasarıma ya da mantığa sahipsiniz diyebiliriz.

- Dizinin içerisine yani sepetin içine biz değer gönderdiğimizde serseri bir düzenle/şekilde dizilmezler. Dizi dediğimiz konu yazılım dünyasına index dediğimiz kavramı kazandırdı.

- Diziler içerisine eleman/değer eklendikçe bunları serseri bir şekilde depolamaz düzenli bir şekilde sıralı depolayacaktır.

- Bunları RAM'e sıralı bir şekilde düzenli depolayacaktır. Şimdi bu depolama sürecinde RAM'ler alan tahsisinde bulunurken ilgili değerleri yerleştirirken bu değerleri daha hızlı erişebilmemiz için index kavramını oluşturur.

- Dizilerde eklenen elemanlar index ismini veridiğimiz numaralarla ardışık bir şekilde numaralandırılırlar...

- Diziler serseri bir düzende değil normal bildiğiniz olması gereken bir düzende dizideki veriler tutulmakta tutulurkende bu veriler numaralandırılmaktadır. Bu numaraya biz index numarası diyoruz.

- index no : Her bir elemena verilen ardışık sayı. 0'dan başlar n-1'e kadar gider. Yani 10 elemanlı bir dizin var sen bu elemanları koydun işte ilk koyduğun 0. index sonuncu koyduğun n-1 yani 9.index'e sahip olacaktır.

- 0'dan n-1'e kadar gitmesi bilgisi biz dizi içerisindeki elemanlara erişirken kombinasyonlarımızı bu mantığa göre oluşturuyoruz.

- index kavramı compiler tarafından kendiliğinden veriliyor yani durduk yere sen gidip vermiyorsun bir eleman ekledin diyelim 10 elemanlık bir diziye 11. elemanı eklediysen zaten o otomatik 10. index ona atanacaktır.

- Dizilerde değer versenizde vermesenizde eleman alanları tahsis edileceğinden dolayı indexler çoktan atanmış olacaktır.

- İndex kendisi otomatik sistem tarafından veriliyor sen vermiyorsun.

- Elemanlar yerleştirilirken alan tahsisinde bulunulurken sıralı bir alan tahsisinde bulunulmakta ve bu alanlar index numarasıyla numaralandırılmaktadırlar.

- Siz dizi için başta tanımlama yaparken bir alan tahsisinde bulunacaksınız bulunduğunuz alan tahsisinde zaten kendisi sıralı bir alan oluşturacaktır. Atıyorum 10 elemanlı bir dizi tanımladın o 10 elemanlı dizi anlık olarak sana oluşturulacak ve sana 0'dan 9'a kadar bürün elemanlara hazır alanlar tahsis edilmiş olacak.

- Dizi tanımlaması yaparken;
    * Hangi türde veri tutacaksan türü bildirmelisin. `type` => `int` olur, ahmet olur, mehmet olur, `char` olur.
    * `type a` Değişken tanımı
    * `type[] a` Dizi tanımı
    * `type[] name = new type[...]` 
        + `type` türünde indexer operatörü(`[]`) ile bir tane dizi istedik. Ardından bir isim verdim. Şimdi burada bir dizi değişkeni oluşturmuş oldum `type` türünde. Devamında ise `new`operatörü daha sonrasında ise yine aynı `type` ve indexer operatörünün bu sefer içine bu dizinin alacağı eleman sayısını bildiriyoruz.
        + `new`operatörü => Bir dizi nesnesi oluşturmamızı sağlar. OOP'de detaylarıyla inceleyeceğiz.
        + Eşitliğin iki tarafında bulunan `type` türü aynı olmalıdır. Yada kalıtımsal ilişkisi olmalıdır.

- Bir değişken tanımlanırken türünün yanına `[]` indexer operatörünü koyarsanız o değişken o türde bir dizi değişkeni olacaktır. Bu operatöre INDEXER operatörü ismi verilmektedir. 

- Indexer operatörü bir türün yanına verildiği zaman o türden bir değişken talebinde bulunur dizi değişkeni oluşturur. O türden bir dizi talebi oluşturmanın yöntemi türün yanına INDEXER operatörünü koymaktır.

- Dizinin eleman sayısını bildirmesi bir sınırlılıktır.

- Diziler sınırlı yapılardır. Sınırlılıklarını aşmak için koleksiyonlar ortaya çıkmıştır. Koleksiyon dediğimiz yapılar dizilerdeki sınırlılıkların aşılmış halidir.

- Bir dizi tanımlama aşamasında kaç elemanlı olacağını başta bildirmemiz bizim çalışmamız açısından birazcık kısır bir durumdur. Çünkü ben her daim kaç elemanla çalışacağımı bilemeyebilirim.

- Dizi tanımlaması Indexer operatörü(`[]`) ile gerçekleştirilir.

- Index, Indexer kavramı dizilerden gelir.... Aklımıza dizileri getirecektir....

<img src="1.png" width="auto">

***
# 244) Dizi Nasıl Tanımlanır? - 1
- Dizi dediğimiz yapılanma başlı başına sınırlılıklardan oluşan bir yapılanmadır.

- Dizi semantik açıdan seni belirli kurallara tabii tutuyor. Kurallı olması sınırlılık değildir ama yapmış olduğu o kuralın bir mantıksızlık durumu doğurabilme ihtimali bir sınırlılıktır işte. Örneğin diziyi tanımlarken o dizide kaç tane elemanın tutulacağını senin önceden bildirmen gerekiyor. Bildirmen gerekiyor ki orada çalışacağın eleman sayısına göre bir alan tahsisinde bulunsun. Her seferinde bizler çalışacağımız eleman sayısını bilemeyebiliriz. Yapacağım satışları tutacak bir dizi bugün şu anda tanımlama yaparken daha gün sona ermeden kaç tane satış yapacağımı bilme ihtimalim yok ya 1000 desem 1001 satış yaparsam ya da 1000 tane satış yaparım diyip 3 tane satış yaparsam geriye kalan 997 tanesi boşuna alan tahsis edilmiş olmayacak mı?

- Dizi diyor ki hem bana çalışacağın eleman sayısını baştan peşinen vermelisin hem de bunu bilmiyorsan benim yapacağım bişey yok.

- Yazılımda amaç bir veriyi doğru bir şekilde işleyebilmek ve sonucunu elde etmektir. Bazen bu bir veri bazen değil hatta normal hayatta bir veri değil milyon/milyar veri olacak ve bunları işlememiz gerekecek işte böyle durumlarda sen o bir veriyi bir değişkende tutarken milyarlık verileri daha gelişmiş yapılarda tutman gerekecek. Çünkü organizasyon bir yerden sonra zorlaşacak.Milyarlık verilerin olduğu bir yazılımda onlara muadil olan değişken tanımlaman ne kadar doğru olabilir? Yani hangi bilgisayar o kadar satırlık kod dosyasını açabilir? Sizin belirli bir sayıdan sonarki değerlerinizi daha gelişmiş bir değişken yapılanmasında tutmanız lazım. Bu değişken yapılanması dizi yapılanması olabilir, Koleksiyonlar olabilir, Nesneler olabilir. Object Oriented Programming'teki obje mantığı kompleks değerlere karşılık gelen kompleksleşmiş verileri daha profesyonelce tutup işleyebilmemizi sağlayan bir yaklaşımdan ibaret. Dolayısıyla seni verin ne kadar kompleksleşiyorsa yaklaşımlarında ona göre kompleksleşmeye başlıyor.

- Hem değişkenler birden fazla hemde bunların türleri aynıysa bunları tek bir dizi dediğimiz değişkenin altında toplayıp üzerinde tek tek değişken üzerinden işlem yapabiliyorum. Topyekün bunların üzerinde işlem gerçekleştirebiliyorum.

- Dolayısıyla bir kümesel işlem yapmamı sağlayan bu yapılanma ve bunun gibi kompleks yapılanmaları destekleyen diğer yapılanmalar bizim için programlama dünyasında çok ama çok önemli. Zaten bir yazılımcı diziyi bilmiyorsa/önemsemiyorsa çöp. İleride koleksiyonları daha çok kullanacağız. Diziyi adı soyadı gibi bilmeyen bir adam koleksiyonu kullansa da kullanmasa da yazılımcı değildir.

- Doğru bir tanedir doğru 2 tane olamaz. Yanlış n tane olabilir çok fazla yanlış koyabilirsiniz ortaya ama doğru bir tanedir. 

- `type[] isim = new type[......];`
    * Öncelikle bir dizinin içine alacağı elemanların türünü bildirmeniz lazım. `type` herhangi bir tür olabilir.
    * Daha sonrasında türün yanına `[]` indexer operatörü koyarız. 
    * Sonrasında eşitliğin bu tarafında ise `new type[eleman sayısı]` bildirip dizi tanımlamamızı ve değer atamamızı bitirmiş oluyoruz.
- Diyelim ki sınıftaki bütün öğrencilerin yaşlarını tutacak bir dizi tanımlayacaksam eğer 
    * `int[] yaslar = new int[5];` anlamlı bir isim veriyorum dikkat artık çoğul eki koyuyorum eğer dizi tanımlıyorsan elindeki veri birden fazla ondan dolayı çoğul eki koyuyorum anlamlı isim için.
    * `bool[] x = new bool[7];`
    * `byte[] sayilar = new byte[n];`

<img src = "2.png" width = "auto">

- Dizinin değer kısmıyla değişken kısmı aynı türde olmalıdır.

- Eleman sayısı kesinlikle belirtilmelidir boş geçemezsiniz. Eleman sayısı negatif olamaz mantıksız olur ama 0 olabilir.

- Eleman sayısını mecburi girmek zorundayız. Eleman sayısını mecburi girmek bir sınırlılıktır.

- Dizi tanımlama sürecinde eleman sayısı mecburi girilmek zorundadır. Yani dizide çalışacak değer adedi başta bildirilmelidir... Bu durum bir sınırlılıktır. Bu sınırlılığı bizim doğru bir şekilde yönetebilmemiz lazım.

- Başta bilemeyeceğimiz öngöremeyeceğimiz bir duruma karar vermek bir sınırlılıktır.

<img src = "3.png" width = "auto">

- Değer türlü bir değişken hem değişkenin kendisi/ismi/referansı Stackte hem de değeri stacktedir.

- Referans türlü bir değişken ise değişkenin ismi stack'te değeri Heap'tedir ve değer öyle 7 gibi, 3 gibi, 5 gibi, ahmet gibi bir değer değildir bir nesnedir/objecdir.

- Referans türlü değişkenlerin özelliği Stack'te değişkeni tutulurken bu değişkenin Heap'teki değeri/nesneyi referans etmesidir.

- Referanslar yine Stack'te tutuluyorda Heap'e direkt değerleri tutulacak.

- Stack kısmında referans türlü değişkelerin de referansları tutulur normal değer türlü değişkenler de tutulur Değer türlü değişkenlerin değerleri de tutulur. Referans türlü değişkenlerin değerleri Heap'te tutulur.

- Referanslar yine Stack'te tutuluyorda heap'te değerleri tutulacak.

- `int[] yaslar = new int[7];` 
    * Nesnemiz Heap'te tutulur. 
    * Heap'te tutulan bu dizi değeri kendi içinde 7 tane bir `int` alana sahip olduğunu düşünebilirsiniz.
    * Bu alanlar `int` tutuluyorsa bu alanlar Stack'te tutulmuyor mu? Aslında bu değerler Stack'te tutuluyor ama Heap'teki referanslandırılıyor yani işaret ediliyor.
    * Dizilerdeki tür yine bir değer türlü olduğu için bu değer türlüler gene Stack'te tutulacak ama sen bunlara topyekün erişirken Heap'teki nesne üzerinden erişebileceksin.

- Bir dizi tanımlaması yapıldığı an bellekte o diziyi kullansakta kullanmasakta verilen eleman sayısı kadar alan tahsisinde bulunulur...

- Dizilerde tanımlama yapıldığı an alan tahsisinde bulunulması bizim için pekte doğru bir durum değildir.

- Sen diyorsun ki ya kardeşim bana 10 alanlık bir `int` tanımla hop tanımlıyor gidiyor 10 alanlık arsa oradan sana tahsis ediyor. İyi de sen daha bunu ne kullandın ne bir değer verdin. ne herhangi bir şey yaptın ama bellekten 10 alanlık yer alındı. Tanımlar tanımlamaz geldi 10 tane alanlık yeri kapladı bu durum tabiki sınırlılıktır. 

- Kullanılmadığı halde diziler direkt olarak bellekten belirtilen eleman sayısı kadar alan tahsisinde bulunması bir sınırlılıktır.

- Kullanmadığın bir yerin direkt alan tahsisi olur mu ya? En azından şunu dese bana 7 alanlık bir alan ayırma ben kullandıkça 7 tane alan ayır dese eyvallah zaten koleksiyonda biz onu yapacağız. Sen kullanmadığın halde dizi sana alan tahsisinde bulunuyor bu bir maliyet.

- Diziler alan tahsisi yapıldığında ilgili alanlara türüne uygun default değerleri atarlar.
    * `int` -> 0
    * `string` -> `null`
    * `char` -> /0
    * `bool` -> `false`

- İllaki bir varsayılan değer verecektir.

- Bir diziyi siz tanımlar tanımlamaz alan tahsisinde bulunuyor ve direkt varsayılan değerleri ilgili alana atıyor. Yani sen kullanmasanda varsayılan değerleri atadığı için aslında bilgisayar boyutunda kullanmış oluyor.

<img src = "4.png" width = "auto">

- Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar. Bu durumda bellek boyutunda ekstradan maliyete sebep olacağı için bir sınırlılıktır.Bizim için ideal olan kardeşim bir sepet koy koyduğu kadar verdiğim eleman kadar değer kadar alan tahsisinde bulun. Hani bir artış miktarın olsun alanda senin bir dizi olduğun verisel bir küme olduğun belli olsun sana değer verdikçe git bellekten alan tahsis et. Bak bu idealdir.

- Uygulama sona erdikten sonra ilgili tahsisler Garbage Collector dediğimiz mekanizma sayesinde geri alınacaktır bunlar imha edilecekte çalışma zamanı için bu tahsis süreci çok maliyetli.

```C#
#Sınırlılıklar
//Dizilerde tanımlama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
//Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar. Bu durumda bellek boyutunda ekstradan maliyete sebep olacağı için bir sınırlılıktır.

#Diziler - Array
//Tek bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
int[] yaslar = new int[5];
string[] adsadsa = new string[999999];
```

***
# 245) Dizi Nasıl Tanımlanır? - 2
- Tanımlanan diziler bellekte alan tahsisinde bulunduktan sonra sistem tarafından otomatik indexlenirler/index numarası atanır.

- Index numarası atamak bunları 0'dan n-1'e kadar ardışık sıralarla işaretlemekti. 

- Normalde direkt varsayılan değerleri atama yapar. Birde bunun yanında index numarası/index no'yu atar. 0'dan n-1'e kadar.

- Bir dizi değeri tanımladığınızda tanımlanır tanımlanmaz bellekte bir alan tahsisi gerçekleştiriliyor ardından bu alana default değerler atanıyor ve 2. durum bu her bir alan index numarasıyla işaretleniyor.

<img src = "5.png" width = "auto">

***
# 246) Tanımlanmış Diziye Değer Atama
- `int[] yaslar = new int[7];` Görüldüğü üzere 7 tane alan tahsis edilmiştir her bir alan ilk oluşturma esnasında varsayılan değerler atanmış ve bunlar index numarasıyla işaretlenmiştir.

- Dizilere değer atarken index numaralarından yararlanıyoruz.

- Index numarası dizilere sistem tarafından otomatik verilen ve kimlik mahiyetinde kullanabileceğimiz bir numaradır.

- Her bir elemana karşılık gelen unique değerlerdir. Haliyle böyle olması demek her bir elemana istediğimiz zaman erişip değer atama yapabilmemizi yahut var olan değeri okuyabilmemizi sağlamaktadır.

- Biz burada dizilerde çalışıyorsak diziye bir değer atayacaksak index numarasından ilgili elemanı bildireceğiz ona göre değerimizi atayacağız. Nihayetinde senin dizinin elemanlarını tarif edebilmen için bunları ayıran özel kimliksel değerlere ihtiyacın var işte index burada bu görevi görüyor. 

- Dolayısıyla dizilerde tanımlanmış alanlara/elemanlara değer atama yahut değer okuma operasyonlarını index numaraları eşliğinde gerçekleştirmekteyiz.

<img src = "6.png" width = "auto">

- Dizide tanımalama neticesinde her bir elemanı türüne uygun bir tane değişken gibi düşünün. `int` türünde 7 elemanlı dizi oluşturduysan dizide 7 tane farklı değişken tanımlamıyormuş gibi düşünün ve bu değişkenlerin her biri indexlerle ayrılıyor.

- Değişken tanımladığımızda değişkenin ismini çağrırıyorduk ve ilgili ismi çağırdığımızda assign ona bişey atarken değişkenin kendisi geliyordu. Dizi üzerinden ben herhangi bir alana bir değer vermek istiyorsam bunu verirken biz index numarasını kullanıyoruz. `yaslar[3] = ...` yazarsan yani sen bunu assign operatörünün(`=`) soluna yazıp sağında herhangi bir değeri kullanırsan buradaki değer dizinin 3.indexteki değişkenine atanmış olacaktır.

- Dizilerde tanımlanan dizinin içerisine bir eleman bir değer koyabilmek istiyorsanız dizinin isminin üzerinden indexer operatörü(`[]`) ile hangi indexe eleman koyacaksanız onu bildirmeniz gerekiyor.

<img src = "7.png" width = "auto">

- Diziye eleman atarken/değer koyarken hangi index'e karşılık değer koyacaksak yine indexer operatörü(`[]`) ile bunu bildirmeli ve ilgili değeri atamalıyız... Normal değişkene değer atar gibi.

<img src = "8.png" width = "auto">

- Her ne kadar dizi de olsa içindeki elemanlar değişken gibi davranış sergiliyor. Dizinin içerisinde elemanlara değer atarken değişken davranışı gösterir. Dolayısıyla herhangi bir elemana atanan ennn sonuncu değer geçerlidir.

- Yani sen buradaki değerleri değiştirebiliyorsun burası değişken davranışı gösterir.

<img src = "9.png" width = "auto">

- Dizinin sınırı bellidir. Dizilerde eleman sınırını aşamazsınız. Eğer ki atama yaptığınız index dizide yoksa çalışma zamanı hatası alırsınız. Semantikte herhangi bir problem yok çalışma zamanında patlar. Dizide sen aralık dışında yani olmayan değer aralığını aşıyorsan orada işlem yapmaya çalışıyorsan uygulama `IndexOutOfRangeException` hatasını fırlatacaktır.

- Dizilerde değer atama ve hatta değer okuma işlemlerinde eğer ki dizinin sınırını aşarsak hata verecektir... 

- Dizinin sınırı neyse orada çalışmanız gerekiyor.

- Dizideki çalıştığımız index numarası dizinin olan indexlerinden birisi olması lazım.

<img src = "10.png" width = "auto">

- Dizilerde değer atarken illa index numarasının sıralamasına riayet etmek zorunda değiliz. Sıralı bir şekilde doldurmak zorunda değiliz. Alan önceden tahsis edildiği için önceden tahsis edilen bir alana sen zaten burada gelipte sıralı birşey atamana gerek yok zaten onlar vardı var olan default değerleriyle tanımlanmıştı onları istediğin gibi sırada serseri düzende değiştirebiliyorsun.

- Dizilerde değer ataması yaparken sıralamayı göz önünde tutmak zorunda değiliz...

<img src="11.png" width="auto">

- Dizilerde elaman sayısının aşılamaması durumu bir sınırlılıktır. Diyelim ki burada benim 7 elemanlık bir dizim var ama benim çalışacağım veri sayısı 8 oldu diyelim 9 oldu diyelim 10 oldu Şimdi ben elimdeki fazlalık değerleri elimdeki diziye veremiyorum. Dizinin boyutu bir kere tanımlandığı için büyütemiyoruz. O ilk başta nasıl tanımlandıysa ebediyen o şekilde kalır. Başk birşey yapamazsın dizinin boyutunu büyütemezsin. Böyle bir durumda senin ihtiyacın olduğu sürece dizinin aralığını dizinin eleman sayısını arttıramıyacağından dolayı bu bir sınırlılık olarak karşımıza çıkmaktadır.

- Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamayacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır.

- Yani benim elimde ne kadar veri olacağını ben bilmiyorum kardeşim madem sen bir veri kümesisin elime veri geldikçe sen ona göre kendi elemanını belirlesen de beni de yormasan desek daha iyi olur. Ama burada diyemiyoruz. Elinde kaç tane eleman olduğu önemli değil dizinin kaç tane eleman aldığı önemlidir. İleride koleksiyona geçtiğimizde ne kadar eleman geliyorsa koleksiyonun boyutu kendine göre o kadar ayarlanacaktır. Koleksiyonlar daha efektif bir kullanım sağlayacaklar. Ama dizilerde bu yok. Dizilerde başta ne verdiysen onu aşamıyorsun. Dolayısıyla dizilerdeki bu durum bir sınırlılıktır.

- Atayacağımız değer dizinin türüne uygun olmalı. Çünkü dizi kendi içerisinde vermiş olduğu türde değişkenler/alanlar oluşturuyor işte oluşturduğu alanlarda türü neyse ona uygun bir şekilde değer atamanız lazım.

```C#
#Sınırlılıklar
//Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamayacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu 
durum bir sınırlılık olarak karşımıza çıkmaktadır.

#Diziler - Array
int[] yaslar = new int[7];
yaslar[3] = 10;
yaslar[2] = 5;
yaslar[0] = 5;
// yaslar[15] = 123;//Hata
```

***
# 247) Tanımlanmış Diziden Değer Okuma
- Yine indexer operatörü(`[]`) üzerinden indexi belirterek ilgili değişkenin/elemanın değerini okuyabiliyoruz.

- Normal bir değişken assign'ın solunda çağırılıyorsa kendisi geliyordu. Assign'ın sağında ya da bir fonksiyonun parametresinde çağırılırsa değişkenin değeri gönderilir. Burada aynı mantık eğer ki bir dizinin herhangi bir elemanı assign'ın solunda çağırılıyorsa değişkenin/elemanın kendisi gidecektir ve ilgili değeri alacak ilgili yere götürecektir yok eğer assign'ın sağında ya da herhangi bir fonksiyonun parametresinde çağırılıyorsa direkt değerini gönderecektir.

- Bir dizinin değerini okumak istiyorsanız indexer operatörü(`[]`) ile ilgili elemanın index numarasını veriyorsunuz size değerini döndürüyor.

- Birden fazla aynı mahiyetteki ve aynı türdeki değerlerimi tek bir değişken ismi üzerinden organize bir şekilde yönetebiliyorum. Şimdi bu organizasyon bana çok şey getirecek. Ben karışık kompleks değişken tanımlamalarından kurtuldum isimlendirme derdinden kurtuldum.

- Dizilerde değer okurken dikkat edilmesi gereken tek mesele şudur; değer aralığını aşmamak. Bu her durumda bizim için önemli Dizilerde değer okurken değer aralığının aşılmamasına dikkat edilmesi gerekmektedir.

- Değer aralığını aşarsanız size hata verir. İlgili aralığı aştığınıza dair bir hata alırsınız.

```C#
#Diziler - Array
        
int[] yaslar = new int[7];
yaslar[3] = 10; 
yaslar[2] = 5; 
yaslar[0] = 5; 
yaslar[5] = 123; 
System.Console.WriteLine(yaslar[3]);
System.Console.WriteLine(yaslar[6]);
System.Console.WriteLine(yaslar[7]);
```

<img src = "12.png" width="auto">

***
# 248) Dizi İçerisinde Döngüyle Dönme
- Bir dizinin içerisinde illa dönmemize gerek yoktur.

- Normalde sen bir diziyi kullanırken bildiğin kurallar doğrultusunda kullanbilirsin.

- Yazılımcı olarak şiar'ın şudur senin üslubun bu olacak bildiklerinle yeni gelenler arasında bir bağıntı kurmadan gece yatmayacaksın. Bu hayatın her daim her köşesinde her noktasında olan birşey. Yeni gelen bir yapılanma öncekilerden bağımsız olamaz bir kombinasyon bir bağıntı bir ilişki kurulması lazım. Dizideki elemanları ekrana yazdırmak için ameleus yöntemiyle damarlarındaki asil kanda mevcuttur diyerek yazarsın bu yöntemle. Bir yazılımcı açısından doğru bir yöntem mi? Bir bakarsın koda değil yani dizi var şimdi diziyi ben bu şekilde kullanıyorsam birşey eksik ya ben yapıyı anlamamışım ya da bu yapı lüzumsuz dersin daha efektifliği olması lazım. Yazacağın kodu öncekilerle ilişkilendirmen lazım. Şimdi diceksin ki ya kardeşim ben döngüyü biliyorum elime gelen diziyi nasıl öncekilerle daha güzel işleyebilirim? Bir düşün.. Döngü olur değil mi?

- Bundan sonraki öğreneceklerinizde sen o düşünceye zaten varabilmek için çalışacaksın. Çalışmak demek emek harcamak demek artık işin tefekkürünü yapmak yani eldeki verileri doğru bir şekilde derinlemesine değerlendirip düşünmek.

- Diziler genellikle döngülerle kullanılırlar. Dizi elinde birden fazla veriye hakim olan bir değişken var. Bunun içerisinde verilerde sen çalışırken tek tek çalışılır mı bunda?

- Döngü yapılanmasıyla diziler genellikle bir bütün olarak işlenmekte ve çalıştırılmaktadır.

- Diziler genellikle döngülerle birlikte algoritmalarda kullanılmaktadırlar/işlenmektedirler....

- Diziler genellikle döngüler üzerinden döngülerle beraber operasyona katılırlar. Ama bu demek değildir ki %100 öyle hayır öyle değil yeri geldiğinde manuel indexer'lada çalışabilirsin. Ama döngü buradaki yapıyı daha efektif bir şekilde sağlayacaktır. Yani döngü bir yandan dönerken düşünsene 0'dan n-1'e kadar döndürebiliyorsun. Bütün sayılara karşılık gelebiliyor Haliyle bütün değerleri elde edebilirsin. Bu mantıkla düşündüğünde diziler genellikle döngülerle birlikte algoritmalarla görülecektir.

- Döngülerde genellikle dizilerle ya da ileride göreceğimiz koleksiyonlarla birlikte de kullanılmaktadırlar. Ama buradaki genelleme istisnai durumları göz ardı edin anlamına gelmiyor kesin dizi deyince aklına döngü döngü diyince aklına dizi gelmeyecek. Bu ikisi birbirine kombinasyonel olarak çok uyumlu çünkü sen birden fazla veri kümesindeki elemanlara tek tek erişmektense senin yerine bunu yapabilecek döngülerin varken bunları kullanman inanılmaz güzel efektif çözümler getirmeni sağlıyor.

<img src = "13.png" width="auto">

- Bir döngüde diziyle dönmeden kastımız herhangi bir döngü `for` ,`while`, `do while` bunların hepsi bir kombinasyona göre çalışıyor sen kombinasyonla istediğin şekilde bir dizinin içerisindeki elemanlara çok rahat ulaşıp istediğin işlemi yapabilirsin. Elemanları çok rahat elde edebilirsin ve istediğin işleme tabi tutabilirsin. 

- Bir dizide elemanların her birini döngüyle dönüp işlem yaptıracaksak eğer gerekli kombinasyonu ayarladıktan sonra döngü içinde dizinin elemanları üstünde istediğim her şeyi yapabilirim. Yani her seferinde buradaki dizinin indexlerine indexer operatörü(`[]`) ile teker teker erişip yani elemanlarını elde edip gerekli işlemleri gerçekleştirebilirim. 

- Dizi içerisinde döngüyle dönmekten kasıt onu bir bağıntı kombinasyon olarak birlikte kullanmaktır.

- Algoritma ondan sonra artık senin konuştuğun belagatına bağlı senin yapacağın edebiyatına bağlı.

- Diziyi genellikle döngülerle beraber kullanır döngülerin kombinasyonuna göre işlemler yaparız.

```C#
#Tanımlanmış Dizi İçerisinde Döngüyle Dönme
string[] personeller = new string[10];
personeller[0] = "Hilmi";
personeller[1] = "Hüseyin";
personeller[2] = "Rıfkı";
personeller[3] = "Şuayip";
personeller[4] = "Muiddin";
personeller[5] = "Naci";
personeller[6] = "Hüsnü";
personeller[7] = "Nurullah";
personeller[8] = "Cabbar";
personeller[9] = "Akif";

#Ameleus 
System.Console.WriteLine(personeller[0]);
System.Console.WriteLine(personeller[1]);
System.Console.WriteLine(personeller[2]);
System.Console.WriteLine(personeller[3]);
System.Console.WriteLine(personeller[4]);
System.Console.WriteLine(personeller[5]);
System.Console.WriteLine(personeller[6]);
System.Console.WriteLine(personeller[7]);
System.Console.WriteLine(personeller[8]);
System.Console.WriteLine(personeller[9]);

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(personeller[i]);
}
int i = 0;
do
{
    System.Console.WriteLine(personeller[i++]);
} while (i < 10);
```
***
# 249.1) Dizi İçerisinde Döngüyle Dönme Kritik
- Bir dizinin içerisinde döngüyle dönerken döngünün kombinasyonundaki eleman sayısını statik belirlememeniz gerekiyor. Çünkü bir gün bu kod değişebilir bu dizideki eleman sayıları hem artabilir hem de azalabilir. İşte böyle bir durumda gidip yazılan döngüyü de değiştirmen gerekecektir. İşte burada artık dizi değiştikçe kodun devamındaki o diziyle alakalı yapılan tüm kombinasyonlardaki değerleri katsayıları değiştirmek zorunda kalırız. İşte böyle bir durumda buradaki yapılanma/algoritma döngüdeki şartı dizinin eleman sayısına bağlayacak ama bunu pratikte yapacak yani bunu kodla yapman gerekiyor.

- Dizi içerisinde dönecek olan döngü kombinasyonunda dizinin eleman sayısını manuel bir şekilde kullanmamalı, bu sayısal değeri dizinin kendisinden almalıyız. Dizi ya kardeşim benim eleman sayım bu demeli. Aksi taktirde dizinin eleman sayısının artması durumunda veri kaybı söz konusu azalması durumunda unutursak eğer patlama/hata alma söz konusu olabilir.

- İşte bu tarz durumlarda dizinin eleman sayısı değiştikçe diziye uygun bir şekilde operasyon gerçekleştiren döngüye de diziden gelecek eleman sayısını kullanmamız lazım. Biz manuel yazmamalıyız.

<img src = "14.png" width="auto">

- Bu işi yapabilmemiz için dizilerin içerisinde `Length` dediğimiz bir özellik var.

- `Length` : Dizinin kaç elemanlı olduğunu `int` olarak geriye döndürür...

<img src = "15.png" width="auto">

- Bu durumda döngünün şart kısmına statik değer yazmaktansa dizinin `Length` özelliğini kullanarak artık dizinin eleman sayısı istediği kadar değişebilir eleman sayısı kaçsa o kadar şart kısmına direkt yansıyacaktır.Aslında buradaki manuel bağlılığı programatik bağlılığa çevirdik. Artık döngünün şart kısmındaki değerim direkt dizinin eleman sayısından geleceği için eleman sayısında hangi değişiklik olursa olsun ben kodun devamında bir düzenleme/değişiklik yapmak zorunda değilim.

- Döngülerde dönerken kombinasyon genellikle dizinin eleman sayısı üzerinden yapıldığı için eleman sayısını `Length` özelliği üzerinden alıyoruz.

```C#
#Tanımlanmış Dizi İçerisinde Döngüyle Dönme - Kritik 1
string[] personeller = new string[15];
personeller[0] = "Hilmi";
personeller[1] = "Hüseyin";
personeller[2] = "Rıfkı";
personeller[3] = "Şuayip";
personeller[4] = "Muiddin";
personeller[5] = "Naci";
personeller[6] = "Hüsnü";
// personeller[7] = "Nurullah";
// personeller[8] = "Cabbar";
// personeller[9] = "Akif";
// personeller[10] = "Ayşe";
// personeller[11] = "Fatma";
// personeller[12] = "Nuriye";
for (int i = 0; i < personeller.Length; i++)
{
    System.Console.WriteLine(personeller[i]);
}
```