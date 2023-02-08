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