# 335) Dizilerde Verisel Performans Nedir?
- Dizilerin getirisi olduğu kadar götürüsü de olacaktır.

- Dizi dediğimiz yapılanmalar ne kadar efektif ne kadar birden fazla veriyi yönetmemizi sağlayan yapılar olsa da davranışsal olarak maliyetli yapılanmalardır.

- Bir yazılımcının bir işi de var olan maliyetleri minimize etmek onları ortadan kaldırmaktır. Elimizdeki dizileri daha hızlı daha kaynakları az tüketecek şekilde modifiye etmek bizim içinde yazılım içinde tercih edilir durum olacaktır.

- Bir referans tarafından işaretlenmiş herhangi bir diziyi düşünelim. Bu dizi tanımlandığında RAM'de bir alan tahsisinde bulunacaktır. Bu dizinin belli bir değer aralığında çalışmak istersek eğer Range and Indices özelliğini kullanabilir ve istediğimiz aralığı elde edebiliriz. İlgili alan ayrı bir dizi olarak elde edilecek ve değerler RAM'de tekrardan tahsis edilecektir.

<img src="1.png" width="auto">

- Öncelikle bir dizi hayal edelim diyelim ki elimizde sayılar diye dizimiz olsun. 
    * `int[] sayilar = {10,20,30,40,50,60,70,80,90,100}` Böyle bir diziyi biz tahayyül edersek bunun belleğe yansıması 0'dan 9'a kadar bütün elemanları sıralı bir şekilde bellekte tutacaktır.
    * `int[] sayilar2 = sayilar[2..5]` Eğer ki bu dizinin belirli bir değer aralığında çalışmak istersek eğer Range and Indices özelliğini kullandığımızı varsayarsak örneğin elimdeki sayilar dizisini Range and Indices özelliği ile 2. indexten 5 eleman alırsam eğer benim bu operatörü kullanmam yeterli.
    * Bu operatörü kullandığımda o alandakir değerleri alacak farklı bir dizi olarak RAM'de bunu tutacaktır. İlgili alan ayrı bir dizi olarak elde edilecek ve değerler RAM'de tekrardan tahsis edilecektir.
    * Nihayetinde burada varolan değerler tekrardan mükerrer bir şekilde RAM'de tutulacak yani varken biri daha var olacak yani bu klonlanacakda diyebilirsiniz kopyalanacakta diyebilirsiniz. Uzun lafın kısası varolan değer bir daha fazladan olmuş olacak. Yani bir maliyet söz konusu.
    * Zaten var olan dizinin dışında neden başka dizi tanımlandı? Bu ekstradan maliyet değil mi?
    * Dizilerde çalışırken dizinin belirli bir aralığını tarif etmek istediğinizde bu alan RAM'de yeniden tahsis edilir. ve ilgili değerler oraya kopyalanacaktır. Dolayısıyla bu bal gibi de maliyettir.
 
<img src="2.png" width="auto">

- Esasında diziler üzerinde işlem yapmak oldukça maliyetli olabilmektedir.

- Nihayetinde dizi dediğiniz yapılanma herhangi bir işlemde tekrar edebilen bir yapılanma olabiliyor.

<img src="3.png" width="auto">

- Çünkü dizi üzerinde bir alanı temsil etmek, esasında o alandaki verileri yeni bir diziye koyarak tekrar etmek demektir.

- Örneğin bir merdiven düşünün sadece belirli basamaklarında çalışmak istiyorsam ve orayı boyayacaksam şimdi ben gelip tekrardan bu basamaklardan yaparsam aynı mermerden/malzemeden alıp bir daha dizersem orayı boyarsam ne gerçeği boyanmış olacaktır ne de bu çok mantıklı hareket olacaktır. Bazen benim dizinin üzerindeki belirli elemanları çalışmam gerekirken onları kopyalamaktansa onları temsil etmem daha doğru olacaktır. Temsil ile kopylama arasında fark var. Kopyalama dediğin var olan bişeyi çoğaltmaktır. Ama temsil etmek demek aynı şeyi işaretlemek/göstermek demektir. Hangisi değişiklik yaparsa yapsın ikisi de o değişikliği görür/orjinale yansır anlamına gelir. O yüzden bizim amacımız dizileri kopyalamaktan ziyade diziler üzerinde işlem yaparken dizinin belirli alanını/aralığını temsil etmek yani varolan orjinal değerin üzerinde o aralığı temsil edebilirsek hem maliyetten kaçınmış oluruz hemde amacımıza daha net hizmet etmiş oluruz. Dolayısıyla bu maliyetin farkında olalım.

<img src="4.png" width="auto">

- Özellikle bu maliyetli durumlar `string` değerler için fazlasıyla geçerlidir.

- Çünkü `string` değerler için kullanılan `string` fonksiyonları arkaplanda sürekli yeni diziler oluşturmakta ve yüksek maliyetli olmaktadırlar.

<img src="5.png" width="auto">

- Hatta biz bunu `string` fonksiyonlarda ciddi manada kullanıyorduk. 

- Elimizde bir `string` değer olsun bu `string` değer üzerinde yapmış olduğumuz herhangi bir fonksiyonel işlem sonuç olarak geriye bir `string` döndürüyor. Şimdi `string` bir `char` dizisi değil mi? Özünde `char` dizisi olan değerin üzerinde bir işlem yaptığında sana orjinal veriyi değil yeni bir ürettiği veriyi gönderiyor yani o `char` dizisini yeniden klonluyor sana yapmış olduğu çalışmalarla beraber yenisini gönderiyor. Eskisi ne oldu eskisi duruyor yenisi ne oldu yenisi de duruyor. Eskiden 5 dönümlük arsamız varken şimdi 10 dönümlük arsamız var ama 5'i ekili. Baktığında çok maliyetli bir durum. İşte böyle maliyetler söz konusu olabilmekte dizilerle çalışırken

