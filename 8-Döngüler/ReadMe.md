***
# 188) Programlamada Nedir Bu Döngüler? Ne Amaçla Kullanılır?
- Tekrar eden yapılanmaları tekrar eden kodlarımızı tekrar etmesi gereken programlarımızı bir koşula bağlı olarak yani kombinasyona bağlı olarak belirli sayıda tekrarlayabilen işleyebilen yapılara döngü diyoruz.

- Döngü dediğimiz yapı fiziksel olarak dönen ve üzerinde işlem yapılan yapılanma değil. Döngüden kastımız burada dönmesinden kasıt belirli bir koşula belirli bir kombinasyona bağlı olması koşul doğrulandıkça o kombinasyonun koşulu doğrulandıkça bu döngü kendi içerisindeki kodları tekrar eder tekrardan tetikler. Tekrardan tetikleme operasyonu neticesinde buna en güzel isim döngü olarak verilmiştir.

- Döngü yapısı programlamanın temelini teşkil eder. Temel yapıtaşlarından birisidir. Değişkenler nasıl yapıtaşlarından birisi `if else`, `switch`, akış kontrol mekanizmaları hata kontrol mekanizmaları bunlar programlama dilinin kendi fıtratında olan bir temel yapıtaşıysa dögü de aynı şekilde programlama dilinin dahilinde olan bir yapıtaşıdır. Hatta bir programlama dilinde döngü yoksa ki mümkün değil o programlama dilinde hiçbişey yapamazsınız.

- Siz yapısal olarak han daavranış olarak şöyle bir ihtiyaca sahip olabilirsiniz en temelde olayı değerlendirelim. Diyelim ki ekrana 10 defa kendi adımı yazdıracaksam 10 kez `Console.WriteLine("Musa UYUMAZ")` yazarak yazıdrabilirim. Şimdi bir yazılımcı probleme öyle ya da böyle çözüm bulur. Sıkıntı değil. İster 10 defa teker teker yazarsın biz buna ameleus felsefesi diyoruz. Ya da biz burada kodları tekrar etmektense bunlardan bir tanesini numune olarak alır derim ki 1'den 10'a kadar bir kombinasyon oluşturur ve ilk değerimi sayısal bir değeri birer birer arttırarak 10'dan küçük olduğu her bir durumda bu kodu tekrar ettiririm. Dolayısıyla tekrar eden bu tarz kodları döngülerle tek satırda tek tanımlama da belirli kombinasyona dair yani oradaki koşula bağlı bir şekilde istediğim kadar tetiklettirebilirim.

- İstediğin kadar tetiklettirebileceğin bir yapılanma varken bunu manuel bir şekilde yazmak doğru değildir. Döngüler yapısal olarak koşula bağlı belirli sayıda bu koşul sağlandığı sürece ilgili kodu tekrarlayan yapılardır. Ben öyle bir kombinasyon koyacağım ki ortaya benim istediğim sonucu bana verecek tek satırlık/konseptlik/algoritmalık işlem olacak. 

- Döngü dediğimiz yapılanma sizin kodlarınızdaki analitik çözümleri hızlı bir şekilde yapmanızı sağlayan yapılanmadır.

- Temelde 3 tane döngümüz vardır.
    * `for` döngüsü
    * `while` döngüsü
    * `do while` döngüsü

- `foreach` bir döngü değildir iterasyondur.

```C#
# Döngüler Nedir?
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");
System.Console.WriteLine("Musa UYUMAZ");   
```