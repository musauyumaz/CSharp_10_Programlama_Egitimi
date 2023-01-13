***
# 72) Kod Nasıl Çalışır? Nasıl İşlenir?
- Kod konsepti kodun nasıl çalıştığı, satır satır kod mantığının olmadığı `;` operatörü ne amaca hizmet ediyor gibi ifadeleri açıklar.

- Kod iki türlü çalışır;
    * Senkron olarak çalışır.
        - Bir işlem bitmeden öbür işleme geçmez.
        - Bildiğiniz yoldaki trafiğin ta kendisidir. Öndeki araba gitmeden sen devam edemezsin. gidemezsin.
        - Herhangi bir T zamanda yapılan işi çok rahat bir şekilde hesap edebilirsin. 
        - Herhangi bir T zamanda yapılan iş bellidir.
        - Bir kodun işlemi bitmeden diğer kod çalışmaz
    * Asenkron olarak çalışır.
        - Senkronizasyon yoktur.
        - Aynı anda paralel bir şekilde işlemler yürür.
        - Herhangi bir T zamanda yapılan işi hesaplamak biraz zahmetli olacaktır. 
        - Bir işlem yapılırken diğer işlemi beklemek zorunda kalmıyorsun.
        

- Yazılım varsayılan olarak senkron çalışır.

- Yazılımda yazılan kodlar varsayılan senkron çalışırlar.

- İleri düzey programlama ile kodumuzu asenkron hale getirebilmekteyiz.

- Günümüzdeki çoğu yazılım haliyle asenkron çalışıyor.

- Asenkron ile Senkron arasındaki fark şudur. Düşünelim ki image processing işlemi yapıyoruz. Gözü algılayana kadar kod takılır. Senkron'da göz algılayacaksın gözü algılayana kadar bir algoritma çalışacak. Algoritma sona erene kadar program takılır orada kitler. Senkron olduğu için bir sonraki kod çalışmaz. Ama bu son kullanıcı deneyimi açısından pek fazla tercih edeceğimiz yöntem değildir. O yüzden asenkron yaparız. Gözü tarayan kod asenkron çalışırken paralel de ya da aynı anda asenkron bir şekilde farklı bir kodu da çalıştırırız o da orada bambaşka birşey yapar. sonucun devam ettiğini ona göre rapor verdiğini vs bişeylerden bahseder. En azından kullanıcıyı kitlemez. Kullanıcıyı bir şekilde oyalar.

- Siz bir yandan oyun oynarken bir yandan müzik dinleyebilirsiniz. Bir asenkronluk vardır. Düşünsene oyun oynarken oyun bitmeden müzik dinleyemiyorsun ne kadar saçma olur ne kadar kullanışsız olur. İşte biz yazılımlarımızı aslında asenkron geliştireceğiz.

- Bizim kodumuz senkron bir şekilde derlenir ve senkron bir şekilde çalışır.

<img src="1.png" width="auto">