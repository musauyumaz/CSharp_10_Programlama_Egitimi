# 1) C# Nedir?
- Microsoft tarafından .NET çatısı altında geliştirilen ve gelişen modern bir programlama dilidir.

- Açık kaynak ve ücretsizdir.

<img src="1.png" width="auto">

- C benzeri bir dildir.

- OOP'yi ve OOP'nin gelişimini destekler.

- OOP Neste Tabanlı Programlama felsefesidir/yaklaşımıdır. C# işte bu yaklaşımı benimsemiş bir dildir.

<img src="2.png" width="auto">

- Orta seviyeli bir dildir.

- Burada seviyeden kasıt dilin okunabilirlik etkisi. Yani bir dil yüksek seviyeli ise bir beşeri dile daha yakındır. Baktığınız zaman makale gibi okuyabilirsiniz. 

- Mesela VisualBasic'e baktığınız zaman yazılmış bir şiir gibi takır takır takır gider. Çok fazla bir sembolik değer/ifade yoktur.

- Bir makine diline baktığınızda bildiğiniz Çince gibidir. Yani hiç birşey anlaşılmıyor 0'lardan 1'lerden oluşuyor bir assembly'e baktığınız zaman ciddi manada bakınca hiç birşey anlayamacağınız bir mantık otutturamayacağınız bir dil. 

- Yani bir dil eğer ki beşeri seviye de algılanabilir seviyedeyse baktığınızda metinselse kodları bu dil yüksek seviyelidir. Ama bir dil okunabilirliği düşüyorsa sembollerle ifade ediliyorsa ve bir matematiğe/mantığa göre yorumlanabiliyorsa o dil düşük seviyelidir.

<img src="3.png" width="auto">

- C 'nin bir üst versiyonu C++'tır yani C+1 denilebilir çünkü ++ operatörü kodlamada değeri bir arttırır. C#'ta aslında C++'ın bir üst versiyonudur. Yani C++++ olarak tasarlanmış ve #(diyez) işareti olmuştur C#. 

<img src="4.png" width="auto">

- Java'dan etkilenmiştir. Java'yı etkilemektedir.

- Diller birbirlerini örnek alabilirler. Birbirlerinden belirli şeyleri kopyalayabilirler. Belirli şeyleri miras alabilirler ya da farklı bir vizyonda daha da farklı ürünler ortaya koyup daha düne kadar kendisinin modellediğinin modellenmesine sebeb olabilirler. Dillerin gelişimi bu şekildedir.

<img src="5.png" width="auto">

## C# İle Neler Geliştirilebilir
- Aklınıza ne geliyorsa geliştirebilirsiniz.

- Web Uygulamaları

- Mobil

- Web Service

- Service Mimarileri

- Console

- DLL

- Windows Form

- Oyun

- ERP, Muhasebe, Multi Media, İstatistik, Güvenlik vs. Yazılımları

- Uzaya füze göndersek bile C# ile gönderebiliriz. 

- Her yerde mükemmel bir destek verebilir demiyoruz. Örneğin veri madenciliği boşuna Python diye bir dil çıkmadı. Python veri madenciliğinde dah performanslı daha da hızlı hareket etmemizi sağlıyor. C#veri madenciliği yapamaz demiyoruz. C# veri madenciliği yapabilir.

- Siz her ne olursa olsun ihtiyacınıza göre doğru olanı kullanmanız sizin açınızdan son derece iyi olacaktır.

- Derlenen bir programlama dilidir.

<img src="6.png" width="auto">

***
# 2) .NET Framework ve .NET Core Nedir? Farkları Nelerdir?
- Biz Microsoft'un bize sunduğu teknolojileri kullanarak yazılımlarımızı geliştiriyoruz.

- .NET Dil/Mimari/Kütüphane gibi yapılanmaları sunan çatıdır.

- .NET Microsoft'un developerler için geliştirdiği teknolojileri sunuduğu bir çatı.

| .NET Framework | .NET Core| 
|----------------|----------|
|İlk Çıkan Sürümdür.|.NET Core daha sonradan çıkmıştır.|
|Windows Ekosistemine yönelik çözümler getirir.|Cross Platform'dur. Çeşitli işletim sistemleri uygulamaları destekler|
|Geliştirdiğiniz ürün sadece Windows'a göre çözümler getirir. Microsoft'a bağlıdır. |Developer'ların her yerde geliştirme yapabileceği/çalıştırabileceği/serve edebileceği  bir çekirdek oluşturdu.|
|Sadece Windows 'işletim sisteminde çalışabilirsiniz.|Tüm işletim sistemlerinde çalışma sergileyebilir.|
|Open Source değildir.|.Net Framework'teki Windows bağımlılığını ortadan kaldırarak daha evrensel uygulamalar geliştirmemizi sağlamaktadır.|
||Modülerdir. Open Source'tur.|


- İkisinde de farketmeksizin bütün platformlara uygun geliştirmeler yapabilmekteyiz.


<img src="7.png" width="auto">
<img src="8.png" width="auto">

***
# 3) Compiler Nedir?
- Yazdığınız kodu sürekli derleyip ardından çalıştırmanız gerekecek.

- Bir programlama dili derleyici bir üslupla çalışıyorsa yani derlenen bir dilse bu programlama dilinin önce derlenmesi ardından çalıştırılması ve sonuç alınması gerekmektedir. 

- Derleme süreci bizim için önemlidir.

- Diyelim ki siz Source(kaynak) dosyanızın içine C# kodlarınızı yazdınız. Bu kodların makina tarafından okunulabilir işlenilebilir hale getirilmesi gerekiyor. İşte biz bunun için bu kodu derlemeliyiz.

- Burada derlemekten kastımız yazdığımız kodun makinanın anlayacağı dile/koda çevrilmesi gerekiyor. 

- Örneğin C# kodlarının kabataslak Assembly'e çevrilmesi için bu kodun derlenmesi gerekiyor.

- C#'ı ben algılayabiliyorum derlendikten sonra C#'ın derlenmiş halini makine/bilgisayar algılayabiliyor.

