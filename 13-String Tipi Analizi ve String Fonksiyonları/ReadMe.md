***
# 295) String Türü ve String Gerçeği
- `string` özel bir türdür. Metinsel ifadeleri tutabildiğimiz özel bir türdür.

- `string` referans türlü bir değişkendir.

- Referans türlü binlerce milyonlarca değişken olabilir ama referans türlü olupta programlama dilinde bir keywordle karşılanabilen tek tür `string`tir.

- Normalde değer türlü değişkenlerin her birini programlama dilinde karşılığı olan bir keywordle tutuyoruz.
    * bu keywordler programlama dili tarafından önceden tanımlanmış keywordlerdir.
    * `int` 
    * `short`
    * `bool`
    * `char`

- Değer türlü değişkenlerin hepsi için programlama dilinde tanımlanmış bir keyword vardır. Amma velakin referans türlü değişkenleri OOP'yi özellikle gördüğünüzde programlama dilinde bunların genelinin yani %99.9'unun keywordü yoktur. O zaten %0.1'lik kısım `string`tir. `string` bir referans türlü olduğu halde programlama dilinde tanımlanmış olan keyworde sahip tek referans türlü değerdir.

- `string` referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.

- Referans türlerin arasında bir keyworde karşılık gelen referans türlü değer `string`tir.

- Referans türlü değerler herşey olabilir. Örneğin ben Ahmet diye referans türlü değişken oluşturabilirim. Ahmet keyword mü oluyor tür mü oluyor. Şimdi tür oluyor ama bunu programalama dilinin parçası olan bir keyword olarak kullanamayiz. ve bu bütün referans türleri için geçerlidir. Sadece `string` programlama dili tarafından tanımlanabilir bir keyworde sahiptir.

- `string` yapısal olarak her ne kadar değer türlü değişkenmiş gibi kullansakta esasında referans türlü bir değişken.

- Bir değişken eğer değer türlüyse bu belleğin Stack kısmında tutulur.

- Bir değer türlü değişken varsa eğer bu belleğin Stack kısmında kendi değişkeniyle değeriyle beraber tutulacaktır. Hem değişken tutuluyor hem de değeri Stack'te tutuluyor. Amma velakin bir değer/değişken referans türlüyse değişken kısmı Stack'te tutulur. Değeri Heap'te tutulur. Referans türlü denmesinin sebebi bu değişkenin değeri referans etmesidir. Uzaktaki birşey referans edilir. Uzakta olan bir şeyi referans etmem onu işaretlemem işaret etmem anlamına gelir. `string` dediğimiz ifadeler referans türlü değişkenler/değerler oldukları için Heap'te tutulurlar. Heap'te tutulan bu değer esasında bizim için bir nesnedir.

<img src = "1.png" width = "auto">

- Her ne kadar değer türlü değişken gibi kullansakta `string` bir referans türlü değişkendir. Heap'te tutulur aslında bir nesnedir. Amma velakin referans türlü değişkenlerin arasında sanki değer türlüymüş gibi tek keywordü olan değişkendir/türdür/değerdir.

```C#
#String
//`string` referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
int a = 5;
string b = "Hilmi";
```

***
# 296.1) Null - Empty Durumları, Farkları
- `string` referans türlüdür dedik. Referans türlü değişkenler `null` değer alabilir. Değer türlü değişkenler `null` değer alamaz. Değer türlülerin `null` alabilmesi için nullable yapılması gerekir.

- `string` hem `null` değer alabiliyor hem de empty olabiliyor. 

- Bir referans türlü, nullable değişken eğer ki `null` ise onun bellekte karşılığı yok demektir. Bu bir alan tahsisi bile yapmamış anlamına geliyor.

- Bir değişken/nullable/referans eğer ki `null` alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.

- Bellekte 2 tane alan vardır biri Stack biri Heap sen bir değişken tanımlıyorsun şimdi bu değişken stack'te bir isim/değişken/referans olarak tanımlanabilir ama eğer ki bu `null` ise bunun bir karşılığı yok anlamına geliyor. Herhangi bir şeyi referans etmiyor anlamına gelecek. Evet bir değişken var ama tuttuğu herhangi bir değer yok. Değer olmadığından dolayı bu `null` anlamına geliyor.  karşıda bir anlamı tahsisi olmadığı durumda `null` söz konusudur.

- Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. Lakin alan tahsisinde bulunulmuştur.

- Şimdi `null` ben bir değişkenim ama bir alan tahsisinde bulunmadım havada bir değişkenim. Ben eğer ki empty olan bir değişkensem alan tahsisinde bulundum arsa boş.

- `null` arsa yok ama bir değişken var bir vatandaş var ama arsası bile yok. Empty vatandaş var arsası da var ama ev yok arsa boş. Yani empty'de alan tahsisi yapılıyor ama değer koymuyoruz yani içi boş olan ama bir alan tahsisi yapılmış bir değişkenden bahsediyoruz.

- Sen bir değişkeni `null` olarak atıyorsan `null` veriyorsan buna o değişken tanımlanır ama o değişkenin karşılığında alan tahsisinde bulunulmaz. Yani senin belleğin 100 birimlik bir bellekse hala 100 olarak kalmaya devam eder. Amma velakin empty değerini atıyorsan empty olan değişkende bir alan tahsisinde bulunulur yani 100 birimlik alan 99'a düşer amma velakin ilgili alana bir değer koymazsın içi boş olur.

- Değişkende alan tahsisinde bulunup ilgili alana bir değer koymuyorsan biz buna empty durum diyoruz.

- Değer türlü değişkenler `null` alamazlar!

- `null` alabilen türler sadece referans türlerdir.

- Değer türlü değişkenlerin `null` alabilmesi için nullable(`?`) olmaları gerekmektedir.

- Eğer ki bir değer türlü değişkeni `null` alabilir yani değişkeni tanımlayacağım ama bunun karşılığında herhangi bir değer tanımlamayacağım bir alan tahsisinde bulunmak istemiyorum diyorsanız bunu nullable(`?`) yapmanız gerekmektedir. Yani değer türlü bir değişkeni `null` almasını istiyorsanız nullable(`?`) yapmanız gerekiyor.

- `string b = null;` `string` değişken tanımlanmıştır amma velakin buna bir alan tahsisinde bulunulmamıştır.

- Tüm değerler empty atanabilir.

- Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.

- Default değerlerin olduğu durumlar empty olarak geçerler.

- Bir değer türlü değişkene sen varsayılan default değerini atarsan ilgili değişken empty olarak nitelendirilir.

- Bir dizi tanımladın ve tanımlamış olduğun array'de boş bir dizi veriyorsan o da bir empty'lik durumudur. Alan tahsisi vardır ama kullanmıyorsundur.

- Empty dendiğinde aklına hiçbir tür gelmesin Empty dendiğinde aklınıza `string` bir değişkene "" değerinin verilmesi gelsin yeter.

- Eğer ki bir `string` içerisine boş `string` verirseniz bu empty'dir. Empty değer yok anlamına gelmez. Bellekte yer kaplar.

- `null` bellekte yer kaplamaz! lakin empty her ne kadar değer almasa da bellekte yer kaplayacak ve bir alan tahsisinde bulunmuş olacaktır...

<img src = "2.png" width = "auto">

- bir `string` değişkeni empty yapmak için;
    * `string a = "";`
    * `string a2 = string.Empty;`
    * iki varyasyonla da çalışabilirsiniz.

<img src = "3.png" width = "auto">

- Bizim için empty kavramı genellikle `string`te hani empty adı üzerinde zaten boş var olan alan boş. `null` yok öyle bir alan. `null` alan tahsisi bile yok empty var ama içi boş. Boş olan şey var olupta içi boş olan bişeyden bahseder. `null` o da yok hani içi boş olacak bir alan bile yok.

```C#
#Null - Empty Durumları, Farkları
        
#Null
//Bir değişken/nullable/referans eğer ki `null` alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
//Arsa Yok!
//Değer türlü değişkenler `null` alamazlar!
//`null` alabilen türler sadece referans türlerdir.
//Değer türlü değişkenlerin `null` alabilmesi için nullable(`?`) olmaları gerekmektedir.

int? a = null;
string b = null;

#Empty
//Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. Lakin alan tahsisinde bulunulmuştur.
//Arsa var lakin ev Yok arsa Boş!
//Tüm değerler empty atanabilir.
//Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
//Default değerlerin olduğu durumlar empty olarak geçer.
//Empty dendiğinde aklınıza `string` bir değişkene "" değerinin verilmesi gelsin yeter.

int a = 0;
bool b = false;
int[] x = new int[55];
string a = "";
string _a = null;
string a2 = string.Empty;
```

