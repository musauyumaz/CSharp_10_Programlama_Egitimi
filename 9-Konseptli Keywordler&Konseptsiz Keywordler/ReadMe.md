***
# 223) Gelin Koda Bakış Açımızı Genişletelim
- Yazılım yazarken biz yazılımda belirli keywordler kullanıyoruz. Temelde bir hesap makinesi de yapsan uzaya füze de göndersen kullanman gereken keywordlerdir.

- Keyword dediğimiz yapılanma derleyici/compiler için önceden tanımlanmış ve özel anlamlara sahip olan anahtar sözcüklerdir. Belirli işlemleri belirli operasyonları gerçekleştirmemizi sağlayan operasyonel yapılanmalardır. Nihayetinde biz keywordler sayesinde kodlarımızı inşa ediyoruz.

- Örneğin `byte` keywordü değişken tanımlarken kullandığımız bir türdür. `for` döngülerde kullandığımız bir keyworddü. `while` döngülerde kullanıyorduk. `try` hata kontrol mekanizmalarında, operatörlerimiz var `is` OOP'de göreceğiz `new`

- Belirli keywordler var konseptli belirli keywordler konseptsiz kullanılır.

- Bir keywordü öğrenirken altını doldurarak öğrenmeliyiz. Yani konusuyla beraber, senaryosuyla beraber, kritikleriyle beraber ilgili keywordü öğrenmeliyiz.

- Keywordlerden kimisi temel düzeyi ilgilendirirken kimisi ileri düzey programlamada mantığa göre işlem yapan keyworddür. Örneğin `byte` değiken tanımlarken kullanılırken `yield` ise ileri düzey programlama da kullanılır. `int`, `for` temel prosedürel programlamada kullanılırken `add` keywordü ileri düzeyde delegate'lerde kullanıyoruz.

<img src="1.png" width ="auto">

***
# 224) Keyword Nedir? - Operatörden Farkı Nedir?
- Keyword dediğimiz yapılanma programlamada programlama dilinin temel yapıtaşlarıdır. En atomik parçalarıdır.

- Keyword : Programlama dilinin ennnn atomik parçalarıdır diyebiliriz.

- Yani sen keywordler üzerinden programlama dilini şekillendiriyorsun.

- Keywordler atomik düzeyde önceden tanımlanmış olan metinsel yapılanmalardır. 

- Normalde assembly dilinde olan bir yapılanma değil bir keyword bir anahtar sözcük sözcük olduğundan dolayı metinsel diyoruz. Ama arka planda bunun mahiyeti compiler/derleyici açısından bir ön tanımlı nerede hangi amaca hizmet edeceği belli olan bir operasyonel yapılanmadır. Yani dilin atomik yapısı onu oraya koyduğunda bir işleme yarıyor.

- Derleyici için ön tanımlı olan, nerede hangi amaca hizmet edeceği belli ve kod içerisinde hangi noktalarda çağrılabileceği/kullanılabileceği kurallarla sınırlandırılmış olan anahtar sözcüklerdir...

- Hem atomiktirler hem de derleyici için ön tanımlıdırlar. Nerede hangi amaca hizmet edeceği bellidir. Kod içerisinde nerelerde kullanabileceğiniz çağırabileceğiniz bellidir. Bunların belirli kuralları vardır. Sınırlandırılmış yapılanmalardır. Örneğin `class` bir metodun içerisinde çağrılamaz. Metot dediğimiz yapılanma `class` dışında `namespace` içerisinde tanımlanamaz. Ya da `string` ifadesi değişkenlerin önüne gelebilir ama yanına gelemez ya da `class`ın yanına gelemez vs. Bunun gibi nerelerde kullanabileceği bellidir sınırlandırılmıştır.

- Operatörler essas olarak belirli bir operasyonu/eylemi üstlenen yapılardır. Halbuki keywordler daha geniş kavramdırlar.

- Bazen bir keyword bir operatörü temsil edebilir. `is` keywordünde olduğu gibi ya da `typeof` keywordünde olduğu gibi. `typeof` bir keyworddür ama operatör işlemi yapan bir keyworddür. Her keyword operatör değildir. örneğin `static`te olduğu gibi `class`ta olduğu gibi.
 
- Direkt bir eyleme/fiiliyata odaklanan bir yapılanma varsa bu zaten bir operatördür. Ama yoksa örneğin `static`te `class`ta olduğu gibi daha farklı amaçlara hizmet ediyorlarsa eylem değil de daha farklı bir modellemeye falan bunun gibi yapılanmalara hizmet ediyorsa bunlar artık keywordlerdir.

- Operatörler keywordlerin kapsadığı bir yapılanmadır. Her keyword bir operatör değildir ama her operatör esasında bir keyword olarak kullanılabilir. Sembolik operatörler içinde söyleyebiliriz bunları. `==`, `+` operatörüde nihayetinde dilin bir atomik parçası bir işlemi yürüten bir keywordüdür diyebiliriz. Sadece metinsel değilde sembolik bir keyworddür.

- Operatörler esasında bir keyworddür Lakin her keyword bir operatör değildir....

- Kodlarımızı inşa ederken bir konu/mesele var bu konuyu hem öğreniyorsun hem gerçekleştiriyorsun. Burada kullanacağın keywordleri bilmen lazım.

- Keywordleri nerelerde ne amaçla kullandığımızı bilmemiz kesinlikle gerekecektir. 

- Örneğin bizim bir `var` diye keywordümüz var. `var` keywordü hem pattern matchinglerde farklı bir operasyona yarıyor. Normal değişken seviyesinde bambaşka bir operasyona yarıyor. `var` keywordü değişken seviyesinde compile/derleme zamanında atanan değerin türüne bürünüyordu pattern matchingde ise runtime'de bürünüyordu.

<img src="2.png" width ="auto">