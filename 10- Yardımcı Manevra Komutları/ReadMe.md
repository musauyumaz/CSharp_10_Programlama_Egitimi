***
# 228) Algoritmada Manevra Yapmamızı Sağlayan Komutlarda Neyin Nesi
- Bir metodun içerisinde oluşturmuş olduğunu herhangi bir döngüde çalışıyorsunuz algoritmanızının akışı gayet güzel bir şekilde devam ediyor ama baktınız ki ihtiyaca binaen algoritma da örneğin orada ki döngüdeki kombinasyon sona ermeden senin döngüyü sonlandırman lazım. Ya da döngünün belirli turlarını es geçmen lazım. Ya da komple metodu sonlandırman lazım. Böyle durumlarda sürekli değişken tanımlama yaparak zıplama yapıyorum koşulu değişkenle takip ediyorum vs. İşte böyle durumlarda manevratik komutları kullanmalıyız.

- Manevratik komutlar sistemi/algoritmayı inşa ettiğiniz ve algoritama da normal gidişatta gidişata müdahale etmenizi sağlayan ve belirli manevralar yapmanızı sağlayan komutlardır. Örneğin kodu durdurmak istiyorsan mesela bir döngüdesindir ve döngüde belirli periyotları geçmek isteyebilirsin yani devamını okumamak isteyebilirsin. Döngüden komple çıkış yapmak isteyebilirsin yani kombinasyonun sonucunu beklemeksizin döngünün sonlanmasını isteyebilirsin. Yahut komple metodu sonlandırmak isteyebilirsin. Böyle durumlarda manevratik komutlardan inanılmaz derecede faydalanıyoruz.

- Kodu durdurmak, devamını okumamak, var olan bir döngüden çıkış yapmak, yahut komple metodu sonlandırmak yani kodu yönlendirmek için kullanılan komutlardır.

<img src = "1.png" width = "auto">

- `for (int i = 0; i < 100; i++){}` Şimdi bu döngü birgün sonlanacak i değişkeninin değeri 100'den büyük olduğu yada eşit olduğu zaman bu döngüden çıkılacaktır. Örneğin diyorum ki 23.adımda çık ya da hava bulutluysa çık Yani belirli bir şarta bağlayıp çıkarmak istiyorum. Bunu biz normalde manevratik komutları bilmeden de yapabiliyoruz. Biz şartımızı neye bağladıysak onun üzerinde içeride müdahale edip şartı değiştirdiğimizde şartı `false`a düşürdüğümüzde zaten ilgili döngüden çıkabiliyorduk. Ama bu kadar kompleks çalışmak zorunda mıyım? Örneğin `i == 22`yse çık demek için `i = 100` değerini mi atamalıyım? Evet bunu yapabilirsin ama döngüden çıkmak daha kolay olabilmeli döngüye manevra kazandırabilmek daha kolay olabilmeli. İşte böyle bir durumda döngüden çıkmak istiyorsan normalde `break` komutunu kullanacağım. Bunun dışında 0'dan 100'e kadar dönüyoruz ama `i == 22` durumuyla ilgili herhangi bir iş yapmak istemiyorum. Bu durumu es geçmek istiyorum yani `i == 22` durumunun olduğu algoritmayı çalıştırmak istemiyorum kod direkt `i == 23` durumuna geçsin istiyorum belirli bir condition yapacaksın. Mümkündür yapılabilir bir yöntemdir. Ama `continue` komutu sana daha çok yardımcı olacaktır. Daha hızlı daha efektif çözüm sunmanı sağlayacaktır. Ya da komple metodun sonlandırılmasını istiyorsun örneğin `i == 22` durumundayken komple metodun sonlandırılmasını istiyorsun bunun için gerekli operasyonu yaptın diyelim uzun uzun. Karman çorman bişey koydun ortaya halbuki `return` komutunu bilseydin eğer burada tek seferde komple bu metodun sonlandırabileceğini çok rahat anlardın ve çok rahat çözüm sunabilirdin.

- Manevratik komutlar aslında bizim yapamayacağımız şeyleri yapmamızı sağlayan komutlar değil yapabildiğimiz şeyleri daha efektif yapmamızı sağlayan yapılardır.

- Manevratik komutlar yapamayacağımız şeyleri yapmamızı sağlayan komutlar değildir! Yapabileceğimiz manevraları/kodun yönlendirmelerini daha efektif yapmamızı sağlarlar.

- 4 tane manevra komutumuz vardır;
    * `break`
    * `continue`
    * `return`
    * `goto`

```C#
#Yardımcı Manevratik Komutlar
for (int i = 0; i < 100; i++)
{
    if (i == 22)
    {
        i = 100;
    }
}
```