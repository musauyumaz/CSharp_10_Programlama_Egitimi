***
# 126) Akış Kontrol Mekanizmaları Nelerdir? Ne Amaçla Kullanılırlar?
- Akışı kontrol eden belirli şartlara göre akışın yönünü değiştiren mekanizmalar. Buradan akıştan kastımız kodun akışı.

- Kod belirli bir akışa sahip. O akış esnasında belirli şarta göre ya şuradaki kodu ya da o akışa göre buradaki kodu işleme durumu/ihtiyacı hissedersiniz işte burada arada buradaki farkı yaratacak buradaki kontrolü sağlayacak ya bunu çalıştır ya da şuradan devam et demeni sağlayacak bir mekanizmaya ihtiyacın var biz buna akış kontrol mekanizması diyoruz.

- Kodun akışında belirli şarta göre gideceğin yönü çalıştıracağın farklı kodları belirlemeni sağlayan yapılanmaya akış kontrol mekanizması denir.

- Akış kontrol mekanizmaları kodun akış sürecinde belirli şartlara göre farklı yönlendirmeleri yapmamızı ve farklı algoritmaları/kodları/yapılanmaları çalıştırmamızı sağlayan mekanizmalardır.

- Temelde bildiğimiz iki tane mekanizma vardır. Yani koca algoritmalarda kodu akışını yönlendirmeni şarta göre akışı farklı bir şekilde yönlendirmeni sağlayan iki tane mekanizma vardır.
    * Birisi bildiğimiz `if - else` yapısı 
    * Birisi `switch` yapılanması

- Yazılım kodunun akış sürecinde şarta göre yönlendirilmesini sağlamaktadır.

- Örneğin ben sana hava yağmurluysa şemsiyeni al diyorum. Hava yağmurlu değilse şemsiyeni almana gerek yok değil mi? işte akış kontrol mekanizmaları günlük hayatta buradaki şarta bağlı nasıl hareket ediyorsan yazılımda da şarta bağlı hareket edebilmen için akış kontrol mekanizmalarını kullanman gerekiyor.

- Eğer hava yağmurluysa şu kodu çalıştır: Git şemsiyeni al. Yok eğer hava yağmurlu değilse şuradaki kod çalıştır: şemsiyeni alma öyle çık.

- Algoritmalarda ciddi manada kullanılan yapılardır. O yüzden yazılımcılar açısından olmazsa olmaz yapılanmalardır...

- İleride uzaya füze de gönderseniz akış kontrol mekanizmalarını her türlü kullanmanız gerekiyor. Ciddi manada kullanılan bir yapılanmadır.

- Akış kontrol mekanizmalarında `if - else` yahut `switch` yapılanmaları aynı işi farklı şekilde yapmamızı sağlayan birbirlerinden farklı yapılanmalardır.

- İkisi arasında teknik olarak fark olsa da işleyiş/kullanım açısından bir fark yoktur!!!

- Akış kontrol mekanizmaları yazılımsal manevratik yapılanma olarak değerlendirilmelidir.

<img src="1.png" width="auto">

***
# 127) Akış Kontrol Mekanizmaları - Switch Case
- Yazıdğımız algoritma da programda belirli şartlara göre kodun akışını belirlemizi sağlayan yapılanmalardan bir tanesidir.

- `Switch case`, kodun akışında belirli bir şarta göre yönlendirme yapmamızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır. Esasında akış kontrol mekanizmalarını hepsi bunu gerçekleştirir.

- Sen programlama da eğer ki `switch case` kullanıyorsan temelde sadece eşitlik durumuna göre bir şart uygular. 

- Eğer ki eşitlik durumuna göre bir şart varsa `switch` kullanılabilir... 

- `Switch case` yapılanması sadece bir değişkenin değerinin sadece eşitlik durumları kontrol ederken kullanılabilir.

<img src="2.png" width="auto">

- Eşitliğin dışında büyüktür(`>`), küçüktür(`<`), küçük eşittir(`<=`) vs. gibi durumları kontrol ederken `switch case` yapılanmasını kullanamazsınız. Burada `if` kullanılır.

- Akış kontrol mekanizmasında akış kontrolünü yaparken belirli bir eşitliğe göre örneğin gelen bir değer 3'mü ya da değil mi? yani eşit mi? yoksa eşit değil mi? diye kontrol ediyorsan bunu `switch` ve `if` yapılanmalarında yapabilirsin. Ama 3'ten büyük mü? 3'ten küçük mü? büyük veya eşit mi ? gibi diğer koşullara karşılaştırmalara bakıyorsan eğer işte bunu `switch`'te yapamazsın `switch` sadece eşitlik durumuna bakıyor. Bunlara `if` bloğunda bakabiliyoruz. `if` herşeyiyle beraber şartı kontrol edebilirken `switch` yapılanması sadece eşitlik durumuna göre bir kontrol ortaya koymaktadır.

- Sadece eşitlik durumu check edilecekse o zaman `switch` kullanılabilir. Bir tercih meselesidir istersen `if` ide kullanabilirsin.

- C# 7.0'dan sonra belirli desenler geldi. Pattern matching dediğimiz yapılanma da desen eşleştirmeleri dediğimiz başlıklar altında `switch` bloğuyla ilgili çok fazla özellik geldi. Bazen eşitlik durumunu kıyaslamaktan daha fazlasını yapabildiğimizi göreceğiz. Mesela `when` geldi.

- `Switch case` yapılanması sadece bir değişkenin değerini kontrol ederken ama o kontrol eşitlik durumu kontrolü olmalı büyüktür küçüktür `switch`de yapamıyorsun `switch`i unut. Eşitlik varsa `switch`de yapabiliyorsun `if`de de yapabiliyorsun. 

- `switch` kullanabilmek için öncelikle parantez açıyorsunuz ve parantez içerisine süreçte eşitlik durumu kontrol edilecek değeri yazarız. Daha sonrasında ise scope açarız bu `switch`in genel yapılanmasıdır/iskeletidir. bundan sonra kontrol edeceğimiz değeri karşılaştıracağımız/check edeceğimiz diğer harici değerleri `case` bloklarına yazarız.
    * `switch(...................){`
      + `case value1:` //`switch` yapılanmasında verilen değerin eşitlik durumlarını kontrol edeceğimiz diğer değerleri `case` bloklarına yerleştiriyoruz.

      `break;``case` ile break arasına yazılan kodlar ilgli `case`'in doğrulanması sürecinde işlenecek kodlardır. değer ile `case`'e yazılan değerin eşit olması durumunda buradaki kodlar çalışacaktır.
      + `case value2:`

      `break;` 
      + `default:`
      `break`

    `}`

