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

***
# 189) ‘Hangi Döngü Nerede Kullanılır’ Yanlış Bir Sorudur! Doğru Soru ‘Hangi Döngü Nereye Yakışır’
- Yapısal olarak biz 3 tane döngü yapısını inceleyeceğiz.
    * `for` döngüsü
    * `while` döngüsü
    * `do while` döngüsü

- Hangi döngü nerede kullanılıyor sorusu yanlış bir sorudur. Çünkü hepsi bir kombinasyona bağlıdır. Hepsi bir mantığa göre çalışmakta o kombinasyondaki sonucun doğrulanmasına göre çalışan yapılanmalardır. Yani birini diğerinin yerine kullanabilirsin. Ya da sadece birini öğrenip diğerlerini öğrenmeyebilirsin. Programlama hayatın boyunca da onu kullanbilirsin.

- Döngülerde hepsi birbirlerinin yerine kullanılabiliyor. Ama bazı senaryolara bazı döngüler daha yatkındır. Örneğin ardışık bir sayım işlemi oluyorsa `for` döngüsü daha yatkındır daha çok yakışır. Ya da sonsuz bir yapılanma söz konusuysa `while` ya da `do while` daha çok yakışacaktır. `do while` ise böyle manevratik takla atacağımız belirli bir mantığa göre işleyen bir yapılanmadır. Hepsi birbirinin yerine oturabilmekte nihayetinde hepsinde bir temel bir mantık/kombinasyon işlemekte ama daha çok yakılan yönleri vardır ya da böyle yakışmayan yönleri vardır ama yakışmayan yerde de yine istediğin döngüyü kullanbilirsin.

- Hangi döngü nerede kullanılmalıdır? sorusu YANLIŞTIR! Doğru soru hangi döngü nereye/hangi senaryoya daha çok yakışır...

- Sen bir çözüm bulacan elindeki senaryoya göre bir tane döngüyü seçmen lazım rastgele gözün kapalı seçebilirsin sıkıntı yok ama hangisi daha çok yakışır sorusunu soracaksın cevabını arayacaksın.

- 1'den 100'e kadar sayman lazım bunun için `do while`de de yapabilirsin `while` de de yapabilirsina ama ardışık işlemlerde `for` döngüsünü kullanman bu senaryoda daha çok yakışacaktır.

- Sonsuz bir denetleme yapman lazım sonsuza giden bir durum yani sonunu bilemeyeceğimiz sonunu hiçbir zaman tahmin edemeyeceğimiz durumlarda işlem yapmam gerekiyorsa işte burada `for` ile de yapabilirsin `do while` ile de yapabilirsin. Ama `while`'ı daha çok severiz biz böyle durumlarda. Diğerleriyle yapamazsın anlamına gelmiyor.

- Bu döngülerin hepsi bir kombinasyona bağlı bir şekilde çalıştıkları için ennnn nihayetinde birbirlerinin yerine kullanılabilirler...
 
- Senaryoda istediğin dönügüyü seçebilirsin `for`la çözebildiğini `while`la da `do while`la da çözebilirsin. `do while`la çözdüğünü `for`la da çözebilirsin vs. 

- Nihayetinde bunlar senaryoya uygun iskeletler değil bunlar kombinasyonla sadece tetikleme yapıyor. Bir kombinasyonu var orada ona göre tetikleme yapıyorsa sen buna istediğini kullan. Madem ki bişey döndüreceksin madem ki belirli bir kod tetikleyeceksin istediğin döngüyü kullanbilirsin buradaki önemli olan hangisi daha çok elindeki senaryoya uygundur hangisi daha çok yakışıyor ona bakacaksın.

- Döngülere birbirinden farklı yapılar olarak bakmayacaksın. Birbirlerinden ayrılar farklılar tamam ama senaryo senaryo bakmayacaksın. Diyeceksin ki bu döngülerin hepsi aynı. Aynı şeyi öğreniyorum aynı işi yapabileceğim yapılanmayı öğreniyorum sadece bunlar senaryolara yakışabilecek durumları vardır onun dışında hepsinin kurallarını bildikten sonra kullanımlarıyla aynı sonuçları üretebilirim diyeceksin

<img src="1.png">