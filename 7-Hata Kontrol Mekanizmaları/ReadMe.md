***
# 170) Hata Kontrol Mekanizmaları Nedir? Ne Amaçla Kullanılır?
- Artık bir yazılımın temel doğasında/fıtratında olan bir şeydir hata.

- Yazılım süreçlerinde en çok aldığımız ve esas olan birşey varsa o da hatadır.

- Şimdi sen geliştirdiğin yapılanmada ister istemez mükemmel muazzam bir strateji yapsan da beklenmeyen noktalarda kah gözünden kaçan noktalarda kahta yapmış olduğun hesaplamaların yanlışlığından dolayı yazılım sürecinde ister istemez birçok hatayla karşılaşacaksın. İşte bu hataları biz nasıl manipule edeceğimizi nasıl karşılayacağımızı hata kontrol mekanizmaları başlığı altında a'dan z'ye inceliyor olacağız.

- Bir yazılımcının hata dediğimiz kavram esasıdır. Yani günlük hayatta çok karşılaştığımız için artık bize yabancı değildir hata. En nihayetinde olayı şöyle düşünün ilk başta çok hata yapacaksınız ve yaptığınız hatalardan panik olmamanız lazım. Çünkü biz bunları daha nasıl yöneteceğimizi bilmiyoruz. Öğrendikten sonra farkettikten sonra hata türlerini gördükten sonra daha çok önümüz görülebilir hale gelecek daha çok böyle gözümüz açılacak diyecez ki ya arkadaş benim aldığım bu hatalar tamam bunlar çözülebilir şeyler. Hata dediğin şey zaten bu işin doğasında var.

- Biz günlük hayatta bir bardağa su doldururken bile yanlışlıkla gidip suyu yere masaya dökebilen insanlarız. Dolayısıyla ince hesap gerektiren bu tür yazılımsal durumlarda hata mı yapmayacağız? Bir mimari boyutta yazılım geliştireceksin ve hata yapmayacaksın? Bu gayet doğal hata yapacaksın önemli olan bu hatanın mahiyetini bilebilmek bunu yorumlayabilmek bunu değerlendirebilmek.

- 3 tür hatamız vardır;
    * Derleyici/Söz Dizimi Hataları
    * Runtime/Çalışma Zamanı Hataları
    * Mantıksal Hatalar

- Hatanın aslında bir yazılımcının yolundaki taş değilde ta işinin kendisinin olduğunu göreceğiz. Yazılımcı bir yerden sonra yapıları öğrenir. Bir yerden sonra bir amaca hizmet eden algoritmanın tasarısını koyar. Koduktan sonra yoldaki problemleri çözerek o yolu kazıyarak yolu inşa eder. Yani bir yerden sonra bizim işimiz hata çözmek oluyor. İster istemez işin bu oluyor. Ya mimaridleri öğreniyorsun vs. vs. Algoritmayı oluşturduğunda işin artık oradaki hataları temizlemek oluyor. Onun için bu konu bizim için çok önemli.

***
# 171) Hata Türleri - Derleme/Syntax/Sözdizimi Hatası
- Ferah ol... Hata bizim özümüzde var...

<img src="1.png" width = "auto">

- Programlama dili kurallarına aykırı olan hatalardır.
    * Örneğin Değişken tanımlama kurallarına uymadan değişken tanımlamaya çalışırsan kodunu derleyemezsin. Çünkü syntax hatası alacaksın.

- Özellikle gelişmiş editörler(VS) sayesinde söz dizimi hataları derlemeye gerek bile kalmaksızın fark edilebilmektedirler.

- Hatanın bulunduğu satır derleyici tarafından rapor edilir.

- O yüzden fark edilmesi ve çözülmesi ennnnn kolay hata türüdür.

- Yazılması gereken konseptte kodu inşa etmediğiniz sürece syntax hatası alacaksınız. Bu hata derleme sürecine hata verecek bir hatadır. Yani derleme esnasında ortaya çıkacak hatalardır. Compiler bakacak kodu derlerken hop kardeşim sen burada bu kurallara uymamışsın burada böyle bir kod yok burada böyle bir syntax yok diye seni uyaracaktır. Normalde bunu ilkel editörler kullanırken compiler seviyesinde öğrenebiliyoruz ama gelişmiş editörler sayesinde söz dizimi hataları uygulamayı/kodu derlemeye gerek kalmaksızın anında fark edilebiliyor ve direkt bizlere sunabiliyor.

- Gelişmiş editörler diyor ki Sen burada kodunu yazdın ben bunu derlemeye göndermem çünkü sen burada hata yaptın diyor.

- Gelişmiş editörler(Visual Studio, Intellij Idea) yapılan derleyici hatalarını/syntax hatalarını derlemeye göndermeye gerek kalmaksızın zaten direkt bizlere sunan bir editördür.

- Hatanın bulunduğu satır direkt derleyici/editör tarafından bizlere sunulmaktadır. Normalde derleyici compiler tarafında söyler. Şu satırda şu noktada bir hatan var diyecektir. Gelişmiş editörlerde direkt koda nokta atışı yapacak hatanın nerede olduğunu bizlere sunacaktır.

- Örneğin : Bir `class`ın scope'ları olmalıdır. Eğer ki scope'ları silersen sana hata verecektir.
    * Bir keywordü bambaşka şekilde yazarsan/bozarsan/semantiğe aykırı bir keyword yazarsan/var olan imzayı bozarsan/olması gereken yerde olması gereken şeyi bulundurmazsan/bir şeyi olmaması gereken yere koyarsan bu tarz yerlerde biz syntax hatası alırız.
    * C# büyük küçük harf duyarlılığına sahip bir dildir. Bu yüzden bir keywordü dikkat etmeden yazarsan söz dizimi hatası alırsın.
    * Değişken tanımlama kurallarında özel karakterler değişken isimlerinde belirtilemezdi. Eğer ki belirtirsen hata alırsın.

- Gelişmiş Editörlerin altını çizdiği hatalara biz derleyici/syntax/söz dizimi hataları diyoruz. Direkt altını çizdiği yer bizim hatamızda odaklanacağımız yer olacağı için fark edilmesi en kolay hatadır. Direkt ne yapacağını hani hatayı gördün tüh burada yanlışlıkla bunu buraya yazmışım ya da özel karakter kullanmışım diyebildiğin için çözümü de en kolay olan hata türüdür.

- Hataları bilebildiğimiz/görebildiğimiz/anlayabildiğimiz/farkına varabildiğimiz için çözülmesi ve fark edilmesi ennnnn kolay hata türüdür.

<img src="2.png" width = "auto">