- `switch - case` yapılanmasında kontrol edilen değer ile eşitlik sağlayan `case` varsa diğer `case`lere bakmaksızın `switch` bloğundan çıkılacaktır.

- `switch` yapılanmasında amaç eşitlik durumuna göre belirli bir kod bloğunu tetiklemektir.

- Eğer ki sen eşitliği bir `case`'de sağladıysan diğer `case`'lere bakmana zaten gerek yok sağladığın `case`'deki `case` ile `break` arasındaki kodları çalıştırman yeterli. 

`switch` yapılanmasında hiçbir `case` eşitlik durumunu sağlamıyorsa bu seferde `default` `break` arasındaki kodlar çalıştırılacaktır. `default` kalıbı zorunlu değildir... Eğer `default` bloğu koyduysan hiçbir `case` eşitlik sağlamazsa `default` tetiklenecektir. Hiçbiri sağlamaz ve `default` bloğuda yoksa yapacak bişey yok `switch`'teki herhangi `case` `break` arası tetiklenmeden devam edecektir.

<img src="3.png" width="auto">

- Eşitlik durumunu kontrol ederken `string`se `string`i kontrol eder `int` ise `int`i kontrol eder. Aynı türde olmasına dikkat ediyoruz.

- `case`'lerin ve şart aranacak değerin tipleri aynı olmalı.

<img src="4.png" width="auto">

- `switch` yapılanmasında kontrol ettiğimiz değerin sabit bir değer olması gerekiyor.
    * `switch("Hüseyin")` Hüseyin değerini `case`'lerle kontrol edebiliriz
    * `switch(isim)` değişken değerini de `case`'lerle kontrol edebiliriz
    * statik sabit bir değeri de kontrol edebiliriz.

- `case`'e atanan değerler bir değişken olamaz direkt sabit değer olmalıdır.

- `switch` parantezinde kontrol edilen değer bir değişken yahut sabit/statik bir değer olabilirken case bloklarındaki değerler kesinlikle sabit/statik olmak zorundadır. `case`lerdeki değerler değişkenlerden alınamaz!!!

<img src="5.png" width="auto">

- `default` `case` bloklarından hiçbiri eşleştirmeye uymuyorsa eğer varsa `default` bloğu tetiklenir... yoksa yapacak bişey yok kod akışına devam edecektir.

<img src="6.png" width="auto">

- Eğer ki bir şart karşılanırsa diğer `case` bloklarına bakmadan `switch` bloğunu terk edecektir. Çünkü burada amaç şartın eşitlik durumuna göre tek bir `case` bloğunu/kod konseptini/algoritmayı tetiklemektir.

- Eşitlik sağlandığı durumda diğer `case`lere bakmadan `switch` bloğundan çıkıp gidecektir...(compiler)

<img src="7.png" width="auto">

- `case`'lerin sıralaması önemli değildir. Amaç burada eşitlik durumuna bakmak olduğu için `case`'lerin nerede olduğu hiç önemli değil!!!

- `case` bloklarının sıralaması ve `default`'un yerleştirildiği yer önemli değildir.... Rastgele random şekilde bunları yerleştirebilirsiniz.

<img src="8.png" width="auto">

- `switch` yapılanması kodu belirli bir şarta göre farklı yönlendiren bir akış mekanizmasıdır.

```C#
#region Switch Case
//Switch case, kodun akışında belirli bir şarta göre yönlendirme yapmamızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır.
//Switch case yapılanması sadece bir değişkenin değerinin sadece eşitlik durumları kontrol ederken kullanılabilir.
//Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir.
string adi = "Ahmet";
switch (adi)//kontrol edilen türü ne ise case bloklarında da aynı türde değerlerle kontrol edilmelidir.
{
    case "Mehmet":
        Console.WriteLine("Adı Mehmet");
        break;
    case "Ahmet":
        Console.WriteLine("Adı Ahmet");
        break;
    case "Hilmi":
        Console.WriteLine("Adı Hilmi");
        break;
    default:
        Console.WriteLine("Hiçbiri değil");
        break;
}
```

***
# 128) Akış Kontrol Mekanizmaları - Switch Case'de When Şartı
- `switch` yapılanmasında temelde kullandığımız yapılanma eşitlik durumuna göre bir kıyas oluşturmamızı sağlıyordu. Yani kodun akışı esnasında elindeki bir değerin farklı değerlerle eşitlik durumunu hızlıca `switch` ile kontrol edebiliriz. bu süreçteyken sen ekstradan eşitliğin dışında başka şeyleri de kontrol etmek istiyorsan eğer `when` keywordünü kullanabiliyorsun.

- `switch` yapılanmasında sadece elimizdeki değerin eşitlik durumunu kontrol edebilmekteyiz. Bunun dışında bu kontrol esnasında farklı şartları da değerlendirmek istiyorsak eğer `when` keywordünü kullanabiliriz.

- `when` ilgili eşleştirme/eşitlik durumunu kontrol ederken ekstraları da/başka şartları da kontrol etmemizi sağlayan `switch`i zenginleştiren özel bir keyworddür.

<img src="9.png" width="auto">

- Şart mı var sonuç her daim mantıksaldır `bool`'dur. Programlama da şart diyince aklına her daim `bool` gelecek.

- `case 100 when (3 == 5):` `when` senden bir şart oluşturmanı bekliyor burdaki şarta göre de buradaki durum bir ve/and(`&&`) hem case eşit olacak ve hem de `when` yapısının içindeki şartta doğrulanmış olacak ancak o zaman komple doğrulandığı zaman buradaki blok tetiklenecektir.

- Biz burada yapısal olarak biz case bloklarındaki eşitliğin yanında ekstradan farklı şartnamelerde koymuş olduk. `when`le ekstradan şartnameler koyabilmekteyiz. 

- `when` ve/and(`&&`) mantığıyla çalışır. Bu yüzden hem `case` şartı hem de `when` şartı doğru olursa o blok çalışabilmektedir.