***
# 296.2) Null - Empty Durumları, Farkları
- `null` olan bir durum `null` olan bir değer üzerinde işlem yapmaya çalıştığımızda hataya meydan verecekken empty olan bir değer üzerinde işlem yapabiliriz.

- `null` olan bir değer üzerinde işlem yapmaya çalıştığımızda run time hatası meydana gelir. Amma velakin empty olan bir değer üzerinde işlem gerçekleştirilebilir.

- Nihayetinde olmayan bir değer üzerinde işlem yapmaya çalıştığımızda bu bir hatadır. Ama empty olan yani var bir alan tahsisinde bulunulmuş ama içinde değer olmayabilir sıkıntı yok empty olan bir değer üzerinde işlem yapmak doğrudur/işlem yapılabilmektedir. 

- `null` olan bir şeyin üzerinde işlem yapmak hataya sebep olacaktır.

```C#
#Null - Empty Durumları, Farkları
#Null
//Bir değişken/nullable/referans eğer ki `null` alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
//Arsa Yok!
//Değer türlü değişkenler `null` alamazlar!
//`null` alabilen türler sadece referans türlerdir.
//Değer türlü değişkenlerin `null` alabilmesi için nullable(`?`) olmaları gerekmektedir.
//`null` olan bir değer üzerinde işlem yapmaya çalıştığımızda run time hatası meydana gelir. Amma velakin empty olan bir değer üzerinde işlem gerçekleştirilebilir.

int? a = null;
string b = null;

#Empty
//Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. Lakin alan tahsisinde bulunulmuştur.
//Arsa var lakin ev Yok arsa Boş!
//Tüm değerler empty atanabilir.
//Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
//Default değerlerin olduğu durumlar empty olarak geçer.
//Empty dendiğinde aklınıza `string` bir değişkene "" değerinin verilmesi gelsin yeter.

int a = 0;
bool b = false;
int[] x = new int[55];
string a = "";
string _a = null;
string a2 = string.Empty;
```

***
# 297) String İfadelerde IsNullOrEmpty Kontrolü,
- `null` olan bir değerle empty olan bir değer arasında işlem farkı vardır. Empty olan bir değerin üzerinde işlem yapmaya çalıştığımızda her ne kadar beklediğimiz sonucu vermese de hata meydana gelmez çünkü bir alan tahsisinde bulunulmuş yazılım mimari ilgili alanın üzerinde çalışmasını yapabilecektir. Amma velakin `null` olan bir değişkenin üzerinde işlem yapmaya çalışırsanız yani o değişkenin bir karşılığı yok. Bir alan tahsisi yapılmadığından dolayı patlayacaktır. Dolayısıyla patlayacak uygulama sona erecektir.

- Elimizdeki `string` ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.

- Bazen biz yaptığımız operasyonlar neticesinde elde edilen `string` ifadeleri yeniden bir operasyona tabi tutmadan önce hem `null` hem de empty olup olmama durumunu kontrol ediyoruz. Empty'lik varsa sıkıntı yoktur ama biz empty olmasını da istemeyiz. Eğer ki elimizdeki `string` ifade empty ise yani demek ki boş yani demekki önceden bu değeri üretecek operasyonda bir eksiklik var o zaman başka birşey yapman lazım.

- Authorazation Authentication dediğimiz noktalar vardır. Şimdi kimlik yetkilendirme durumunda kimliği yetkilendirirken kişinin eğer ki adı `null` ya da empty ise yani bana beklediğim değerler gelmiyorsa demek ki kişi `null` da olsa empty'de olsa kişi giriş yapmamıştır o zaman önce giriş yap diyeceğim ondan sonra kişiyi authorazation yapacağım. Yani yetkilendireceğim.

