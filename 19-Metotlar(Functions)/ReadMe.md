---
modified: 2023-03-31T10:46:23.365Z
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