```C#
int satisTutari = 1000;
switch (satisTutari)
{
    case 1000 when (3 == 5):
        break;
    case 1000 when (3 == 3):
        break;
}
```

***
# 129) Akış Kontrol Mekanizmaları - Switch Case'de goto Keyword'ü
- `goto` komutuyla `switch` yapılanmasında `case` blokları arasında atlama gerçekleştirebiliyoruz.

- `switch case` yapılanmasında sadece eşitlik durumunu inceleyebildiğimiz için mantıksal bir işlem gerçekleştirememekteyiz. Dolayısıyla bazen farklı değerlere eşit olma durumunda aynı operasyonu/kodu/akışı kullanacağımız senaryolarla karşılaşabilmekteyiz...

- Farklı eşitliklerde aynı kodu çalıştıracaksak eğer kod tekrarına girmemek için goto keywordü ile şu `case`'deki kodu çalıştır diyebiliyoruz... Yani `case`ler arasında zıplama yapabiliyoruz....

- Kod tekrarına girme diyelim ki 50 tane `case` bloğum var bunlardan 3'ü 5'i aynı kod bloğunu çalıştıracaksa eğer 3'ünde 5'inde aynı tekrara gireceğine sadece bir tanesini yönlendirip/sadece bir tanesinde var olan yazılmış kodu çalıştırırsın bu şekilde de tekrardan kurtulmuş olursun. Teknik olarakta `case`ler arasında zıplamayı `goto` keywordüyle yapabilmekteyiz.

<img src="10.png" width="auto">

- Bazen bazı `case`'lerde aynı kodları çalıştırmak zorunda kalabiliriz. İşte böyle durumlarda kodu sadece tek `case`'e yazmalı diğer `case`'de ise `goto` kullanarak kod yazılan `case`'e yönlendirme yapmalıyız. `switch`de veya mantığı yapamayız.

<img src="11.png" width="auto">

- `goto case 5;` `case` 5'deki kodu çalıştır demiş oluyoruz. `goto` kullanılan `case`de `break` komutunu kullanmıyoruz!!!

<img src="12.png" width="auto">

- `goto` keywordüyle yolldağın zaman şarta bakmaz direkt algoritmasını/bloğu çalıştırır.

- `goto`keywordünün kullanıldığı case'in eşleştirmesine bakmaksızın direkt olarak kodunu/bloğunu çalıştıracaktır.

<img src="13.png" width="auto">

- `case 7:`
- `case 10: goto case 5` her ikisinden bir olduğu durumda `case` 5'e yönlendir demiş oluyoruz.

<img src="14.png" width="auto">
<img src="15.png" width="auto">

```C#
goto
int i = 10;
switch (i)
{
    case 5:
        System.Console.WriteLine(i * 10); 
        break;
    case 6:
        System.Console.WriteLine(i / 5);
        break;
    case 7:
        // System.Console.WriteLine(i * 10);//kod tekrarı vardır
        // break;
        // goto case 5;
    case 10:
        // System.Console.WriteLine(i * 10);//kod tekrarı vardır
        // break;
        goto case 5;
}
```

***
# 130) C# 8.0 Switch Expressions Nedir?
- C# 8.0 ile gelmiştir.

- Tek satırlık işlemler için maliyet düşürücü ve kullanışlı semantiklerdir.

- switch expression ile denetlenen yapılanma semantik açıdan `switch` öncesine alınır ardından `switch` yazılır. Yazdıktan sonra her bir yazılan değer check edilme durumu yapılacak değerlerdir. Hangi değere denk geliyorsa/eşleşiyorsa o anki denetlenen değer ilgili değer o değişkene atanır. Tek satırlık işlemlerde kullanılan ifadedir

<img src="16.png" width="auto">

- case ile break arasında tek satırlık bir işlem yapılıyorsa tek satırlık bir işlem olacak ve bu tek satırlık işlemde değişkene değer atama işlemi olacak işte böyle bir durumda switch expressions'ıda kullanabiliyorsunuz.

- kod maliyeti açısından yeni yöntem eski yöntemden bin kat daha iyi.

- Yapısal olarak tüm kurallar burada da geçerli. Senin denetlediğin değer tür neyse o türde bir değerlerle karşılaştırma yapıyorsun ve hangi değişkene atama yapıyorsan o değişkene uygun bir değer gönderiyorsun. Tek satırlık işlem yaparken kullandığımız bir format. Eğer ki çok satırlı işlem yapılıyorsa bu formatı kullanamayız. 
 
```C#
#region Switch Expressions
#region Eski Yöntem
string isim = "";
int i = 10;
switch (i)
{
    case 5:
        isim = "Hilmi";
        break;
    case 7:
        isim = "Rıfkı";
        break;
    case 10:
        isim = "Gençay";
        break;
    case 17:
        isim = "Musa";
        break;
    default:
}
#endregion
#region Yeni Yöntem
int j = 10;
string ad = i switch
{
    5 => "Hilmi",
    7 => "Rıfkı",
    10 => "Gençay",
    17 => "Musa"
};
```

***
# 131.1) C# 8.0 Switch Expressions - when Şartı Uygulamak
- Switch expression'larda `when` şartını da kullanabilmekteyiz. `when` şartını kullanırken dikkat edilmesi gereken nokta hem `when` şartı kullanılabiliyor yani ekstradan senin kullanmış olduğun switch expression ne de olsa bir `switch` ve bu `switch` yapılanmasında eşitlik durumunu kontrol ederken ekstradan başka şartları da devreye sokabiliyorsunuz. Hem de bunu yaparken değişken de tanımlayarak gerçekleştirebiliyorsunuz.

- Siz elinizde kontrol ettiğiniz değeri değişkene tanımlayarak atayabilirsiniz. Dolayısıyla ilgili değişken üzerinden birden fazla farklı condition'ı da verebiliyorsunuz.

<img src="17.png" width="auto">