- `null` olma durumu empty olma durumu davranışsal olarak yazılımda biri hata veriyor diğeri vermiyor ama biz elimizdeki `string`i işleme tabi tutacaksak elimizde bir değer olmasını isteriz.

- Bir `string` ifadenin `null` olup olmamasını empty olup olmamasını daha hızlı kontrol edebilmemiz için `IsNullOrEmpty` diye bir fonksiyonumuz var. Bu fonksiyon elimizdeki `string` ifadenin hızlı bir şekilde kontrolünü yapmamızı sağlar.

- `IsNullOrEmpty` fonksiyonu; elimizdeki `string` ifadenin `null` yahut empty olup olmama durumları hakkında bir check yapar ve geriye `bool` türde sonuç döner.

- Uzun uzun operatörlerle çalışacağına burada direkt `IsNullOrEmpty` fonksiyonunu kullanabilirsin. Elindeki `string` ifadenin `null` olup olmama durumunu empty olup olmama durumunu her ikisini de kontrol edecek ve geriye sana sonuç dönecektir.

- `string.IsNullOrEmpty(value)` 
    * parametre eğer ki `null` ya da empty ise bu ifade `true` dönecektir.
    * parametre olarak `string` değeri ister.

- Eğer ki `null` ya da empty ise geriye `true` değilse `false` dönecektir.

- Sen elindeki bir `string` ifadenin `null` ya da empty olmadığı durumlarda operasyon yapaacaksan `if(!string.IsNullOrEmpty(value))` şekilde kontrol edebilirsin.

```C#
#IsNullOrEmpty
//Elimizdeki `string` ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.
string x = "";//Empty
// string x = string.Empty;//Empty
// if (x != "")
// if (x != string.Empty && x != null)
if (x != string.Empty && x is not null)
{
    //Operasyon...
}
//IsNullOrEmpty fonksiyonu; elimizdeki `string` ifadenin `null` yahut empty olup olmama durumları hakkında bir check yapar ve geriye `bool` türde sonuç döner.
//Eğer ki `null` ya da empty ise geriye `true` değilse `false` dönecektir.
if (!string.IsNullOrEmpty(x))
{
    //Operasyon...
}
```

***
# 298) String İfadelerde IsNullOrWhiteSpace Kontrolü
- Bazen de yapılan operasyonlar neticesinde elde edilen değerler `null` da gelebilir bazen empty gelmez boşluk olarakta gelebilir.

- Elimizdeki `string` ifade empty değil içinde bir belirli karakterler barındıran yani bir metin barındıran bu metin yine space yani boşluk olan bir değer olduğunu düşünelim. Bu da bazen bizim için yeterli değildir. Bazı fonksiyonlar ya da uzaktan veri gönderen servisler `string` ifadeyi bazen boş olarak gönderebiliyor. Şimdi biz `IsNullOrEmpty` ile bunu denetlerken ne `null` ne de empty olmadığından dolayı sanki veri gelmiş gibi algılanıyor. Algoritma esnasında patlıyoruz. Ya mantık hatası ya da çalışma zamanı hatalarına sebep olabiliyor.

- Elimizdeki ifadenin `null`, empty ya da whitespace buradaki boşluklardan ibaret olmadığı durumu hızlıca kontrol edebilmek için `IsNullOrWhiteSpace` fonksiyonunu kullanabiliriz.

- `IsNullOrWhiteSpace` fonksiyonu: Elimizdeki `string` ifadenin `null`, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye `bool` `true` değerini döndüren bir fonksiyondur.

- `IsNullOrEmpty` kullanıyorsanız boşluklu/space olma durumunda empty olarak görmeyecek kod akışına devam edecektir `IsNullOrWhiteSpace` ile kontrol ederseniz boşluklu/space da olsa empty'de olsa `null` da olsa görecek ve kodun akışını etkileyecektir.

```C#
#IsNullOrWhiteSpace
// `IsNullOrWhiteSpace` fonksiyonu: Elimizdeki `string` ifadenin `null`, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye `bool` `true` değerini döndüren bir fonksiyondur.
string x = "sebepsiz boş yere ayrılacaksan";
// string x = "   ";
// string x = "";
// string x = string.Empty;
// string x = null;
if (!string.IsNullOrWhiteSpace(x))
{
    //Operasyon...
}

```