- Dolayısıyla bu derleme neticesinde bilgisayarın anlayabileceği kod üretiliyor. Dolayısıyla biz C# ile Assembly yazmadan bilgisayarla haberleşmiş oluyoruz.

- Bilgisayar bilimlerinde ön işleme süreci, derleme süreci, çevirme ve bağlama süreçleri söz konusudur.

- Windows'ta Eğer ki bir yazılımı çalıştırmak istiyorsanız .exe uzantılı bir dosyasını açarak sağlarız. 

- .exe : Kullanıcın çalıştırabileceği yazılım uzantısıdır.

- Kullanıcının çalıştırabileceği yazılım uzantısını derleme sonucunda elde edersiniz.

- Yani senin yazmış olduğun C#'taki kodunu kullanıcının işletim sisteminde çalıştırılabilir hale getirmen için o kodu derlemen lazım.

- Derlemenin 2 adet çıktısı vardır. Bu çıktılardan bir tanesi .exe'dir diğeri .dll'dir.

<img src="9.png" width="auto">

***
# 4) Kodlar Nasıl Compile Edilir?
- Derleme süreci ileride kullanacağımız editörler tarafından kendiliğinden yapılacağı için buradaki sorumluluk bizim üstlenmemiz gereken bir sorumluluk değil. Haliyle burası çok önemli bir konu değil.

- Derleme esnasında esasında dosyanın uzantısı önemli değildir. İçerisindeki kodlar satır satır yorumlandığından dolayı dosyanın uzantısından ziyade içerisinde ki yazan kodlar önemlidir.

- Developer Command Prompt sayesinde elimizdeki dosyaları derleyebiliyoruz. Tabiki o dosyaların içerisinde .NET türevlerinden bir dil kullanılmış olması kaydıyla.

- Bir kodu inşa ediyorsunuz ve bu inşa ettiğiniz kod derlenmediği sürece kullanılabilir hale gelmemektedir. Onun için kodu bizim derleyip daha sonra çalıştırmamız gerekiyor. Dolayısıyla buradaki süreçten kodun geçmesi gerekiyor. Buradaki süreç manuel bir şekilde geçmeyecektir. Bunu kullanacağımız editörler ya da .NET CLI dediğimiz asistan sayesinde çok rahat bir şekilde gerçekleştirebiliriz.

<img src="10.png" width="auto">
<img src="11.png" width="auto">

***
# 5) Visual Studio Ortam Tanıtımı
- Biz kodlarımızı yazarken bilgisayar ortamında en nihayetinde not defterini kullanabiliriz. Kodumuzu orada yazıp çalıştırıp inşa edip manuel derlemelerle sonuçlarımızı alıp test edebiliriz. Bu işlem basit işlemler de bir yere kadar idare edecektir ama kompleks çalışmalarda gerçekten kurumsal yapılanmalarda artık ihtiyacımız biraz da kod maliyetini düşürecek bir asistana ihtiyacımız olacaktır.

- İşte böyle durumlarda geliştirilmiş kod yazmamızı yani bir developer sürecinde bizlere eşlik edebilecek belirli ortamlar kullanmamız gerekecektir. Bu ortamlardan en yaygın olanı Visual Studio'yu kullanacağız.

- Visual Studio Microsoft tarafından geliştirilmiştir. .NET mimarilerinin hemen hemen hepsini en mükemmel şekilde kodlayabileceğimiz bir platformdur.