<img src="6.png" width="auto">

- Hatta `string` ifadeleri `+` operatörüyle birleştirmek bile sonuç olarak eldeki `string` değerleri arttıracağından dolayı muazzam bir bellek israfına yol açmakta ve maliyeti arttırmaktadır. Bundan dolayı `string` birleştirmeler `+` operatörüyle tavsiye edilmemektedir.

- Hatta dizilerde çalışmayı yaparken `+` operatörünü kullanmak arka planda durmadan mevcut diziyi daha doğrusu `string`i durmadan türetmek anlamına geliyor.

<img src="7.png" width="auto">

- İşte diziler üzerinde yapılan çalışmalarda bu maliyeti ortadan kaldırabilmek ve daha performanslı çalışabilmek için `ArraySegment` ve `StringSegment` türleri geliştirilmiştir.

- Bu maliyetler dizisel yapılanmalarda gayet normal/doğal/tabi. Çünkü elimizdeki dizinin çalıştığımız değer aralığını temsil değil çoğaltma stratejisini uygulamamız. Çoğalttığınız zaman elinizdekini orjinali değişmez orjinali yine aynı kalır ama çoğalttığınız üzerinde işlem yapmış olursunuz ya bu belki bir yöntemdir yeri geldiğinde doğrudur da ama genel anlamda bu şekilde çalışmak %100 maliyettir biz belirli noktalarda dizinin belirli noktasında belirli bir değer aralığında çalışmak istiyorsak o değer aralığını bizim temsil edebilmemiz klonlamadan/çoğaltmadan sadece o alanda çalışmamız gerekiyor.
    * Örneğin elinizde kumanda var kumandanın belirli tuşlarını üzerinde işlem yapacağım ben boyayacağım diyorsunuz. Şimdi şurada siz şunu yapmazsınız değil mi Bu kumandanın aynısından bir tane daha yeni bir kumanda klonlayıp/çoğaltıp/üretip o alanı boyayıp bu ürettiğin boyalı kumandayı al boyadım demezsin. Naparsın böyle bir talep geldiğinde alırsın normal kumandayı sadece o alanı boyanacak alanı referans edersin o alanı boyarsın orjinal veriyi geri gönderirsin. Bu daha az maliyetlidir ama bu ihtiyaca binaen böyle daha az maliyetlidir. Eğer ki adam derse modelimiz bu kumanda bunun belirli tuşlarını boyalı olan başka bir tane istiyorum derse türetmen lazım orada sıkıntı yok. Ama genellikle senaryotik olarak türetmemen gereken durumlarda da türettiğin için maliyet söz konusu oluyor. Türetmemen gereken durumda sadece referans etmek istiyorsan o alanı işte kullanman gereken türler `ArraySegment` ve `StringSegment` türleridir.

- `ArraySegment` ve `StringSegment` türleri bir dizinin üzerinde belirli alanları referans etmemizi birden fazla değişkenle referans etmemizi sağlayan özel türlerdir. Yapısal olarak bunlar `struct`tır.

- Dizilerdeki varolan tabiatında varolan maliyeti ortadan kaldırabilmek için `ArraySegment` ve `StringSegment` kullanılır. `ArraySegment` tüm dizilerde kullanılırken `StringSegment` bunu sadece `string` türdeki değerlerdeki olan karşılığı/muadilidir. Yani sen `string` üzerinde operasyon yaparken `StringSegment`i kullanacaksın diğer dizilerde operasyon yaparken `ArraySegment`i kullanacaksın. 

<img src="8.png" width="auto">

- Elimizdeki dizide belirli bir alan üzerinde çalışacaksak biz burayı referans edip çalışıyorsak orjinal veri üzerinde amaç bu. `ArraySegment` ya da `StringSegment` bunu yapmamızı sağlar. Eğer bunları kullanmıyorsanız elinizdeki dizi üzerinde belirli bir alanda çalışacaksanız bu elinizdeki diziyi bozmaksızın bunu o alanda çalışılmış halini ya da sadece o alanı sizlere getirecektir. Dolayısıyla bu da bahsettiğimiz maliyettir.

<img src="9.png" width="auto">

- Bu türler yapısal olarak dizi yahut `string` ifadelerdeki bir bölümü temsil etmemizi sağlayan ve bütünsel açıdan ilgili veri kümesini parça parça birden fazla referans eşliğinde yönetmemize imkan veren türlerdir.

- Elinde tek bir dizi var parça parça bunu parçalayabiliyorsun birden fazla referansla bunu bütün parçalarına referans edebiliyorsun ama tek bir dizi üzerinde bu şekilde çalışabiliyorsun. Amaçta budur.

- `ArraySegment` ve `StringSegment` türleri ile belirli alanı temsil edersiniz ama çoğaltmazsınız.

- Elimizde bir tane dizi var `ArraySegment` ile bu dizi üzerindeki belirli bir alanı temsil ettiğimizi varsayalım. Bu tür sayesinde bu türden değişkende yaptığım işlemler orjinal `Array`in üzeride gerçekleştirilmekte ekstradan bir türetme ekstradan bir alan tahsisi yapılmadığından dolayı gayet performanslı bir çalışma sergilenmektedir.

<img src="10.png" width="auto">