- Elimizdeki değeri kontrol ederken eşitlik durumlarını ise operatörlerinden(`=>`) önce yazıyoruz ya burada çalışırken 2 türlü çalışma yapabiliyoruz. `when` şartını kullanabiliyoruz
    1. `5 when ...ŞART... =>`  Direkt `when` şartını kullanma eşitlik değerini yazdıktan sonra ise operatöründen `=>` önce eşitlik değerinden sonra `when` yazıp başka bir şart/başka bir condition koyabiliyorsun ortaya.
    2. `var x when x == 7 && x % 2 == 1 =>` İçeride bir değişken tanımlayıp ve tanımladığımız değişkene kontrol edilecek değerin o anki değerini verip oluşturacağımız condition'a daha derinlemesine bir şart mekanizması oluşturabiliyoruz.
        + Bir değişken kullanıyorsak kullandığımız değişkende direkt eşitlik durumunu kontrol edeceğimiz bir değer tanımlamaya gerek kalmamaktadır.
        + Yani sen bir değişken tanımlamasını gerçekleştiriyorsan sabit bir eşitlik durumu kontrol ettiğin değeri kullanmak yasaklanmıştır/kaldırılmıştır.

- Devamında ise hem `when` şartını normal kullanabiliyorsunuz hem değişken tanımlayıp bir condition kullanabiliyorsunuz ve en son hiçbiri değilse/ hiçbirinin olmadığı durumda ise yapısal olarak `var x = "Hiçbiri"` bunu kullanabiliyorsunuz. Bu default tanımlamasına denk gelecektir.

```C#
int i = 10;
string isim = i switch 
{
    5 when 3 == 3 => "Hilmi",
    var x when x == 7 && x % 2 == 1 => "Rıfkı",
    10 => "Gençay",
    5 when 3 == 3 => "Musa",
    var x => "Hiçbiri",//default : Hiçbirinin olmadığı durumda default tanımlamasına karşılık gelecektir.
};
```

***
# 131.2) C# 8.0 Switch Expressions - when Şartı Uygulamak
- İlgili değişkenin türüne uygun bir değişken tanımlamalıyız. `int x when x == 7 && x % 2 == 1 => "Rıfkı"`

- İster değişkeni `var` keywordü ile karşılabilirsin istersende kendi türünde karşılayabilirsin.

- Tanımlanacak değişkenin türü ya `var` keywordüyle compiler tarafından tanımlanan bir değişken olabilir ya da sen kendi türünü manuel bir şekilde elinle de belirtebilirsin.

```C#
int i = 10;
string isim = i switch 
{
    5 when 3 == 3 => "Hilmi",
    int x when x == 7 && x % 2 == 1 => "Rıfkı",
    10 => "Musa",
    int x => "Hiçbiri"
};
```

***
# 132) C# 8.0 Switch Expressions - Tuple Patterns
- Tuple patterns ise `switch` yapılanmasını tuple nesnelerini kontrol edebilecek şekilde hem standart hemde yeni yapılanmayla bizlere sunmaktadır.

- Eşitlik durumunu kontrol ettiğimiz yere Tuple nesnesi de koyabilmekteyiz. Yani birden fazla değerimizi Tuple olarak buraya verebiliyoruz. Ve verdiğimiz değerleri Tuple olarak eşitlik durumunu kıyaslayabiliyoruz.

- Artık bu özellikte geliştirildi ve tek satırda bu işlemi gerçekleştirebiliyoruz.

- Tek satırlık yapılan bu işlemleri siz bir değişkene atıyorsanız gene değişkende ilgili Tuple nesnesini belirliyorsunuz ve ilgili Tuple'lar tek tek ise operatörü(`=>`) ile değerlendirilmekte atanan sonuç değerler neyse mesaja gönderilmektedir.

<img src="18.png" width="auto">

- Eski `switch` yapılanmasında bir tane değer kontrol edebiliyordum. Artık birden fazla değer kontrol edebiliyorum.

- Eğer ki `switch case` yapılanmasının içinde tek satırlık işlem yapıyorsak yapmış olduğumuz tek satırlık işlemde bir değişkene değer atıyorsak switch expression mantığını kullanabiliriz.

```C#
int s1 = 10;
int s2 = 20;
string mesaj = "";
switch (s1, s2)
{
    case (5, 10):
        mesaj = "5 ile 10 değerleri";
        break;
    case (10, 20):
        mesaj = "10 ile 20 değerleri";
        break;
}
System.Console.WriteLine(mesaj);
int s3 = 15;
int s4 = 15;
string mesaj2 = (s3, s4) switch
{
    (5, 10) => "5 ile 10 değerleri",
    (10, 20) => "10 ile 20 değerleri",
    (15, 15) => "15 ile 15 değerleri"
};
System.Console.WriteLine(mesaj2);
```

***
# 133) C# 8.0 Switch Expressions - Tuple Patterns when Şartı Uygulamak
- Yine aynı mantıksa ise operatöründen(`=>`) önce `when` şartını kullanabilirsiniz. Ya da değişken tanımlayarak aynı işlemi gerçekleştirebilirsiniz.

- Değişken tanımlarken artık Tuple'ın tipi birden fazla değişkeni bir araya gelmesinden oluştuğu için bunun ortak bir türü yok muadil olarak bu Tuple olduğu için ortak bir türle karşılanmıyor. Dolayısıyla `var` keywordü ile karşılarız.

- Tek dikkat edilmesi gereken Tuple'da tür tek olmadığı için bunu karşılayabilecek bir türümüz yok. O yüzden burada `var` keywordu kullanmanız gerekecek

<img src="19.png" width="auto">

```C#
int s1 = 10;
int s2 = 20;
string mesaj = (s1, s2) switch
{
    (5, 10) when (true) => "5 ile 10 değerleri",
    var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 değerleri"
};
System.Console.WriteLine(mesaj);
```

***
# 134) C# 8.0 Switch Expressions - Positional Patterns
- Positional patterns ise `Deconstruct` özelliği olan nesneleri kıyaslmaak yahut değersel karşılaştırmak için kullanılan bir gelişimdir.

- `Deconstruct` : Nesnelerin direkt özetini veren çıktısında istediğimiz formatta özet veren bir özelliştirilmiş fonksiyondur. Esasında bu geriye Tuple gibi bir değer döner.

- `Deconstruct` bulunduran `class`'tan üretilen bir nesnenin üzerinde sen switch expression ile girdiğin zaman `Deconstruct`ın dönmüş olduğu o özet Tuple ile kıyaslama yapabiliyorsun. İşte bunu yaptığın zaman bir nesne üzerinde `Deconstruct`ın döndüğü Tuple değerine eğer ki sen switch expression'la müdahale bulunuyorsan biz buna Positional Pattern diyoruz. 

