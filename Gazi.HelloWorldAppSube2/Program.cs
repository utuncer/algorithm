﻿using System;

namespace Gazi.HelloWorldAppSube2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console.WriteLine’da Yazım (Syntax) Kuralları - String Birleştirme
            //string isim = "ahmet";
            //string soyad = "mehmet";

            //Console.WriteLine("hoşgeldiniz, " + isim + " " + soyad);
            //Console.WriteLine("hoşgeldiniz, {0} {1}", isim, soyad);
            //Console.WriteLine($"hoşgeldiniz, {isim} {soyad}");
            #endregion
            #region Kullanıcı Etkileşimleri
            Console.Write("isminizi giriniz: ");
            string name = Console.ReadLine();
            Console.Write("soyadınızı giriniz: ");
            string soyad = Console.ReadLine();
            Console.Write("yaşınızı giriniz: ");
            string yas = Console.ReadLine();
            Console.WriteLine($"hoşgeldin,\n{name} {soyad}\nyaşınız {yas}");
            #endregion

        }
    }
}

/*


namespace: İçinde classları bulunduran yapılardır.

Scope(Blok Yapıları): {} parantezleri arasındaki alanlardır.

Class: İçinde metodları bulunduran yapılardır. (Bu tanım şimdilik yüzeysel 
olarak yapılmıştır. Daha sonra detaylandırılacaktır)

Metod: İş yapan kod bloklarına metod denir.

Main Metodu: Console uygulamalarının başlangıç noktasıdır.

Ctrl + F5: Uygulamayı hata ayıklama modu olmadan başlatır.

Syntax: Kod yazım kuralları

1- Açılan her parantez mutlaka kapatılmalıdır
2- Scope tanımlamaları sonunda ; kullanılmaz ancak komut satırları sonlarında kullanılır.

Syntax hatalarını nasıl anlarız?
1-Hata olan kodu altı kırmızı ile çizilir
2-Scrool bar'da hata oaln yere kırmızı işaretleme yapılır
3-VS (Visual Studio) kod editörünün alt çubuğunda kırmızı renkli x ve yanında hata sayısı görülür

Syntax Hatası olan program çalışır mı? Hayır, son başarılı derlemeyi çalıştırma seçeneği karşımıza çıkar

Uzun kodları alt satıra geçirme
tools -> options -> text editor -> c# -> Word Wrap

System.Console.WriteLine
nameplace.class.metod

Yazı önerisi çıkarma kısa yolu
Ctrl + Space

IntelliSense: Kod yazarken açılan pencere ile karşımıza çıkan öneriler

IntelliCode: Yapay zeka destekli kod yazım yardımcısı. Gelen önerileri TAB tuşu ile kabul edebiliriz.

Solution -> Project(s) ->

Solution Explorer penceresi kapandığında
View -> Solution Explorer

Çalışma dosyasının nerede olduğunu görmek için

Solutin "[projeismi]" sağ tık -> Open Folder in File Explorer

.sln uzantılı dosya çalışma ortamını tekrar açar

kodların yapısını boşluklarını ..vb düzeltmek için Ctrl K + Ctrl D

Açıklama satırı için tek satıra // paragraft 

Ctrl K + Ctrl C satırı yorum satırı yapar

Ctrl K + Ctrl U yorum satırını normal satır haline getirir

Ctrl B derlemeninn başarılı mı başarısız mı olduğunu kontro eder

C# -> Derleme -> MS-IL (ilk derleme makine dili değildir)

MS-IL : Microsoft Intermadiate Language

C# -> Derleme -> MS-IL -> .Net Runtime (Derleme) -> 0-1(Binary)

Farklı işlemcilerde de çaluşmasıı için MS-IL vardır
MS-IL olmasaydı program yazıldığında işlemciye özel derlendiğinden başka sistemlerde kullanılırken hata olurdu

Değişkenleri tek satırda da tanımlayabilirsin
byte a = 30, b;

**Static Değişken Tanımlamak**

Tanımlamanın başına sadece static sözcüğü getirilir.

static byte a;

a ? 30;

**Sabit Değişken Tanımlamak**

Tanımlamanın başına sadece const sözcüğü getirilir.

Değişkenin değeri sonradan değiştirilemez.

const byte a;

a = 30; x

const byte a = 30;

int* yas;

- HEAP bölgesi STACK bölgesine göre daha büyüktür. Dolayısıyla tek seferde birden fazla veri depolayabilir. Örn: Ahmet stringinde 5 tane char vardır.
- Referans tipi değişkenlerde, referanslar STACK bölgesinde, değerler HEAP bölgesinde tutulur. Değere ulaşmak için, o değerin HEAP bölgesindeki adresini bilen referansına ulaşmak gereklidir.
- **Metod Parametresi:** Metodların işlerini yapabilmek için ihtiyaç duydukları verilerdir. Bir metod hiç parametre istemeyebilir yada birden fazla veri tipinde parametre de kabul edilebilir.


Void: Bu geri dönüş tipine sahip metodlar, işlerini yaptıktan sonra geriye bilgi dönmezler. 
 */

