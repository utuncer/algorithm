using System;

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
            //Console.Write("isminizi giriniz: ");
            //string name = Console.ReadLine();
            //Console.Write("soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("yaşınızı giriniz: ");
            //string yas = Console.ReadLine();
            //Console.WriteLine($"hoşgeldin,\n{name} {soyad}\nyaşınız {yas}");
            #endregion

            #region Tür Dönüşümleri
            //byte sayi1 = 20;
            //int number1 = sayi1; // Implicit Type Casting

            //checked // Veri kaybı ihtimali varsa hata atama yapar.
            //{
            //    int sayi2 = 256;
            //    byte number2 = (byte)sayi2; //explicit Type Casting
            //    Console.WriteLine(number2);
            //}

            //string value = "20";
            //string value2 = "30";
            //byte sayi3 = Convert.ToByte(value);
            //byte sayi4 = byte.Parse(value2);
            //Console.WriteLine(sayi3 + sayi4);

            //int sayi5 = 20;
            //object value5 = sayi5; //boxin
            //int number5 = (int)value5; //unboxing

            //try
            //{
            //    Console.Write("Adınızı Girin: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Yaşınızı Girin: ");
            //    byte age = Convert.ToByte(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yaşınızı sayılar ile girin...");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Yaşınız 0 ile 255 arasında olmalı...");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu..."); //Kullanıcıya göster

            //    Console.WriteLine($"Tarih: {DateTime.Now}\nMessage: {ex.Message}\nStack Trace: {ex.StackTrace}"); // Kendimiz için tuttuğumuz loglar.Veritabanı, txt dosyası, email vb olabilir.
            //}

            //int sayi1 = 10;
            //int sayi2 = sayi1++;// sayi2 = 10
            //int sayi3 = ++sayi1;//sayi3 = 11

            //int sayi1 = 10;
            //int sayi2 = 20;
            //string sonuc = sayi1 > sayi2 ? "Sayı 1 büyük" : "Sayı 2 büyük veya sayılar eşit"; //Ternary Operator - 3 adet operand (işleme giren değer) alır
            //Console.WriteLine(sonuc);

            #endregion

            #region F5 ile ve CTRL +F5 ile projeyi başlatmanın farkı
            // F5 ile başlatıldığında
            /*
             Hata Ayıklama Modunda Başlatır (Debugging Mode).
Uygulama hata ayıklayıcı (debugger) ile çalıştırılır.
             */
            // CTRL + F5 ile başlatıldığında
            /*
             Hata Ayıklama Modu Olmadan Çalıştırır (Run Without Debugging).
Uygulama, hata ayıklayıcı devre dışı bırakılarak doğrudan çalıştırılır.
             */
            #endregion

            #region 1. ve 2. sayıyı karşılaştıran if kodu

            //Console.Write("1. Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"Girdiğiniz ilk sayi ikinci sayıdan büyük {sayi1} > {sayi2}");
            //}
            //else if (sayi1 < sayi2)
            //{
            //     Console.WriteLine($"Girdiğiniz ilk sayi ikinci sayıdan küçük {sayi1} < {sayi2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Girdiğiniz ilk sayi ve ikinci eşit {sayi1} = {sayi2}");
            //}
            #endregion

            #region Hava Durumuna göre yönlendiren if kodu
            Console.WriteLine("Hava nasıl? (Güzel/Kötü)");
            string havakontrol = Console.ReadLine().ToLower().Trim();
           
            if (havakontrol == "güzel")
            {
                Console.WriteLine("Dışarı çık eğlen oley");
            }
            else if (havakontrol == "kötü")
            {
                Console.WriteLine("Dışarı çıkma otur evinde");
            }
            else
            {
                Console.WriteLine("Güzel veya Kötü'den birini seçmelisiniz");
            }
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

Tip Güvenliği: Mesela elinde byte değişkeni olsun string değer ataması yapılamayacağından stringi byte'a dönüştürmek gerekli. 

Case Sensitive: C# programlama dilinde büyük harfler ile küçük harfler aynı değildir.

String classının metodlarından bazılar
ToLower(): Tüm karakterleri küçük harfe çevir
ToUpper(): Tüm karakterleri büyük harfe çevir
Trim(): Tüm karakterleri büyük harfe çevir
 */