- Switch expression'larda eğer ki Tuple kullanıyorsanız kullandığınızın Tuple'ın hiçbiri anlamına gelen değeri discard dediğimiz(`_`) kavramıyla gerçekleştirilmektedir.

- `_ =>` default anlamına gelmektedir. Hiçbiri olmadığı durum anlamına gelmektedir.

<img src="20.png" width="auto">

***
# 135) C# 8.0 Switch Expressions - Positional Patterns when Şartı Uygulamak
- `when` şartını kullanmak birebir aynı mantıkta bir değeri/nesneyi/class'ı kıyaslarken biz yine `when` şartını ise operatöründen (`=>`) önce ya da değişken eşliğinde kullanabilmekteyiz.

<img src="21.png" width="auto">

***
# 136) C# 8.0 Switch Expressions - Property Patterns
- Property patterns nesnenin propertylerine girerek belirli durumları hızlı bir şekilde kontrol etmemizi gerçekleştiren ve bunu farklı değerler için birden fazla kez tekrarlı bir şekilde yapmamıza olanak sağlayan güzel bir gelişimdir.

- `class`ımız var ve bu `class`tan bir nesne üretmişiz. bu nesne üzerinden herhangi bir property'e erişerek o nesnenin property'sini `switch` bloğuyla kontrol edebiliyoruz.

- `double maas = ogrenci switch {};` Property pattern ile birlikte nesne üzerinden switch expression'a girerek daha sonrasında nesnenin property'lerine erişebilmek için scope oluşturuyoruz. Yani burada bir anonim tip oluşturuyoruz. Yani oradaki türü temsil eden bir tür oluşturmuş oluyorsun. Nesne oluşturuyorsun ve o nesnenin içerisindeki propery'leri kıyaslama yapabiliyorsun.

- Patternlar desen getiriyor yani kodun maliyetini ve yapısını biraz daha düzenliyor daha yakışıklı bir kod ortaya çıkarmamızı sağlıyor. Kodumuz bunlarla beraber daha profesyonel bir semantiğe kavuşmuş oluyor.

<img src="22.png" width="auto">

***
# 137) C# 8.0 Switch Expressions - Property Patterns when Şartı Uygulamak
- Diğerlerinden hiçbir farkı yoktur.

- Switch expression'a girdiğimiz zaman nesnenin property'sini direkt kontrol edebiliyoruz ya da istersek değişkenle condition uygulayabiliyoruz ya da ilgili ise operatöründen(`=>`) önce gelecek olan değerin hemen ardından ise operatörü(`=>`) değer arasında her zaman yaptığımız gibi `when` şartını kullanıp yine ekstradan `switch` yapılanmasını zenginleştirebiliyoruz. Daha farklı şartları incelemiş oluyoruz.

<img src="23.png" width="auto">

***
# 138) Akış Kontrol Mekanizmaları - if Yapısı
- `if` yapılanması da `switch case` gibi bir akış kontrol mekanizmasıdır. Yani uygulama da programın/yazılımın akışı esnasında belirli şartlara göre farklı algoritmaları/operasyonları tetiklememizi sağlayan yapılanmadır.

- `switch` ile aynı amaca hizmet ederler sadece teknik olarak aralarında ufak bir fark vardır. `switch` sadece elimizdeki bir değerin farklı değerlere olan eşitlik durumunu kontrol eder Yani eşitliği kontrol eder ama diğer küçüktür, büyüktür gibi diğer durumları diğer condition'ları ortaya koymamızı sağlamaz `if` yapılanmasında ise biz bütün şartları ortaya koyabiliyoruz. `if` yapılanmasında karşılaştırma operatörlerinin hepsini eşitlik durumu da dahil yani `switch`i de kapsıyor eşit değillik, büyüktür, küçüktür, büyük eşittir, küçük eşittir vs bütün karşılaştırmalar onun dışında mantıksal operatörler neticesinde elde edilen sonuçları da kıyaslamayı `if` ile gerçekleştirebiliyoruz ve hatta operatörlerde örneğin `is null`, `is not null`, `is` operatörü gibi yapılanmalarla daha da zenginleştirebiliyoruz. Yani şartın farklı türevlerini de `if` ile tam olarak kullanabilmekteyiz.

- Programlama da `switch`i değilde `if`i bildiğiniz zaman akış kontrol mekanizmaları bitmiş oluyor.

- `switch` yapılanamsı sadece eşitlik durumunda belki bir nebze olsun bir kolaylık getiriyor hele hele şu son zamanlarda çıkan patternlar sayesinde switch expression konusunun altında incelediğimiz ve bundan sonra inceleyeceğimiz patternlar sayesinde `switch` inanılmaz derece de efektif hale geldi. Yani eşitlik durumlarında `if`e nazaran daha hızlı bir semantikte kod geliştirmemizi sağlayan bir yapılanma oldu.

- `switch case` : Elimizdeki bir değerin sadece eşitlik durumunu check eden/kontrol eden kıyaslayan bir akış kontrol mekanizmasıdır. Yani senin elindeki bir değere göre o değerin eşitlik durumuna göre şu kodu çalıştır şuna eşitse bunu çalıştır diyebildiğimiz bir mekanizmadır. Eşit değilse, küçüktür, büyüktür vs karşılaştırmaları `switch` ile yapamamaktayız.

- `if` yapılanması elimizdeki bir değerin eşitlik durumu da dahil tümmmm aklına gelen bütün karşılaştırmaları yapmamızı sağlayan ve sonuca göre akışı yönlendirmemizi sağlayan bir yapıalnamadır. Zaten bir akış kontrol mekanizmasıdır.

- `if` yapılanamsı `switch`de dahil `switch`in yapmış olduğu eşitlik durumunu kontrol etme de dahil diğer aklınıza gelecek bütün işlemleri bütün kontrolleri yapmamızı sağlayan evrensel bir yapılanmadır.

- `switch` yapıalnamsını bilmeyip sadece `if` yapılanamsını bile bilseniz akış kontrol mekanizmaları bitmiştir. Bundan sonra uzaya füze de göndersen herhangi bir şarta göre farklı bir operasyon gerçekleştireceksen `if` seni her türlü destekleyecektir.

