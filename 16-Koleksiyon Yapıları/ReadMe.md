***
# 356) Koleksiyonlar Nelerdir? Diziler Varken Neden Koleksiyon Yapıları İnşa Edilmiştir?
- Dizilerin daha gelişmiş yapılamasıdır.

- Dizilerle aynı amaca hizmet ederler. Dizilerdeki amaç birden fazla veriyi tek bir dizi içerisinde tutup yönetebilmek orada işleyebilmek. Koleksiyonda aynı işlemi yapar.

- Dizilerle koleksiyonların amacı aynı. Birden fazla veriyi yönetmek amma velakin dizilerde sınırlılıklarımız vardı işte bu sınırlılıklarımızı ortadan kaldırabilmek için koleksiyonlar üretilmiştir diyebiliriz. Dizilerdeki sınırlılıklar koleksiyonlarda yoktur.

- Koleksiyonlar bizzat OOP'nin bizlere kazandırdığı belirli yapılardır. Bunlar kendileri arka planda belirli algoritmalarla çalışırlar.

- Dizilerde tanımlama yaparken eleman sayısını bildirmek zorunluydu sen bir dizi tanımlayacaksın bir veri kümesi oluşturacaksın ama oluşturacağın veri kümesinin içinde kaç tane verinin olacağını önceden bilmek zorundaydın. Bu bir dibine kadar handikaptır.
    * Örneğin bir satış sitesi yaptığını düşünürsen eğer günlük ne kadar satış yapacağını önceden bilemeyeceğinden dolayı yapacağın bütün satışları karşılayacağın dizinin kaç elemanlı olacağını bilmen gerekiyor. Normalde benim bir sepetim olmalı içerisine veri attıkça bu sepetin kendisi büyümeli. 
    * Dizi diyor ki kardeşim kaç elemanlı bir dizi tanımlaman gerektiğini bana söylemen lazım. Ne fazlası olur ne eksiği olur.

1. Koleksiyonlarda dizilerdeki eleman sayısını bildirme zorunluluğu ortadan kaldırılmıştır.

- Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunur.
    * Sen gittin 1000 elemanlık bir dizi tanımladın ama elinde 3 tane veri var. RAM'inde 1000 elemanlık 1000 alanlık tahsis gerçekleştirildi 3 tanesini kullanıyorsan yapacak bişey yok. 
    * Dizilerde performans kaybı da söz konusu olabilmekte. Dizileri sen eğer doğru bir şekilde kullanıyorsan eğer inanılmaz çok hızlı bir şekilde çalışma yapabilirsin ama ne yazık ki çok iyi kullanma derdinde olmadığımızdan dolayı performans kaybına sebep oluyor maliyetli oluyor. Sen 3 tane veri için 1000 alan ayırıyorsun o 1000 alanlık yapılan tahsis 3 tane de kullansan 1000 tane de kullansan yine 1000 alanlık olarak gösteriliyor.

2. Koleksiyonlarda ne kadar veri eklersen o kadar alan tahsisinde bulunulacağından dolayı bu sınırlılıkta buradaki maliyette düşürülecek ve tercih edilecektir.

- Senin tanımlamış olduğun bir dizi 10 elemanlıysa eline 15 elemanlık veri geldi diyelim napacan 5 tanesini gözden çıkaracan. Ya da gidip kaynak kodunu değiştireceksin Runtime'da ilgili çalışmayı yapamayacağından dolayı derleme sürecinde kodunu yeniden derleyip o şekilde 15 tane veri alabilecek şekile getirmen lazım vs. Ya ona göre kod geliştirmen lazım. Ya da diziyi kullanıyorsan o şekilde bir sınırlılığa denk geleceksin. Koleksiyonlar diyor ki kardeşim benim sınırlılığım yok. Sen bir sepet düşün sepete veriyi ekledikçe bir tane veri ekledin artık bunun kapasitesi 1 olsun 2.yi mi ekledin 2 oldu 3.'yümü ekledin 3 oldu öyle düşünebilirsiniz. Normalde `ArrayList` koleksiyonu 2 katı olarak arttırır. İlk olarak 2 daha sonra 4 daha sonra 8 2^n olarak kapasiteyi arttırır. Veri ekledikçe kapasitesi artar bu yüzden daha az maliyetlidir.

- Koleksiyonlar dizilerdeki bu sınırlılıkları ortadan kaldırmak için geliştirilmiş yapılardır.

- Biz yazılımcıları asıl amacı dili öğrenmek dili kullanmak belirli verileri doğru bir şekilde işleyebilmek çıktılar verebilmek vs ama bunu yaparken elimizdeki kaynakları düşünmek zorundayız. Elimizdeki kaynaklar bir kere ne kadar az tüketiliyorsa o kadar fazla işlem yapma şansın var. Yaptığım işi ne kadar esnek ne kadar doğrucu ne kadar runtime'da yapabilir haldeyim. 

- Dizilerde Runtime'da 10 elemanlık diziyi 15'e çıkaramıyorsun ama koleksiyonlarda yapabiliyorsun bunu hani bunu da düşünmek lazım. Bu tarz faktörleri düşündüğümüzde koleksiyonların dizilere nazaran kodsal açıdan bize daha az iş çıkardığını söyleyebiliyoruz. 

- Esasında diziler koleksiyon yapılarına nazaran az maliyetlidir. Çünkü daha hızlı çalışırlar. Programlama dilinin dahilinde olduklarından dolayı. Ama koleksiyonlarda biz developerler açısından gelişim süreçlerine olan katkılarından dolayı oradaki maliyeti dengeliyorlar. Yani dizilere nazaran olan belki bir tık yavaşlık söz konusu olabilir ama belki bu yavaşlığı getirdikleri efektif çalışmayla amorti edebiliyorlar.

- Diziler hiçbir zaman çöp değildir her daim kullanacağız her daim ihtiyacımız olacak. Hızlı çalışmalarda ya da belirli operasyonlarda diziler olmazsa olmazımız. Başımızın tacı yani. Sen kod yazarken yeni birşey öğreniyorsan eskisini çöpe at diye bir mantık yoktur. Yeni birşey geliyorsa bişeyin yerine gelmiyor zaten o şey değiştirilir kaldırılır onunla ilgili bir yayın yapılır. Diziler vardır her daim olacaktır. Diziler yeri geldi mi kullanılacaktır. Ama koleksiyonlarda vardır.

- Yapısal olarak var olan birşeyi öğrenmek bir kere bir yazılımcının borcudur.

<img src="1.png" width="auto">

***
# 357) ArrayList Koleksiyonu
- Esasında bizim onlarca koleksiyonumuz var. Bu koleksiyonlar arasından ilkidir. 

- Dizilerdeki sınırlılıklardan kurtulmak için koleksiyonlar oluşturuyoruz ya bu ilk oluşturulan koleksiyon olarak düşünebilirsiniz. Haliyle kendine göre sınırlılıkları da olacak. Yani bir acemilik süreci olarak düşünebilirsiniz. Bu sınırlılıklardan dolayı başka koleksiyonlarında çıkışına sebep olacak bir koleksiyon hani evrimsel açıdan geçiş süreci olarak düşünebiliriz.

- `ArrayList` dediğimiz koleksiyon dizilerdeki sınırlılıkları tam olarak %100 kaldıran onları atan bir koleksiyondur. Verisel çalışmalarda kullanıyoruz. Yani diğer koleksiyonlardan ve dizilerden bu amaçla hiçbir farkı yok. Sadece koleksiyonların ilkidir diyebiliriz.

- Koleksiyonlara geçişlerde ilk ara geçiş örneği olarak ele alacağımız koleksiyondur.