- [Buradan Visual Studio'ya erişim sağlayabilirsiniz](https://visualstudio.microsoft.com/tr/)

- Visual Studio dediğimiz editör Microsoft tarafından biz developerlar için geliştirilmiş harika muazzam bir editördür/ortamdır. 

- Aklınıza gelen bütün çalışmaları biz buradan yapabiliyoruz. Mimarilerinizi, kodunuzu, uygulamanızı, programınızı, tasarımınızı, herşeyinizi bunda yapabiliyorsunuz ve bunun üzerinden tek seferde derleme işlemini gerçekleştirebiliyorsunuz. 

- Derleme sürecini Visual Studio kendi sorumluluğunda/kendine dahili bir şekilde bu sorumluluğu üstlenmiştir. 

 - Yukarıdaki menülerden önemli olarak : 
    * Debug, 
    * Tools, 
    * Solution Explorer : Yazdığımız/çalıştırdığımız/ üzerinde çalıştığımız projeye dair tüm dosyalar buradaki pencere de listelenecektir. Tek elden yönetebiliyoruz.
    * Error List :Derleme sürecinde yaşanan alınan hataları görebilirsiniz.


<img src="12.png" width="auto">

***
# 6) Proje ve Solution Kavramları
- Uygulama oluştururken temelde 2 kavram vardır.

- Proje : İçerisinde amaca dair çözümler getirilen kodsal çalışmaların yapıldığı(yani operasyonların yürütüldüğü) bir bütündür. Gerekli algoritmalarını yazıyorsun/mimarilerini oluşturuyorsun/veritabanı işlemlerini yapıyorsun vs.

- Solution : İçerisinde bir veya birden fazla proje barındıran evrensel bir kümedir.

- Gerçek hayatta bir uygulama yazarken yazdığınız uygulama bir proje değil esasında bir çözümdür/solution'dır. Dolayısıyla bu solution yani yapacağınız uygulama birden fazla projenin bir araya gelmiş hali olabilir.

- Mesela bir banka uygulamasında ekibin bir kısmı Bakiye projesinde çalışırken bir kısmı bankamatik projesinde çalışıyor olabilir başka bir kısmı ERP projesi vardır orada çalışıyordur Her proje birbirinden farklı ama kendi aralarında bir entegrasyon var. İşte biz bunların her birini bir Solution altında toplayabiliyoruz.

<img src="13.png" width="auto">

# 7) Visual Studio İle Proje Oluşturma ve Derleme
1. İlk olarak hangi proje de çalışacağımızı seçeriz. Hangi platform'da çalıştığınız önemli değil.

2. Sonra açılan ekranda proje ismi ve Solution ismi belirlenir. Ve aynı zaman da yapılan Solution'ın/kaynak dosyalarının hangi lokasyon'da/nerede depolanması gerektiği belirtilir.
    * Diyelim ki bir banka uygulaması; Banka uygulamasında solution Banka olur Projeler de Bankamatik, Bakiye, ERP bunların hepsini Banka Solution'ı daha evrensel bir isim altında toplamış olursunuz. 
    * Bir Solution altında birden fazla aynı isimde proje bulunamaz.

- Hangi platform da çalıştığımız önemli olmaksızın her daim Solution Explorer penceresinde ilgili projenin dosyalarını görebilirsiniz.

- Bir solution'a birden fazla proje eklemek için solution oluşturulduktan sonra Solution üzerinde sağ click yaparak Add->New Project diyerek projeler ekleyebilirsiniz

- Proje derlemeyi ister Proje bazlı isterseniz de Solution bazlı yapabilirsiniz. Solution'da derleme yaparsanız altındaki bütün projeler derlenir. Eğer ki proje bazlı yaparsanız sadece o proje derlenir. 

- İlgili projeye sağ click yaptığınızda;
    * Build : Derlemeyi yapar.
    * Rebuild : Önceden derlenip çıktı alınan dosyaları siler yeniden üzerine derleme yapar.
    * Clean : Derlenmiş dosyaları siler.

- Proje üzerinde sağ click Open Folder in File Explorer dediğimizde projenin kaynak dosyalarına erişebiliriz.

- Hangi proje seçiliyse başlat düğmesine tıklayarak ilgili projenin derlenip arkada üretilen exe dosyası çalıştırılacaktır.

- Proje üzerinde sağ click Set As Startup Project dersek eğer ilgili/seçilen proje o Solution'da başlangıç projesi olacaktır.

<img src="14.png" width="auto">
<img src="15.png" width="auto">
<img src="16.png" width="auto">
<img src="17.png" width="auto">
<img src="18.png" width="auto">
<img src="19.png" width="auto">

***
# 8) Visual Studio Code Ortam Tanıtımı
- Visual Studio Code çok hızlıdır.

- Microsoft tarafından UI teknolojileri için geliştirilen bir editör olduğundan dolayı hızlı kod yazmamızı/geliştirmemizi sağlıyor.

- Backend'de geliştirebilirsiniz.

- dotnet CLI dediğimiz asistana Terminal(komut satırı) üzerinden çok rahat bir şekilde komutlar verebiliyoruz.

- debugging yapabiliyorsunuz.

- Build işlemini CLI dediğimiz kod üzerinden gerçekleştiririz.

<img src="20.png" width="auto">

***
# 9) Visual Studio Code İle Proje Oluşturma ve Derleme
- Visual Studio Code, Visual Studio gibi direkt efektif komponentler barındırmamaktadır. Bu yüzden hali hazırda proje oluşturacak bir menü taşımamaktadır.

- Proje oluşturmak için dotnet cli komutlarından yararlanırız. 

- Dotnet CLI bizim komut satırı arayüzümüz aynı zamanda asistanımız da diyebiliriz. Bu asistanın bir arayüzü yok. Bu asistana cmd'den/powershell'den/Console'dan yani bir komut satırından talimat vermemiz gerekiyor.

- Bu talimatı verebilmek için Visual Studio Code'dan Terminal penceresini açarız.

- Öncelikle dikkat edilmesi gereken şu; Talimatı verdiğiniz dizin çok önemlidir. Çünkü projeyi o dizine oluşturacaktır.

- İlgili dizini seçtikten sonra ilgili dizinde dotnet cli komutlarını çağırırız.

- dotnet => Dotnet CLI'i çağırır. Bundan sonrasında talimat verebiliriz.

- dotnet'te ne yapacağınızı bilmezseniz direkt enter tuşuna basabilirsiniz o sizi bilgilendirir.

- dotnet --info => Dotnet CLI ile ilgili bilgi verir.

- dotnet --help => Dotnet CLI ile yapacaklarınızı görebilirsiniz.

- dotnet new => dediğimiz zaman bir proje oluştur demiş oluyoruz.

- dotnet new projectType --name projectName => Şu formata uyduğunuz sürece ilgili type'da(Console/MVC/WebApi) ve --name parametresinden sonra verdiğiniz isimde bir proje oluşturulacaktır.

- dotnet build => bulunduğunuz dizindeki projeyi build edecektir.

- dotnet run => bu dizindeki projeyi hem derleyecek hem de run edecektir/çalıştıracaktır.

<img src="21.png" width="auto">
<img src="22.png" width="auto">
<img src="23.png" width="auto">
<img src="24.png" width="auto">

***
# 10) Dotnet CLI Nedir?
- Command Line Interface(Komut Satırı Arayüzü)

- .NET uygulamalarını geliştirirken bize eşlik eden bir komut satırı arayüzüdür.

- Programlama yaparken yazmış olduğumuz koda eşlik edecek bir asistanımızın olması lazım. Örneğin ben proje oluşturucaksam bu projeyi bir zahmet bu asistanın oluşturması gerekiyor. Benzer mantıkla kodumu yazdım en son güncellemem gerekiyor bu güncelleme işlemini manuel bir şekilde yapıp kendim sonucunu test ediyorsam bu büyük bir zamansal maliyet haliyle bunu yapacak başka bir asistana daha ihtiyacım oluyor. Bu işlemleri dotnet CLI ile de yapabiliriz.
 
- Herhangi dosyayı/projeyi oluştururken artık görsel bir grafik arayüz üzerinden işlem yapmıyorum. Çünkü iki satır kod ile ha deyince sana istediğin yapılanmayı oluşturabiliyor ve bu iki satır kopdu yazabileceğin yer herhangi bir görsellik gerektiren bir yer değil. o yüzden günümüzde CLI denilen yapılanmalar kullanıyoruz. Bu yazılımların arayüzü yoktur. Direkt konsoldan talimat alırlar.

- .NET uygulamaları geliştirmeyi, oluşturmayı, çalıştırmayı ve yayınlamayı sağlar.

- .NET SDK ile birlikte gelir.
    * SDK dediğimiz geliştirme kitimizdir. C# kodlarını yazmak çalıştırmak için SDK'ya ihtiyacımız var.

- Prototip => Dotnet [command]

<img src="25.png" width="auto">

***
# 11) Dotnet CLI - Temel Komutlar - Help Komutu
- Bir program yazarken genellikle kullanacağımız .NET CLI komutlarımız bunlardır. Temel komutlar olarak geçerler.

- help

- new

- restore

- build

- publish

- run

## Help
- Dotnet CLI tarafından desteklenen komutlar hakkında ayrıntılı bilgi veren komuttur.

- dotnet help

- konsept olarak dotnet help yazdığınız zaman size neyi hangi konseptle çağırmanız gerektiğini ne şekilde kullanabileceğinizi bildiren bir komuttur.


<img src="26.png" width="auto">
<img src="27.png" width="auto">

***
# 12) Dotnet CLI - Temel Komutlar - New Komutu
- dotnet CLI üzerinden proje oluşturmak istiyorsak new komutunu kullanabiliriz.

- Prototip olarak dotnet new dedikten sonra .net'e bir proje oluşturacağınızı bildiriyorsunuz. Ardından projenin türünü bildirip name parametresi eşliğinde projenin ismini belirtmeniz yeterli olacaktır. Bu işlemden sonra ilgili proje hangi dizinde enter tuşuna bastıysanız oraya oluşturulacaktır.

- dotnet new [project type] --name [project name]

- dotnet new komutunu yazdığınızda bu dotnet new  komutu ile hangi türleri oluşturabiliyorum bana onun bir yardımcısı ol söyle bakalım.

<img src="28.png" width="auto">
<img src="29.png" width="auto">


## NEW FORCE PARAMETRESİ
- dotnet new [project type] --name [project name] --force

- Eğer ki ilgili dizinde bir proje oluşturacaksanız ve oluşturacağınız projenin ismi önceki projelerle çakışıyorsa force ile siz bunu zorunlu hale getirebilirsiniz yani zorlayabilirsiniz.

- Eğer ki force paramteresiyle zorlarsan bir önceki projeyi ezecek ve yeniden oluşturacaktır.

<img src="30.png" width="auto">

***
# 13) Dotnet CLI - Temel Komutlar - Restore Komutu
- Proje sürecinde referans edilen yahut referansı kaldırılan paketlerin restarasyonunu sağlar.

- Bir yazılımın gelişim sürecinde o yazılımla ilgili işlemleri/iş mantıklarını genellikle kah kendimiz tarafından kah başkaları tarafından önceden yazılmış kütüphanelerin desteğini alarak çözmeye biz referans mantığı diyoruz.

- Örneğin bir resim geliyor ve resimdeki yüzü almamız gerekiyor. Bu yüzü algılama algoritmasını siz önceden yazdıysanız bunu bir kütüphane olarak tutuyorsunuz ve bir daha ilgili proje de lazım olduğunda tekrardan aynı kodları yazmaksızın bu kütüphaneyi çağırıp buranın kodlarından istifade edebiliyorsunuz. İşte biz buna referans mantığı diyoruz. 

- Tabi ilgili kütüphane/kayda alınmış kütüphane/önceden oluşturulmuş kütüphane illa sizin oluşturmuş olmanıza gerek yok bunu başkaları ya da bir community tarafından oluşturulmuş kütüphane de olabilir önemli değil. Önceden oluşturulmuş mu oluşturulmuş. Önceden var olan yazılmış hali hazırdaki paketleri/kütüphaneleri kendi uygulamamızda kullanabilmek için bizim bunları uygulama da çekmemiz lazım. 

- Siz diyelim ki paketleri bir şekide referans ettiniz ve yükleyeceğinizi bildirdiniz. Bildirdiğiniz/referans ettiğiniz bu paketleri uygulamaya yükleyebilmek için uygulamayı Restore etmeniz lazım.

- Restore işleminde olmayıpta kendine referans edilmiş paketleri kendisi nuget dediğimiz bir havuzdan çeker.

- Harici paketleri sisteme yüklememizi sağlayan yapılanma Restore yapılanmasıdır.

<img src="31.png" width="auto">

***
# 14) Dotnet CLI - Temel Komutlar - Build Komutu
- Projeyi derler ve sonuç olarak .exe ve .dll çıktıları verir.

- Derlemeden önce projeyi Restore eder.

- \bin\Debug\net5.0 dizinine çıktı verir.

- Yani bir projeyi derleyebilmek için öncelikle onun var olan bütün kütüphanelerinin/referanslarının/bağımlılıklarının elden geçirilmiş olması lazım. Eğer ki güvenliyse/okey'se artık bunu compile/build etmesi gerekecektir.

<img src="32.png" width="auto">

***
# 15) Dotnet CLI - Temel Komutlar - Publish Komutu
- Projeyi derleyerek yayınlanabilir dosyaları çıktı olarak verir.

- Çıktı olarak;
    * .dll
    * .deps.json(projenin tüm bağımlılıklarını içerir)
    * .runtimeconfig.json(runtime konfigürasyonları)
    * Uygulama bağımlılıklarının dll'leri

- \bin\Debug\net5.0\publish dizinine çıktı verir.

- Herhangi bir proje kaynak kodlarıyla birlikte inşa edilip piyasaya sunulmadan önce bu projenin kaynak kodlarını biz gizlemek isteriz. Bazen algoritmayı piyasaya sunmak istemeyiz. Dolayısıyla böyle bir durumda projeyi yayınlanabilir yani piyasaya sunulabilir hale getirmemiz lazım eğer ki bu proje bir web uygulaması ise bu projeyi hosting'e atabilir yayınlayabilir hale getirmemiz gerekmektedir. Haliyle kaynak kodları/dosyaları bizde olacak şekilde biz bunların çıktılarını alıp yayınlayabilmeliyiz. İşte bunu yapmamızı sağlayan Publish komutudur.

- Publish işlemi için dotnet publish yazmanız yeterlidir.

- Projeyi ilk baş derler. Daha sonra yayınlanacak çıktılarını alır.

- Bir uygulama başka bir uygulamayı kullanıyorsa, başka bir kütüphaneyi ya da paketi kullanıyorsa ona bağımlıdır. Orada bir bağımlılık söz konusudur. Dolayısıyla Publish işlemi bu bağımlılıkları referanslayan bir dosya verecektir.

<img src="33.png" width="auto">

***
# 16) Dotnet CLI - Temel Komutlar - Run Komutu
- Uygulamayı derler, ayağa kaldırır ve çalıştırır.

- dotnet run dediğinizde ilgili dizindeki projeyi derleyecek ve ardından da çalıştıracaktır.

- dotnet run --no-build => Uygulamayı derlemeden direkt ayağa kaldırır. Mevcut en son derlenmiş hali neyse uygulamayı onun üzerinden ayağa kaldıracaktır.

<img src="34.png" width="auto">
<img src="35.png" width="auto">

***
# 17) Dotnet CLI - Paket ile Referans Arasındaki Fark Nedir?
- Proje seviyesinde işlemler yapmamızı sağlayan projeyle ilgili kütüphane ekleme/çıkarma referans ekleme/çıkarma işlemlerini yapmamızı sağlayan proje modifikasyon komutlarıdır.

- Paket/Kütüphane bunlar nuget dediğimiz bir havuzdan gelir.

- Referanslar ise önceden yazılmış .dll'lerdir. Yani fiziksel olarak elimizde bulunan .dll dosyalarıdır.

- Siz bir projeyi oluşturdunuz ve oluşturduğunuz projeyi build ettiğinizde o gelen .dll dosyası esasında şu anlama gelir : Bu .dll dosyası bir yazılım tarafından kullanılabilir bir dosya.

- Eğer ki siz yazdığınız bir kodu son kullanıcıya/insana kullandırtacaksanız çıktısı .exe'dir. Eğer ki senin yazılımını bir başka yazılım kullanacaksa onun da çıktısı .dll'dir. Yazılımın kullanacağı yazılımı .dll olarak gönderir.

- .dll dosyalarına referans ama nuget dediğimiz bir havuzdaki farklı kütüphanelere(uzaktan,internetten çektiklerimiz) ise paket diyoruz. Tabi bir yandan referans olanlar da bizim için bir paket mahiyetinde olabilirler ama genel anlamda teknik olarak bu ikisi bu şekilde ayrılmaktadır. 

- Bir fiziksel elinde dosya var ve uzantısı .dll ise bunu projene eklerken referans olarak eklersin yok eğer sen nuget dediğimiz havuzdan bir kütüphaneyi uygulamana çekeceksen eğer onu da paket olarak çekersin 

<img src="36.png" width="auto">

***
# 18) Dotnet CLI - Proje Modifikasyon Komutları - add package Komutu
- Uygulamaya Nuget'ten paket/kütüphane yüklememizi sağlar.

- Nuget havuzundan bir paketi uygulamaya yüklemeye biz paket yöntemi diyoruz.

- Kah sen Nuget'ten yüklemişsin kah .dll olarak eklemişsin her ikisi de kütüphanedir ama biz Nuget'ten gelene paket diyoruz.

- dotnet add package [package name] => o dizindeki projeye bu kütüphane yüklenmiş olacaktır.

<img src="37.png" width="auto">

***
# 19) Dotnet CLI - Proje Modifikasyon Komutları - add reference Komutu
- Uygulamaya fiziksel bir dll dosyasını referans etmemizi sağlar

- dotnet add [source project].csproj reference [target project].csproj

- Bir solution altından birden fazla proje kullanabiliriz. Diyelim ki uygulamamızda çok fazla proje var ve projeler birbirlerini referans etmek zorundalar. Örneğin veritabanı işlemlerinin sorumluluğunu sen bir projeye verirsin iş mantığını/algoritmaları başka bir projeye verirsin. Haliyle algoritmaların/stratejilerin/tüm mevzuların döndüğü bu proje de veritabanı işlemlerini yapmadan direkt elindeki veritabanı projesini kullanarak operasyonlarını gerçekleştirirsin. Burada ki veritabanı desteğini diğer proje verir. İşte bu desteği verebilmesi için bu proje de/iş mantığı projesinde veritabanı projesinin kullanılabilir olması yani referans edilebilir olması gerekir. İşte bu durumda Add Reference'ı kullanırız.

- dotnet add myproject.csproj reference ../ornekproje/ornekproje.csproj => myproject'te ornekproject'teki dll'i referans olarak alıyorum yani ornek projeyi sen myproject'te referans al onu kullan onun sen burada dll'ini çıktısını sen burada kullan demiş oluyoruz. Haliyle myproject ornekproject'teki tüm erişim belirleyicisi izin veren class'lara erişim sağlayıp kullanabilecek.

<img src="38.png" width="auto">

***
# 20) Dotnet CLI - Proje Modifikasyon Komutları - remove package Komutu
- Uygulamaya yüklenmiş olan paketlerin/kütüphanelerin silinmesini sağlar.

- dotnet remove package [package name]

<img src="39.png" width="auto">

***
# 21) Dotnet CLI - Proje Modifikasyon Komutları - remove reference Komutu
- Uygulamaya referans edilmiş dll'leri kaldırır.

- dotnet remove reference [reference name]

<img src="40.png" width="auto">

***
# 22) Dotnet CLI - Proje Modifikasyon Komutları - List Reference Komutu
- Bir uygulamadaki kullanılan tüm referansları gösteren komuttur. 

- Uygulama da referans edilen tüm komutları listeler.

- dotnet list reference

<img src="41.png" width="auto">

***
# 23) Programlamaya Başlarken Temel İlkeler
- Bir dil öğreneceğiz Bu dil beşeri bir dil olmayabilir ama makinalarla ve bilgisayarlarla iletişim kurmamızı sağlayacak bir dil öğreneceksiniz.

- Nihayetinde herhangi bir beşeri dilin nasıl bir öznesi yüklemi varsa kendine göre bir edebi anlayışı varsa bu da bir programlama dili ama bir dil olduğu için kendine has yapılanmaları, kültürü, geleneği, prensipleri, fesehatı, belegatı(ileride düzgün kod yazma sanatları diyeceğiz. Design patternlar var) var.

- Öğreneceğimiz bir dildir. Her ne kadar programlama dili olsa da bir iletişim kurmamızı sağlayan bu dile hakim olursak bilgisayara ya da makinelere istediğimiz her türlü derdimizi anlatıp işlem yaptıracağımız bir dildir.

- Her programlama dili başlangıçta bir gelenek ve kabulle yola çıkar. Biz bunlara prensipler diyoruz. Belirli prensipler/kabuller ışığında/çizgisinde/hizasında hareket ederseniz o dili öğrenmeniz o dil üzerinde hakikaten edebiyat yapmanız çok kolaylaşacaktır.

- Programlada temel ilkelerimiz vardır. Bu ilkeler olmazsa olmaz. 

- İlke sosyolojik açıdan yaparsanız doğrudur ama yapmazsanız yanlış demek değildir/sıkıntı yoktur.

- İlkeler genellikle değişmezler. Çünkü evrensel doğrulardır/Kabuldürler. Gelenekesel bir anlayışın üzerine oturmuş doğrular değildir. Bunlar genel/evrensel doğrulardır. Ne zaman yaparsan yap, ne zaman uygularsan uygula her daim bir doğruluk ve sana doğru bir yönlendirme rehberlik sağlayacaktır. 

- Dolayısıyla biz kod inşa edeceğiz, kodsal düşüneceğiz, kodların mantığında bir program zihniyetinde/bir yazılımcı zihniyetinde olayları yorumlayacağız bunları yaparken de prensipler çerçevesinde yaparsak hem düşünce sanatımız o prensipler çerçevesinde doğru olacak ,doğru şekilde gelişecek hem de yazdığımız koda buradaki doğruluk yansıyacaktır.

- Bu prensiplerin hepsi altın değerinde yılların yazılımcıların geçtiği yollarda ayaklarına takılan taşları eleyerek ortaya koydukları kolonlardır. Bu kolonları sizlerde yolunuza ihtiyaç olmadan koyarsanız her daim sağlam bir çatının altında hareket etmiş olacaksınız. Onun için prensipler/ilkeler her işte olduğu gibi çok ama çok önemlidir.

- Temiz kod yazma sanatında bizim için prensipler olmazsa olmazdır. Prensipsiz temiz kod yazamazsınız.

- Bir programcı ilkeli birisi olmalıdır.

***
# 24) Programlamaya Başlarken Temel İlkeler - Don't Repeat Yourself
- Bir programcı kendisini tekrar etmez.

- Önceden yazmış olduğun bir kodu sürekli başka başka yerlerde yazmamalısın.

- Bir programcı komutları sürekli tekrar etmektense öğrendiği yapılarla bunu daha analitik çözüm haline getirip tekrarlı değilde tek seferli hale getirebilmelidir.

- Bir kod inşa edilirken mümkün mertebe elinizdeki bildiklerinizle ve o dilin desteklediği bütün her şeyi bildiğinizi varsayalım. Çözüm getidiğiniz şeylerde kodunuzda tekrar varsa eğer bu koddaki tekrarı ortadan kaldırın. Tek elden yönetmek için çabalayın. Çünkü her yerde aynı algoritma çalışacaktır. Aynı algoritmayı bir gün değiştirmen gerekirse her tekrar eden noktada değiştirmen gerekecek buda büyük bir sıkıntı. Onun için tek bir yerde bu algoritmayı yazıp o yazdığını her yerde kullanacak şekilde bir tasarıma geçebilmen lazım. Değişiklik olduğu zaman bir noktayı değiştirirsin onu kullanan her yere o değişiklik yansıyacaktır. İşte doğru tasarım budur.

- Satrançta bir taktiği yakalarsın sen ondan sonra durmadan o taktiği uygulayarak başlarsın bu kendini tekrar etmektir. Yani belirli senaryolarda belirli stratejileri uygulamak ileride buna design pattern diyeceğiz ama belirli algoritmalarda sürekli önceden yazdığın algoritmayı tekrar ederek olayı canlandırmak bir yerden sonra sizin yaratıcılık zekanızı öldürecektir. Yani bırakın ezberlemeyin. Algoritma ezberlemesi tekrarı yapmayın o anda çözüm getirmeye çalışın mümkün mertebe bırakın maliyetini kodun performanslı çalışmasını vs. Sizin için o andaki önemli olan şey o problemi çözmektir. Önceden çözdüğün tecrübeden destek almak ayrı bişeydir. Bir algoritmayı ezberleyip aynısını her yerde uygulamak ayrı bişeydir. Bu öldürücü bir tekniktir. Tecrübelerden faydalanmak yaratıcılığı destekler. Siz tecrübelerinizi faydalınabilir hale getirin. Ama algoritmaları ezberleyip belirli yerlere not alıp durmadan aynı algoritmayı benzer noktalarda kullanmak doğru bir gelişimsel süreç sağlamayacaktır.

- Örneğin tüm personellerin maaşına %10 zam yapan algoritmayı geliştirdin ya bunu bir daha aklında tutma Birgün bir daha buna ihtiyacın olursa onu tekrar edeceğine o anda bir daha ona çözüm üret. Bunu bir yerden sonra alışkanlık haline getirdiğinizde inanın ki aklınızda bilgi/kuramlar olacak ezbere algoritmalar olmayacak.

- Kendimizi hem kod açısından hem de yaşadıklarımızı ezberleme açısından tekrar etmiyoruz. her daim kodlarımızı sade tekil yani çağrılan bir kodu bir kere yazacağız ondan sonra çağıracağız. Aynı kod aynı blokta tekrar tekrar yazılmamış olmasına özen göstereceğiz. 

- Şöyle bir bakacağız burada bir tekrar var ben bunu daha analitik nasıl düşünebilirim diye korkma düşün. Hani demiş ya şair Sar ruhunu geceler diye sen de sar zihnini düşüncelere çıkama işin içinden kodu boz. Ama bir düşün bir tefekkürünü et ulan ben bunu nasıl yaparım demeyi bil birazcık ilgilen yazdığın kodla ilgilen. Yaptığın işi artık işin olarak benimse. Yazdığın kod bir muhasebecinin yazdığı kodla aynı olmamalı, bir kasabın yazacağı kodla aynı olmamalı onu herkes yazabilir. Sen bu işi yapan bir adam olarak fark yaratmalısın. Tabikide ilk başta olmayacak ama zamanla niyetin prensibin bu olacak. Bu ilkeler ışığında olacaksın gördüğün anda onu düzeltecek onu takıntı haline getireceksin gece uykunu bununla kaçıracaksın ya ben bu kodu adam haline getireceğim diyeceksin. İleride biz buna refactoring diyeceğiz. Yeniden düzenleme kodu yeniden adam haline getirme. 

- Sen bunu başta bir prensip olarak kabul edeceksin. Kendini tekrar etmeyeceksin. Aklında ezbere algoritma olmayacak. Tecrübelerin olacak onlarla iç güdüsel çözümler getirip düşünsel anlık olarak çözümler getireceksin. Ezbere stratejiler var design patternlar burada onu kastetmiyoruz. Yani sen algoritma ezberlemeyle design patternları karıştırma.

- Özetle 
    * Kendimizi tekrar etmiyoruz.
    * Algoritmaları ezberleyip tekrar etmiyoruz.
    * Anlık çözüm getiriyoruz. Benzer olabilirler tecrübelerimizden faydalanıyoruz.
    * Yapıları öğrendiklerimizi kullanıp daha da gelişmiş/efektif/sistematik bir kod inşa etmeye odaklı hale getiriyoruz. En azından bunu başta bir prensip olarak kabul ediyoruz.


<img src="42.png" width="auto">
<img src="43.png" width="auto">
<img src="44.png" width="auto">

***
# 25) Programlamaya Başlarken Temel İlkeler - Anlamlı İsimlendirme
- Yazılıma başlarken kabul etmemiz gereken bir diğer husus ise anlamlı isimlendirmedir.

- Bir isimlendirme yaparken sen anlamlı değilde gidip saçma sapan bir isim verirsen bu kodun gelişiminde ciddi manada maliyete sebep oluyor ve bunu günlük hayatta çok rahat görebiliyoruz.

- Lisedeki matematikte x, y değişkenlerini kullanmayı programlamaya matematiğin o geleneğini taşımayacağız. Mantığını taşıyacağız onu bırakacağız. Yazılımda ne kullanıyorsan anlamlı bir isim vereceksin.

- Kullanacağımız yapı neye hizmet ediyorsa o şekilde anlamlı bir isimlendirme de bulunmamız gerekiyor.

***
# 26) Main Fonksiyonu Nedir?
- Bir programda zorunlu olarak bulunması gereken fonksiyondur.

- Oluşturduğumuz tüm uygulamalarda bir ana fonksiyon olması gerekiyor o ana fonksiyonun adı Main fonksiyonudur.

- Uygulamaların altında Program.cs adlı bir dosya vardır. Program.cs dosyası bizim programın başlangıç dosyası gibi düşünebilirsiniz.

- Başlangıç kodlarının bulunduğu dosya Program.cs dosyasıdır.

- Uygulamalarda Program.cs dosyası başlangıç kodlarının bulunduğu yani uygulamanın ayağa kalkabilmesi için başlangıç kodlarının bulunduğu bir dosyadır.

- .cs uzantılı dosyalar C#'a karşılık gelir.

- Uygulama ayağa kalktığında işletim sistemiyle iletişim kurabilecek metodun ve bu metot içerisinde başlangıca dair gerekli komutların inşa edildiği bir yapılanmadır.

- Siz bir uygulamayı çalıştırdığınızda bu uygulamanın bulunduğu işletim sistemiyle iletişimini kontağını sağlayan fonksiyona biz main fonksiyonu diyoruz.

- Başlangıç kodlarını biz Main'in içinde yazarız. Bir uygulama ayağa kalkarken işletim sistemiylede ilişkiyi kurar ilk ilişkiyi kurduğundan dolayı ilk tetiklenen fonksiyonda budur zaten.

- Herhangi bir uygulama olsa da bu main fonksiyonundan sade ve sadece 1 adet olmak zorundadır.

- Main fonksiyonu uygulamada Program.cs dosyası içerisinde Main isminde bulunur.

- Main fonksiyonu uygulama adına işletim sistemiyle iletişim kurar.

- Yani bu fonksiyon uygulama ilk ayağa kalktığında ilk tetiklenen fonksiyondur. Dolayısıyla ilk kodlarımızı bu fonksiyonda yazarız.

- Bir uygulamada Main isimli fonksiyon sade ve sadece 1 tane olabilir ve 1 tane olmak zorundadır başka bir yerde başka bir dosyanın içerisinde main isimli bir fonksiyon olamaz. 

- Bu fonksiyonla işletim sistemiyle konfigürasyon/iletişim/kontak sağlanır. Bu kontak neticesinde bizim uygulamamıza işletim sistemi veri gönderebiliyor. Bizde bu veriyi kontağı sağladığımız Main üzerinden yakalayıp içeride işleyebiliriz.

- İşletim sistemi bişey gönderirken bu uygulama eğer sağlıklı bir uygulamaysa uygulamanın içerisinde Program.cs altında 1 tane Main isimli bir fonksiyon var oraya göndereceğini biliyor.

- Haliyle uygulamanın içerisinde Main yoksa ayağa kaldıramazsınız/derleyemezsiniz. Olmak zorundadır. 

<img src="45.png" width="auto">

***
# 27) dotnet run -value- Yapısı İle Uygulamayı Çalıştırme ve args Parametresine Değer Gönderme
- Main uygulama ayağa kalktığı anda işletim sistemiyle kontağı kuran bir yapılanmaya sahip.

- Metotlar parametre alan yapılardır.

- dotnet cli komutlarıyla eğer ki biz bu uygulamayı çalıştırırsak buradaki uygulamaya args parametresine değer gönderip uygulama içerisinde bu değeri yakalayabiliyorum

- Komut istemi işletim sisteminin olduğu kısımdır.

- dotnet run [parameter] => parametreleri bu şekilde gönderebilirsin.

- İstediğin kadar değeri arada boşluk bırakarak gönderebilirsin.

<img src="46.png" width="auto">
<img src="47.png" width="auto">
<img src="48.png" width="auto">

***
# 28) Top-Level Statements (C# 9.0) Özelliği
- Biz herhangi yeni bir konuda araştırma yapıyor olabiliriz ve bu konuyla ilgili test komutları çalıştırmamız gerekiyor olabilir. Bir deneme yapmam lazım ve bir projetye ihtiyacım var. Böyle bir durumda bir developer gider bir Console uygulaması açar ve orada deneme yapar.

- Basit denemelerde bile ekranda birçok komuta maruz kalırız.

- Bişey deneyeceksin ama basmakalıp belirli bir kodun burada inşa edilmiş olması gerekiyor Buna Boilerplate denir. Basmakalıp bir kod geliyor ve o kodun içerisinde denememizi yapmak zorundayız.

- Bu gelen özellik sayesinde basmakalıp kod bloğunu yazmaksızın using'ten sonra ilgili işlemlerimizi gerçekleştirebiliriz.

<img src="49.png" width="auto">

- Sıradan bir işlem için bile oluşturulan console uygulamasında bile basmakalıp(boilerplate) kodların gelmesi gerekmektedir. Günlük hayatta basit kodlar inşa edebilmek ve test süreçlerinde hızlı denemeler yapabilmek için bu tarz bir kod bloğuna maruz kalmamıza gerek var mı?

- C# 9.0 ile gelen top level statements özelliği ile Main fonksiyonunun zoraki imzasının tanılanması kaldırılmıştır.

- Main fonksiyonunun kullanılması developer'ın kararına bağlıdır.

- Yani ister yazabilirsin ister yazmayabilirsin ama bil ki her halükarda arkada varsayılan bir main fonksiyonu olacaktır.

<img src="50.png" width="auto">

- Eskiden ekrana Hello World yazdırabilmek için bile Main fonksiyonunda yazmamız gerekiyordu. Artık C# 9.0 ile sen bu komutu yazacaksan direkt yazabilirsin.

- Normalde C# 9.0'dan önce bu kod derlenmeyecekti. Çünkü böyle bir syntax bulunmamaktaydı. Lakin C# 9.0 ile Top Level Statements özelliği bizlere bu şekilde bir kod inşa etmemizi sağlamaktadır.

- Kurallar;
    1. Using blokları ile namespace arasında kodlar yazılabilir. 
    2. Bu işlem sade ve sadece Program.cs dosyasında geçerlidir. Yani Main fonksiyonunda yazılacak komutların direkt burada yazılmasına müsaade edilmekte lakin farklı bir dosyada bu işlemi gerçekleştirememekteyiz.

- Bu şekilde yazılan komutlar derlendikten sonra esasında bir Main fonksiyonu içerisine alınacaktır.

- Yani sen kodu inşa ederken artık bir Main'de inşa etmek zorunda değilsin. Amma velakin derledikten sonra sistem kendisi otamatik bir Main'de görecektir.

- using bloklarıyla namespace arasındaki kodları algılayacaktır. Onlar direkt Main'in kodları olarak kabul edilecek ve arkada oluşturulan Main'e direkt onları yazacaktır.

- Eğer namespace varsa using ile namespace arasında olmalı.

- Uygulama derlenirken Program.cs dosyasında varsa Top Level Statements özelliği bu dosyaya özel algılayacak ve ilgili alana yazılan kodları Main içerisinde yorumlayacaktır.

- Bunun dışında zaten bu özelliği başka bir dosyada kullanamayacağımızdan dolayı sadece Program.cs dosyasına has bir özelliktir.

<img src="51.png" width="auto">

- Top Level Statements genellikle Microservices yapılanmasında kodun gelişimi açısından hız kazandırıcı bir niteliğe sahiptir.

- Bu bir özelliktir. Bir düğme gibi düşünebilirsiniz kullansanız da olur kullanmasanız da.

<img src="52.png" width="auto">

***
# 29) Yorum Satırları ve Region
- Biz kod yazacağız ve bazen yazdığımız kodlar komkleks olabilir. Kompleks yazılmış bir kodu açıklama satırlarıyla zengilneştiririz. Daha niteliksel hale getiririz.

- Benim yazmış olduğum kodda örneğin bir işlem gerçekleştirmişimdir. Yapmış olduğum bu işlemi benim bir şekilde izah edebilmem lazım. İşte bu izahati yorum/açıklama satırlarıyla yapıyoruz.

- Biz yorum satırı kullandığımız zaman uygulamayı derlersek eğer  '//' bu operatör sayesinde satırın bir yorum satırı olduğunun farkına varacak ve burayı derlemeyecektir. Yani kod olarak görmeyecektir.

- Genellikle biz açıklama satırlarını kodun izahatini yapmak için kullanırız. Küçük/Ufak/Kısa izahatler destan yazmanız doğru olmayacaktır.

## Açıklama Satırları/Yorum Satırları
- Kodun niteliğini, anlaşılabilirliğini, kalitesini arttırabilmek için kullanılırlar.

- Kritik noktalarda ve özet olarak kodları izah etmeliyiz.

- // Tek Satırlık
- /* Çok Satırlık Yorum Alanı */

- Nerede Kullanılırlar? : İstediğin her yerde yorum yazabilirsin lakin kod konseptini ve semantik akışı bozmaman kaydıyla..

- Her yerde yorum satırı oluşturabilirsiniz.

## Region

- Kod dosyasını kategorik hale getirmemizi sağlayan bir ön işlemci komutudur. 

- Ön işlemci komutu editörün yorumlayabildiği bir yapılanmadır.

- Developer'ın yazmış olduğu kodu daha net görmesini ve kategorize etmesini sağlar.

- Kodu kategorize hale getimemize inanılmaz derece de yardımcı oluyor. Bize inanılmaz derece de hız kazandırıyor. Anlamlı hale getiriyor kodumuzu. 

<img src="53.png" width="auto">