- Eşitlik durumlarında hele hele sonucu tek sonuç döndüğünüz ve bir değişkene atadığınız durumlarda `switch case`i kullanmanız `if`e nazaran daha semantik daha şık ve kısa pratik kod yazmanızı sağlayacaktır. Onun dışında `if` yapılanması da programın yegane yapı taşıdır. Yani herhangi bir programlama dili elinize alın bugün `if` yapılanmasını çok rahat içinde görebilirsiniz. Hiçbirşey bilmeyen `if` yapılanmasını bilir. 

- Prototip : `if(....kontrol edilecek değer/şart....){kodlar}` Eğer ki şart doğruysa/true ise scope'un içi yani scope içindeki kodlar tetiklenecektir. Yok eğer şart doğru değilse/false ise compiler `if`in scope'undan çıkacak/`if`in scope'una hiç girmeyecek ve yoluna devam edecektir.

- Eğer ki sen belirli bir şarta göre belirli bir kodu işleyeceksen `if`i kullanman yeterli olacaktır.

<img src="24.png" width="auto">

- `if` yapılanmasında şart kısmı her daim `bool` türde olmalıdır...

- Eğer ki bir şart varsa eğer kesinlikle bunun sonucu `bool` olmalıdır. `true` ya da `false`. Ya doğrulanmış olacak ya da doğrulanmamış olacak. Nihayetinde bir şartın sonucu 3, 5, ahmet gibi değerler olamaz. Bu `bool` duruma göre sen şartını belirleyip ona göre kodunu işliyorsun.

- `if`in şart kısmında karşılaştırma operatörleri ve mantıksal operatörlerin hepsi burada kullanılabilir.... Karşılaştırma operatörleri geriye `true` ya da `false` yani `bool` döndürür. Aynı şekilde mantıksal operatörlerde geriye `true` ya da `false` yani `bool` döndürür. Demek ki `if`in içinde hem mantıksal hem de karşılaştırma üzerine bütün operasyonlarını/bütün kıyaslamalarını/bütün şart kontrollerini/bütün kontrollerinin hepsini yapabiliyorsun. İşte buna göre de belirli bir algoritmayı tetikleyeceğiz.

<img src="25.png" width="auto">

- `if` yapılanmasında sadece işe odaklanılır. Şartın çalıştıracağı koda odaklanılır.

- `if` yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır..

```C#
bool medeniHal = true;
if (medeniHal == true)
{
    System.Console.WriteLine("Allah tek yatıkta kocatsın...");
}
//if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır..
```

***
# 139) Akış Kontrol Mekanizmaları - if Yapısı Üzerine Kritik Yapalım 1
- `if` yapılanmasında illaki `else` kullanmak zorunda değiliz. `if`ten sonra normal kodlarımızı kullanbiliriz. 

- Uygulamayı derleyip çalıştırdığında `if` bloğunda eğer ki şart `true` ise ilk önce scope içindeki kodlar çalışacak daha sonrasında `if` yapılanması sona erdiğinde ondan sonra hangi komut varsa onları işlemeye devam edecektir.

```C#
//if yapılanmasında illaki else kullanmak zorunda değiliz.
int i = 10;
if (i != 10)
{
    System.Console.WriteLine("Merhaba");
}
System.Console.WriteLine("Dünya");
```

<img src="26.png" width="auto">

***
# 140) Akış Kontrol Mekanizmaları - if Yapısı Üzerine Kritik Yapalım 2
- `if`in şart kısmında eğer ki `bool` değişken değer kullanıyorsak karşılaştırma operatörünü kullanmak zorunda değiliz...

- `bool` türdeki değişkenlerin değerleri zaten `bool` olacağından dolayı karşılaştırma operatörünü kullanmak zorunda değiliz...

- `bool` değerleri kıyaslarken illa karşılaştırma operatörlerini kullanmana gerek yok zaten direkt `bool` değer verebiliyorsun. Çünkü `if(.....Şart.....)` şart kısmı `bool` olmak zorunda. Ulan burası zaten `bool` olacakken sen bir daha karşılaştırma yapıp varolan `bool` üzerine bir daha `bool` aynı sonucu niye elde etmeye çalışıyorsun ki?

<img src="27.png" width="auto">

- Elindeki `bool` sonucun tersini alman gerekirse `!` operatörünü kullanabilirsin. 
    * `if(medeniHal)` : medeniHal `true` ise 
    * `if(!medeniHal)` : medeniHal `false` ise 

- Elindeki `bool` değerleri siz `if`de check ederken bunu karşılaştırma operatörüne tabi tutmanıza gerek yok direkt değerini yazdırıp oradaki değerin mantığına göre çalışabilirsiniz.

```C#
bool medeniHal = true;
// if (medeniHal == true)
if (!medeniHal)
{
    System.Console.WriteLine("Hayırlı Olsun");
}
#endregion
```

***
# 141) Akış Kontrol Mekanizmaları - if else Yapısı
- `if` şarta göre bir kodun çalışıp çalışmamasını belirlemektedir. Ayriyetten bir kodun şarta göre çalışıp o şartın olmadığı durumda başka bir kodun çalışmasını belirlemek istiyorsak burada `else` durumunu yani değilse durumunu devreye sokmamız gerekiyor. Eğer şöyleyse şunu yap değilse de bunu yap dememiz gerekiyor. 

- `if` yapısı -> Şarta göre bir kodun çalışıp çalışmayacağını belirleyen bir yapılanma...

- `if else` yapısı -> Şarta göre bir kodun çalışıp şartın olmadığı durumda bir başka kodun çalışmasını belirleyen bir yapılanma.... 

- Eğer sen değilseyi devreye sokuyorsan şartın olmadığı durumda da hangi kodun çalıştırılacağını akışı yine yönlendiriyorsun.

- `if` yapısında Normal akan bir kodda eğer ki şartın doğruysa şunu yap sonra yoluna devam et Eğer ki şartın doğru değilse yoluna yine devam et.

- `if else` yapısında ise Normal akan bir kodda eğer ki şartın doğruysa şunu yap sonra yoluna devam et Eğer ki şartın doğru değilse bunu yap demiş oluyorsun. Aslında bir yol var dümdüz giderken karşına 2 ayrı güzergaha giden yol çıkıyor. Sen de şartının doğruluğuna göre birini seçiyor ve gidiyorsun.

