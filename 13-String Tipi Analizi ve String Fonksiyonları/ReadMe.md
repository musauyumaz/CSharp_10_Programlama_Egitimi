***
# 295) String Türü ve String Gerçeği
- `string` özel bir türdür. Metinsel ifadeleri tutabildiğimiz özel bir türdür.

- `string` referans türlü bir değişkendir.

- Referans türlü binlerce milyonlarca değişken olabilir ama referans türlü olupta programlama dilinde bir keywordle karşılanabilen tek tür `string`tir.

- Normalde değer türlü değişkenlerin her birini programlama dilinde karşılığı olan bir keywordle tutuyoruz.
    * bu keywordler programlama dili tarafından önceden tanımlanmış keywordlerdir.
    * `int` 
    * `short`
    * `bool`
    * `char`

- Değer türlü değişkenlerin hepsi için programlama dilinde tanımlanmış bir keyword vardır. Amma velakin referans türlü değişkenleri OOP'yi özellikle gördüğünüzde programlama dilinde bunların genelinin yani %99.9'unun keywordü yoktur. O zaten %0.1'lik kısım `string`tir. `string` bir referans türlü olduğu halde programlama dilinde tanımlanmış olan keyworde sahip tek referans türlü değerdir.

- `string` referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.

- Referans türlerin arasında bir keyworde karşılık gelen referans türlü değer `string`tir.

- Referans türlü değerler herşey olabilir. Örneğin ben Ahmet diye referans türlü değişken oluşturabilirim. Ahmet keyword mü oluyor tür mü oluyor. Şimdi tür oluyor ama bunu programalama dilinin parçası olan bir keyword olarak kullanamayiz. ve bu bütün referans türleri için geçerlidir. Sadece `string` programlama dili tarafından tanımlanabilir bir keyworde sahiptir.

- `string` yapısal olarak her ne kadar değer türlü değişkenmiş gibi kullansakta esasında referans türlü bir değişken.

- Bir değişken eğer değer türlüyse bu belleğin Stack kısmında tutulur.

- Bir değer türlü değişken varsa eğer bu belleğin Stack kısmında kendi değişkeniyle değeriyle beraber tutulacaktır. Hem değişken tutuluyor hem de değeri Stack'te tutuluyor. Amma velakin bir değer/değişken referans türlüyse değişken kısmı Stack'te tutulur. Değeri Heap'te tutulur. Referans türlü denmesinin sebebi bu değişkenin değeri referans etmesidir. Uzaktaki birşey referans edilir. Uzakta olan bir şeyi referans etmem onu işaretlemem işaret etmem anlamına gelir. `string` dediğimiz ifadeler referans türlü değişkenler/değerler oldukları için Heap'te tutulurlar. Heap'te tutulan bu değer esasında bizim için bir nesnedir.

<img src = "1.png" width = "auto">

- Her ne kadar değer türlü değişken gibi kullansakta `string` bir referans türlü değişkendir. Heap'te tutulur aslında bir nesnedir. Amma velakin referans türlü değişkenlerin arasında sanki değer türlüymüş gibi tek keywordü olan değişkendir/türdür/değerdir.

```C#
#String
//`string` referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
int a = 5;
string b = "Hilmi";
```