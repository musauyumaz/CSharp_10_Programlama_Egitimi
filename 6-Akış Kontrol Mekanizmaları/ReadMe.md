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