- `if else` yapısında illa akışı yönlendirmek zorundasın. Akışa illa `else` ile de olsa `if` ile de olsa araya kod sokmuş oluyorsun.

- `else` yapılanmasında şartın olumsuz/değil durumunda da çalışacak kodu belirlemiş oluyoruz!!!

- Prototip : `if(....Şart....){} else{}` Eğer ki buradaki şart `true` ise `if` bloğu çalışacak. Yok eğer şartımız `false` ise `else` bloğu çalışacaktır/tetiklenecektir..

- `if` bloğunda else varsa şartın `false` olması durumunda kesinlikle else bloğu tetiklenir....

- `if` yapılanmasında `else` bloğunu illaki kullanmak zorunda değiliz. Normalde `if` bloğunda `else` bloğu olmadığı durumlarda Şart `false` ise direkt compiler devam eder. Ama `else` bloğu varsa Şart `false` ise `else` bloğunun içerisindeki kodları tetikleyecektir.

- `if else` yapılanmasında şart doğru olduğunda sadece `if` yanlış olduğunda ise sadece `else` blokları tetiklenir. Aynı anda iki blokta kesinlikle tetiklenemez. Mantığa/Matematiğe aykırıdır.

<img src="28.png" width="auto">

- Sadece `if` bloğunun kullanıldığı durumlarda şart `true` ise `if` bloğu tetiklenecek yok eğer şart `false` ise yoluna devam edecektir. Amma velakin `if else` yapılanmasının kullanıldığı durumlarda şart `true` ise `if` bloğu tetiklenecek yok eğer şart `false` ise kesinlikle `else` bloğu tetiklenecek ve compiler yoluna devam edecektir. 

- Kalıbın içindeki kodlardan hangisinin tetikleneceğini ve `if` ve `else` durumdaki kalıptaki o davranışa göre belirleyebiliyoruz. Şart eğer `false` ise `else` kesinlikle tetiklenecek `true` ise `if` tetiklenecek.

```C#
int i = 3;
if (i > 5)
{
    System.Console.WriteLine("i değeri 5'ten büyüktür.");
}
else
{
    System.Console.WriteLine("i değeri 5'ten küçüktür.");
}
```

***
# 142) Akış Kontrol Mekanizmaları - if Else Yapısı Üzerine Kritik Yapalım 1
- `if else` yapılanmasında bizler yazmış olduğumuz kodun bazen tersini de yazmak isteyebiliriz. Manevratik bir şekilde onu tersine çevirebiliriz.

- `if else` yapılanmasında şartın işleyişine davranışına göre `true` ya da `false` döneceği için buradaki algoritma takla atabilir. Yani `if`'teki kodu `else`e `else`teki kodu `if`e vereceksin. Buna manevra diyoruz. Aslında kulağı nasıl tuttuğun gibi.

- Elimizdeki değil operatörüyle(`!`) şartın tersini alarak yapabiliriz.

- Algoritmalarda bunu çok kullanıyoruz.

```C#
int i = 10;
if (i == 10)
{
    System.Console.WriteLine("i değeri 10");
}
else
{
    System.Console.WriteLine("i değeri 10 değil");
}

Manevra

if (i != 10)
{
    System.Console.WriteLine("i değeri 10 değil");
}
else
{
    System.Console.WriteLine("i değeri 10");
}
```

***
# 143) Akış Kontrol Mekanizmaları - if Else Yapısı Üzerine Kritik Yapalım 2
- Programlama da DRY(do not repeat yourself/Kendini Tekrar Etme) prensibini öncesinde öğrenmiştik.

- `if else` yapılanmasında eğer şartımız doğruysa `if` bloğuna yanlışsa `else` bloğuna girdiğini biliyoruz. Diyelim ki `if`e de girse `else`e de girse ikisinde de çalıştırmam gereken bir kod parçasının olduğunu varsayalım nasıl bir yol izlemeliyiz?

```C#
int i = 10;
if (i == 10)
{
    System.Console.WriteLine("Merhaba");
    System.Console.WriteLine("i değeri 10");
}
else
{
    System.Console.WriteLine("Merhaba");
    System.Console.WriteLine("i değeri 10 değil");
}
```
- Her iki durumda da aynı kod olacaksa eğer biz bu kodu alacağız ve dışarıya yani kod bloklarının dışına yazacağız... 

- `if else` yapılanmasında `if` ve `else` bloklarında aynı işlemleri yapacaksak eğer bunları ikisinde de ayrı ayrı blok içerisinde tekrarlı bir şekilde yapmamamız GEREKMEKTEDİR!!! 

<img src="29.png" width="auto">

```C#
int i = 10;
if (i == 10)
{
    System.Console.WriteLine("i değeri 10");
}
else
{
    System.Console.WriteLine("i değeri 10 değil");
}
System.Console.WriteLine("Merhaba");
```

- Kod tekrarı varsa mümkün mertebe tekile indirmeye çalışacaksın. Özellikle kod tekrarları `if`, `if else`, `if else if` yapılanmalarında aşırı derecede olduğu için dikkat edeceksin. Ortak kullanman gerekenleri blokların dışına alacaksın ortak kullanmaman gerekenleri `if` ya da `else` bloklarında ilgili yerlere yerleşetireceksin. 

- Her iki durumda da ortak olacak olan/çalıştırılacak olan komutları `if else` bloğunun dışına yazmamız olayı çözecektir.

- Kod tekrar ediyorsa çok kötü/iğrenç bir kod yazdığının sinyalini bir al. Onu bir yakala.

<img src="30.png" width="auto">

***
# 144) Akış Kontrol Mekanizmaları - if Else if Yapısı
- `if else if` Yapılanması birden fazla şartın kontrol edilmesini sağlayan bir yapılanmadır. `if` yapılanmasının iskeletinin devamıdır.

- Eğer ki `if` `else` demeden `else if` diyorsanız mevcut şartın dışında başka bir şartı da kontrol edeceğinizi belirtiyorsunuz. Örneğin hava yağmurluysa şemsiyeni al değilse alma şimdi bu `if else` yapılanması. Biz burada şartı şu şekilde versek hava yağmurluysa şemsiyeni al yok eğer hava yağmurlu değil soğuksa montunu giy yok eğer bu da değilse şuysa şunu yap buysa bunu yap farklı şartlar söz konusu. Hiçbiri değilse `else` şunu yap diyebiliyorsunuz.

