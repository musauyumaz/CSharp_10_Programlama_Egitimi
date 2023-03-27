---
modified: 2023-03-27T06:49:50.475Z
title: 363) İterasyon Nedir?
---

***
# 363) İterasyon Nedir?
- Elimizde dizi ya da koleksiyon olduğunu varsayalım. Şimdi veri kümelerinin üzerinde çalışırken bizler genellikle döngüleri kullanırız. Döngüyle giriyorsun belirli bir kombinasyona göre elindeki veri kümesi üzerinde işlmeler yapıyorsun oradaki verileri tek tek yakalayıp ona göre işlemler yapıyorsun. Buradaki operasyonları daha efektif hale getiren iterasyonel mantıkta çalışan `foreach` yapılanması var.

- İterasyon dediğimiz kavram bir tek yazılımın terminolojisinde olan bir kavram değildir. Yani farklı disiplinlerde olan kullanılan bir kavramdır. Matematikte görülebilir dil biliminde kullanılır. Bilgisayar biliminde de kullanılır.

- Günlük hayatta itere etmek diye bir fiil vardır. Bu fiilin temeli iterasyona dayanıyor. İtere etmek bir sonrasını yani devamını getirmek yani sürekliliği sağlamak ta ki sonuna kadar anlamını çıkarabiliriz.

- Mantıksal açıdan her tahminin altında iterasyon mantığı yatar.

- 1 3 5 `7` Ben size belirli bir değer verdin vermiş olduğum değerden sonrasını sen getirebildin. İterasyon yaparak getirebildin. İtere ede ede devamını getirebiliyorsun. Ben sana ilk 3 tane sayıyı verdiğimde sen 4.'ünün 7 olduğunu nerden bildin sorusunun altında yatan cevap iterasyonel mantıktır. 1 geldi 3 geldi 5 geldi e sonrası 7'dir E devamını getiriyor itere ediyor sonuna kadar gitmek istiyor. 7'den sonra itere ettik 9 oldu itere ettik 11 oldu itere ettik 13 oldu öyle gider. Mantıksal açıdan tahminin seni burada iterasyon mantığının üzerine kuruludur.

- f(5) = 10
- f(10) = 20
- f(15) = 30
- f(20) = 40
    * 5 10'sa 10 20'yse 15 30'sa 20'de 40'tır. İtere ederek devam ettin  burada 40 kaçtır diye sorduğumuzda sen iterasyon mantığıyla sorunun cevabını verebilirsin.

- Dil biliminde iterasyon dediğimiz kavram çok ilginç noktada tanımlama yapar. Bir kelime eğer ki içerisinde tekrar eden hece barındırıyorsa bu iterasyonel kelime olarak geçer. Örneğin mermer, baba bunlar içerisinde tekrar eden kelimeler barındırdıkları için iterasyonel kelimeler olarak isimlendiriliyor. Hatta ve hatta adamlar demişler ki bir cümlenin içerisinde tekrar eden kelimeler varsa bu cümle de iterasyonel cümle oluyor diyor. Bu şekilde kullanılan bir terimdir iterasyon dediğimiz terim.

- Bilgisayar bilimlerinde ise şu noktada kullanılır. Bizim veri kaynaklarımız var bu veri kaynaklarımızı dizi ya da koleksiyon olarak düşünebilirsiniz. Yani birden fazla verinin tek bir sepette olduğunu düşünün işte bu ya dizidir ya koleksiyondur. İşte bunun gibi veri türlerinde birden fazla verinin temsil edildiği bu koleksiyonlar/dizi/veri kaynağı üzerinde işlem yaparken iterasyon mantığı kullanılabilmektedir.

- Sen bir veri kaynağını iterasyona verdiğin zaman tek tek buradaki değerler itere edilir. Ta ki hiç değer kalmayana kadar. Bak itere eder der ki veri var mı var. Alırsın veriyi iterasyonda her bir adımda bir tane veri gönderilir Her bir adımda o veri işlenir ondan sonra bir başka veri gönderilir ondan sonra bir başka veri gönderilir ta ki hiç veri kalmayana kadar. Buradaki iterasyon mantık şöyle soru soracaktır. Diyelim ki ben iterasyon mantığa göre çalışan bir yapıyım bir veri kümesi var diyelim bu veri kümesi üzerinde işlem yaparken elimi atıyorum diyelim ki bunun üzerinde bir sepet olsun içinde de elmalar olsun. Bakmadan diyorum ki elma var mı var o zaman gittim aldım 1 tane işlemimi yaptım daha sonra diyorum ki içinde elma var mı var gittim 1 tane daha elma aldım var mı var gittim aldım var mı var gittim aldım var mı yok tamam bitmiştir. Şu anda bütün değerleri itere etmiş olduk.

- Bilgisayar bilimlerinde elimizdeki veri kümeleri üzerinde işlem yapmamızı sağlayan bir mantıktır iterasyon mantığı. Elimizdeki verileri tek tek elde ederek bunların üzerinde işlem yapmamızı sağlayan bir yapılanmadır. Şimdi iterayonun can alıcı noktası şudur. Eğer ki Veri kümeleri üzerinde iterasyonel operasyonlar sağlıyorsak bu kümenin üzerindeki içerisindeki bütün değerleri tek tek elde etmek zorundayız. Haliyle %50'lik bir işlem mi yapacaksın iterasyonel mantık %lik işlemlere çok uygun değildir. Belirli bir kısmını alayım şunu yapayım ya da işte örneğin öğrenci nesnelerim vardır. Öğrenci değerlerim vardır ya da yaş değerlerim vardır. Belirli bir scala'nın altındaki değerleri toplamak istiyorumdur. Bunu yaparken biz iterasyon mantığını kullanıyorsak tüm değerler gelecektir bunun gelmesini engelleyemeyiz. Ama operasyonel anda gelen bu değeri belirli bir condition'a tutup bir şartla kıyaslayıp ona göre işlemimizi sağlayabiliriz.

- İterasyonel mantıkta çalışıyorsanız döngülerdeki gibi algoritmaya sürece hangi verinin çekileceğine hangi veri üzerinde çalışılacağına karar veremezsiniz. İterasyon illa ki her veriyi tek tek alacaktır aldıktan sonra sen işlem anında o veriyi tanıyıp işlem yapacak mısın yapmayacak mısın orada kararını vereceksin.

- İterasyon yapılanmasının itere eden ya da yazılımsal açıdan baktığınızda elinizdeki herhangi bir koleksiyonun içerisindeki bütün değerleri tek tek elde etmenizi sağlayan bir yapı olduğunu bilelim.

<img src="1.png" width="auto">