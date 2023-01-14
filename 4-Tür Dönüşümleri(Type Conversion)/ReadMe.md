***
# 77) Tür Dönüşümü Nedir? Neden Verilerin Türlerini Değiştirmek/Dönüştürmek İsteriz?
- Elimizde varsayalım ki T1 türünde bir n değeri var ve biz bu T1 türündeki n değerini süreçte T2 türüne dönüştürme yapmak istersem tür dönüşümünden yararlanırım.

- Yazılım sürecinde elimizdeki değerlerin türlerini değiştirebilmekteyiz. 

- Örneğin bir tane elma var bu elmayı biz elma türünde de tutabilirim ya da bunu meyve türünde de tutabilirim. Yani türü biraz daha genişletedebilirim ya da daraltadabilirim. Bir object'te tutup boxing'te yapabilirim.

- Bir yazılımcı hiçbir şeyi lüzumsuz yere yapmaz. Laf olsun dur ben burada bunun türünü değiştireyim diye durduk yere bir iş yapmaz.

- Örneğin senin elinde `string` -> `"123"` değeri vardır. Eğer ki sen bu 123 değerinde matematiksel işlem yapmak istiyorsan yapamazsın çünkü elimizdeki metinsel olarak tutulan sayısal değerin içerisinde/üzerinde matematiksel işlem gerçekleştiremeyiz.

- Amma velakin elimde ısrarla `string` bir tür var ve içerisinde metinsel değilde sayısala yatkın bir değer var 123'te olduğu gibi biz bunun üzerinde matematiksel işlem yapmak istersek bunu `int`,`short`,`byte` gibi türlere dönüştürüp üzerinde matematiksel işlem gerçekleştirebilirsin.

- Tür dönüşümlerinde elinizdeki verinin mahiyetine uygun bir türe dönüştürüp o türdeki işlemleri yapabilmek için kullanabiliyoruz.

- Tür dönüşümleri elimizdeki verinin fıtratındaki/mahiyetindeki türe uygun işlemlere tabi tutabilmek için uygulanabilir.
    * Elimdeki sayısal olan ama string olarak tutulan bir değeri aritmetik işleme tabi tutmak istiyorsam eğer bu değeri ben matematiksel yani sayısal değerlere dönüştürebilirim.
    * Diyelim ki uzaktan sana veri gelebilir ve diyelimki bu veri şu şekilde `string` tipinde `"true"` şeklinde olabilir. Gelen veriyi diyelim ki `if(...)` parantezleri içinde kullanmak istiyorum bu veri `string` geldi diye operasyondan vazmıgeçicem bu operasyonu gerçekleştirmeyecek miyim? Tabikide operasyondan vazgeçmeden bu gelen `string` veriyi `boolean`'a dönüştüreceksin ve operasyonu gerçekleştireceksin.

- Farklı servislerden gelen değerleri uygun türlere dönüştürmek isteyebiliriz.

- Mesela elinde `int` türünde 50 değeri var. Ben burada işlem yapacağım ama buradaki değerin üzerinde yapacağım işlemler neticesinde veri daha da büyüyor. Bu yüzden bu değeri decimal'a/long'a çevirirsin.

- Yazılımcı olarak elimizdeki veriyi kendi irademle istediğim gibi oynayabiliyorum zaten yazılımcının özelliği/özgürlüğü budur. Tabikide oynayacaksın tabikide türünü değiştireceksin.

- Ama buradaki amaç şu değildir. Dikkat!!!!
    * Elimde veri var değil mi veri ney? Elma. Elmayı meyveye dönüştürebilirim, Meyveden elmaya dönüştürebilirim amma velakin elmayı armuta dönüştüremem 

- Tür dönüşümlerinde amaç türü dönüştürmektir. Yani elimizdeki veriye uygun bir türe geçiş yapmaktır. Yani elimizdeki veriyi uygun olmayan bir türe dönüştürmeye çalışırsak bu mümkün değildir! Hata verecektir.

- Sen sayısal türe dönüşebilecek bir string ifadeyi sayısala dönüştürüyorsan amenna sıkıntı yok ama Ahmet diye bir string ifade vardır e her string değer sayısalla karşılanamaz ki o zaman sen gidip Ahmet'i int yapamazsın ki demek ki buradaki genellememiz Elimizdeki türe uygun dönüşüm yapılmalıdır. Elmayı armut olarak dönüştürmeyeceğiz.

- Amaç veriyi dönüştürmek değil amaç o veriyi karşılayabilecek farklı bir türe verebilmek.

- Amaç veriyi değiştirmek değildir!!! Amaç elimizdeki veriyi karşılayabilecek farklı bir türe dönüştürmektir.

- Amaç tür dönüştürmek değeri dönüştürmek değil 
    * Amaç `int`'i `short`'a dönüştürmek.
    * Amaç `int` içindeki 123'ü `bool` türdeki false ya da true'ya dönüştürmek değil Veriyi değil türü dönüştürmektir. 

- Zaten hiçbir zaman veriyi dönüştürmek gibi derdimiz olamaz eldeki veri ya işlenir ya da işlenmez. Dönüştürmek diye bir derdin olmaz veriyi. Türünü dönüştürürsün veriyi işlersin ondan bir sonuç üretirsin ama dur lan elimdeki veriyi başka birşey yapayım diye bir derdin olmaz.

- Zaten elindeki elmayı armut yapmak istiyorsan elmadan armut çıkaramayacağını bilmen lazım bir kodlama sürecinde. Armutu farklı algoritmayla üretmen gerektiğini de farketmen gerekiyor.

<img src="1.png" width="auto">