- Birden fazla şartı kontrol etmemizi sağlayan bir yapılanmadır.

- `if`, `if else`, `if else if` farketmez bunlarda her daim en başta bir tane `if` bulunmak zorunda. Yani sen bir şartı kontrol edeceksin. İlgili şart kontrol edildikten sonra başka bir şart geliyorsa eğer `else if` diyerek devam edeceksin. ve aynı zamanda `if`lerin yanında her daim bir şart bloğu(`(.....Şart.....)`) bulunmak zorundadır  ve `else if` istediğiniz kadar Kaç tane şartınız varsa o kadar belirtebilirsiniz.

- Prototip : `if(...ŞART...){} else if(...ŞART...){}` 

- Hangi şart `true` ise o blok tetiklenecektir. Yani oradaki kodlar çalıştırılacaktır. Hiçbiri doğrulanmazsa eğer `if` bloğundan çıkacak ve yoluna devam edecektir.

- `if` yapılanmasında herhangi biri doğrulandıysa eğer diğer `if`ler denetlenmeyecektir... yola devam edilecektir.

- Tek bir `if` bloğu yazıyorsunuz birden fazla şartı birden fazla durumu kontrol etmek istiyorsanız `else if` yapılanmasını kullanabilirsiniz. Aslında tek bir `if` bloğu var ve biz burada diğer şartlarımız için `else if`lerle uzatılmış bir iskelet yapmış oluyoruz ve bu durumda sadece bir blok tetiklenecektir.

<img src="31.png" width="auto">

- `if else` yapılanmasında kod akarken ilk önce birinci `if`in şartından başlar eğer `true` ise burdaki bloğu tetikler ve tetiklendikten sonra `if` bloğundan dışarı çıkar. Biri tetiklendiği zaman diğerlerini bir daha kontrol etmez. Yok eğer `false` ise bir sonraki `else if`e geçer aynı işi onda da yapacaktır yani bunda da şartı kontrol edecek eğer doğruysa girecek değilse girmeyecektir ve bu süreç tüm `if`ler için devam edecektir.

```C#
int sayi = 30;
if (sayi > 5 && sayi <= 10)
{
    System.Console.WriteLine(sayi * 5);
}
else if (sayi > 10 && sayi <= 20)
{
    System.Console.WriteLine(sayi * 10);
}
else if (sayi > 20 && sayi <= 30)
{
    System.Console.WriteLine(sayi * 20);
}
#endregion
```

***
# 145) Akış Kontrol Mekanizmaları - if Else if Yapısı Üzerine Kritik Yapalım 1
- `if`, `if else`, `if else if` yapılanmaları birer bütündür. Yani tek bir yapılanma tek bir iskelette olduklarından dolayı sadece tek bir blok tetiklenecektir. `if else` yapılanmasında `if` doğruysa `if` ya da `else if` lerden doğru olan tetiklenecektir.

- Bazen birden fazla şartın doğru olduğu durumlarda birden fazla işlem yapmak isteyebiliriz.

- Birden fazla şartın arasından bir tane operasyon yapmak değilde birden fazla şarta göre birden fazla işlem yapma söz konusu ise burada `else if` bizim için mantıksal hataya sebep olabilir.

```C#
int sayi = int.Parse(Console.ReadLine());
if (sayi > 100 && sayi <= 200)
{
    System.Console.WriteLine("100 ile 200 arasında");
}
else if (sayi > 200 && sayi <= 300)
{
    System.Console.WriteLine("200 ile 300 arasında");
}
else if (sayi > 200 && sayi <= 400)
{
    System.Console.WriteLine("300 ile 400 arasında");
}
```

- Senin `if else` `else if` vs. bunun gibi yapılanmaları kullanırken amacın neyse yapacağın operasyonun fıtratına uygun bir şekilde bunları kullanman lazım. Yani her daim birden fazla şart durumunda `if else if`i de kullanmak doğru değildir.

- Birden fazla şartın doğru olduğu durumda birden fazla işlem yapabilmek istiyoruz.

```C#
int sayi = int.Parse(Console.ReadLine());
if (sayi > 100 && sayi <= 200)
{
    System.Console.WriteLine("100 ile 200 arasında");
}
if (sayi > 200 && sayi <= 300)
{
    System.Console.WriteLine("200 ile 300 arasında");
}
if (sayi > 300 && sayi <= 400)
{
    System.Console.WriteLine("300 ile 400 arasında");
}
```

- `if`ler birbirinden bağımsızdır. 

- `else if` tek başına kullanılamaz.

- Birden fazla şartı kontrol edeceğin durumda şartları `if`le mi yoksa `else if`le mi kontrol edeceğinin kararını vermelisin.

- `if else if` yapılanmasıyla `if` leri parçalayıp yapmak birbirinden farklı işlemlerdir. `if`te `true` da olsa `false` da olsa tüm şartları kontrol eder amma velakin `if else if`te `true` olursa eğer diğer şartları kontrol etmeden bloğu terkeder diğer şartları göz önünde bulundurmaz bile.

- Şartlardan sadece birinin çalıştırılması durumunda birçok geçerli olan şartların içerisinden ilk geçerli olandan sadece bir tanesini çalıştırmakla bütün geçerli olanlardaki algoritmaları çalıştırmak arasında fark olacaktır.

***
# 146) Akış Kontrol Mekanizmaları if Else if Else Yapısı
- Birden fazla şartı kontrol etmemizi sağlıyor ve hiçbiri değilse de `else` bloğuyla var olan akışı karşılamamızı sağlıyor.

`if else if else` yapılanması birden fazla şartı kontrol edip hiçbir şart geçerli olmadığı durumda da `else` bloğunun tetiklenmesini sağlayıp akışı orada karşılamamızı sağlayan bir yapılanmadır.

```C#
int i = 100;
if (i < 100)
{
    System.Console.WriteLine("100'den küçük");
}
else if (i > 100)
{
    System.Console.WriteLine("100'den büyük");
}
else
{
    System.Console.WriteLine("100'e eşit");
}
```