using System;

namespace Gazi.HelloWorldAppSube2
{
    internal class Program
    {
        static int sayi = 15;
        static void Main(string[] args)
        {
            #region Veri Tipleri ve Tanımlamaları
            //Console.WriteLine("Gazi");
            //Console.WriteLine("Üniversitesi");

            //const byte a = 20;
            //double d;
            //a = 30;
            //d = 40;
            //Console.Write(a);
            //byte a = 30;
            //double d = 40;
            //a = 50;

            //var number = 10;

            //Console.WriteLine(a);

            //const int a = 50;

            //byte yas;
            //Console.WriteLine(yas);

            //int sayi = 10;
            //byte number = 10;

            //float sayi = 3.15f;
            //double _sayi = 3.15;
            //decimal __sayi = 3.15m;
            //var sayi = 10.5D;//Implicit (Veri tipi belirlenmeden yapılan tanılamalar
            //byte number = 5;//Explicit (Veri tipinin açık olara belirtildiği tanımlamalar)
            //var sonuc = true; 
            #endregion

            #region String Birleştime İşlemleri
            //string isim = "Ahmet";
            //string soyad = "Mehmet";

            //Console.WriteLine("Hoşgeldin, "+ isim + " " + soyad);
            //Console.WriteLine("Hoşgeldin, {0} {1}", isim, soyad);
            //Console.WriteLine($"Hoşgeldin, {isim} {soyad}");
            #endregion

            #region Kullanıcı Etkileşimleri
            //try
            //{
            //    Console.Write("İsminizi Giriniz:");
            //    string name = Console.ReadLine();
            //    Console.Write("Soyadınızı giriniz:");
            //    string surname = Console.ReadLine();
            //    Console.Write("Yaşınızı giriniz:");
            //    byte age = byte.Parse(Console.ReadLine());
            //    Console.WriteLine($"Hoşgeldiniz,\nİsminiz:{name}\nSoyadınız:{surname}\nYaşınız:{age}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yaşınızı sayı ile giriniz.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası değer giriniz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu...");//Kullanıcıya Göster

            //    Console.WriteLine($"Tarih:{DateTime.Now}\nMessage:{ex.Message}\nStack Trace:{ex.StackTrace}");//Kendimiz için tuttuğumuz loglar.Veritabanı,txt dosyası,email vb olabilir.
            //}

            #endregion

            #region +=, -= kullanımı
            //double maas = 5000;
            //maas -= 1000;// maas = maas - 1000;
            //Console.WriteLine(maas);

            //int sayi1 = 10;
            //int sayi2 = 20;

            //int sayi3 = ++sayi1;


            // Console.WriteLine(sayi2 % sayi1);

            //Ternary Operator - 3 adet operand alır.
            //string sonuc = sayi1 > sayi2 ? "Sayı 1 büyük" : "Sayı2 büyük veya sayılar eşit";
            #endregion

            #region Tür Dönüşümleri

            //byte sayi = 20;
            //int number = sayi;//Implicit Type Casting

            //checked
            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number);
            //}

            //string value = "20";
            //string value2 = "30";
            //byte sayi = Convert.ToByte(value);
            //byte sayi2 = byte.Parse(value2);
            //Console.WriteLine(sayi + sayi2);

            //int sayi = 20;//STACK
            //object value = sayi;//STACK->HEAP Boxing
            //int number = (int)value;//Heap->Stack Unboxing 
            #endregion

            #region Kolay İf - Else if - Else Kullanımı
            //Console.WriteLine("1. sayıyı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("Sayı 2 büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}
            #endregion

            #region Hava Durumu Nasıl? Uygulaması (if/else if/else)

            //Console.WriteLine("hava nasıl?(güzel/kötü)");
            //string cevap = Console.ReadLine().ToLower().Trim();

            //if (cevap == "güzel")
            //{
            //    Console.Write("Hava kaç derece = ");
            //    int derece = Convert.ToInt32(Console.ReadLine());
            //    if (derece < 15)
            //    {
            //        Console.WriteLine($"Hava {derece} derece hava soğuk evde otur");
            //    }
            //    else if (derece > 35)
            //    {
            //        Console.WriteLine($"Hava {derece} derece hava sıcak evde otur");
            //    }
            //    else if (derece <= 35 || derece >= 15)
            //    {
            //        Console.WriteLine($"Hava {derece} derece dışarı çık");
            //    }
            //}
            //else if (cevap == "kötü")
            //{
            //    Console.WriteLine("evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("sadece güzel/kötü cevabı verebilirsiniz.");
            //}
            //// <15: Hava soğuk evde otur 
            //// 15-35 dışarı çık
            //// >35 hava sıcak evde otur




            // Ctrl + F5 ile kullanıcının nasıl önizleyeceğini görürsün
            // F5 ile debugger modunda çalıştırırsın
            #endregion

            #region Bankacılık uygulaması if else
            //Console.Write("İşlem seçiniz:\n1-EFT\n2-Havale İşlemleri\n3-İnternet Bankacılığı\n4-Şifre İşlemleri\nSayı Giriniz: ");
            //int islem = Convert.ToInt32(Console.ReadLine());

            //if (islem == 1)
            //{
            //    Console.WriteLine("EFT");
            //}
            //else if (islem == 2)
            //{
            //    Console.WriteLine("Havale İşlemleri");

            //}
            //else if (islem == 3)
            //{
            //    Console.WriteLine("İnternet Bankacılığı");

            //}
            //else if (islem == 4)
            //{
            //    Console.WriteLine("Şİfre İşlemleri");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı veya harf tuşladınız...");

            //}
            #endregion

            #region Bankacılık uygulaması switch/case/default
            //Console.Write("İşlem seçiniz:\n1-EFT\n2-Havale İşlemleri\n3-İnternet Bankacılığı\n4-Şifre İşlemleri\nSayı Giriniz: ");
            //int islem = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine("EFT İşlemleri");
            //        break;
            //    case 2:
            //        Console.WriteLine("Havale İşlemleri");
            //        break;
            //    case 3:
            //        Console.WriteLine("İnternet Bankacılığı");
            //        break;
            //    case 4:
            //        Console.WriteLine("Şifre İşlemleri");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş Yaptınız");
            //        break;
            //}
            //// Bir program ne kadar az satır okursa o kadar performansı iyidir. Switch if-else den daha performanslıdır ama onun kadar esnek değişdir.
            #endregion

            #region Geometri Alan/Çevre Hesaplayan Uygulama (swtitch/case, if/else iç içe kullanımı)
            Console.Write("-> (TR/EN)");
            string dil = Console.ReadLine().ToLower().Trim();
            string tercih = "";
            int uzunluk = 0;
            int secim = 0;
            switch (dil)
            {
                case "tr":
                    Console.Write("1-Kare\n2-Daire\n3-Üçgen\nSeçiminizi yapın = ");
                    secim = Convert.ToInt32(Console.ReadLine());
                    tercih = "";
                    uzunluk = 0;
                    switch (secim)
                    {
                        case 1:
                            Console.Write("Kareyi Seçtiniz Alan/Çevre = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Karenin bir kenarının uzunluğunu giriniz = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());
                            if (tercih == "alan")
                            {
                                Console.WriteLine($"Karenin alanı {uzunluk * uzunluk}");
                            }
                            else if (tercih == "çevre")
                            {
                                Console.WriteLine($"Karenin çevresi {4 * uzunluk}");
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir ifade girdiniz");
                            }
                            break;
                        case 2:
                            Console.Write("Daireyi Seçtiniz Alan/Çevre = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Dairenin çap uzunluğunu giriniz = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());
                            if (tercih == "alan")
                            {
                                Console.WriteLine($"Dairenin alanı {uzunluk * uzunluk * Math.PI}");
                            }
                            else if (tercih == "çevre")
                            {
                                Console.WriteLine($"Dairenin çevresi {2 * uzunluk * Math.PI}");
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir ifade girdiniz");
                            }
                            break;
                        case 3:
                            Console.Write("Üçgeni Seçtiniz Alan/Çevre = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Eşkenar üçgenin bir kenarının uzunluğunu giriniz = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());

                            if (tercih == "alan")
                            {
                                Console.WriteLine($"Eşkenar üçgenin alanı {((uzunluk * uzunluk) * Math.Sqrt(3)) / 4}");
                            }
                            else if (tercih == "çevre")
                            {
                                Console.WriteLine($"Eşkenar üçgenin çevresi {3 * uzunluk}");
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir ifade girdiniz");
                            }

                            break;
                    }
                    break;
                case "en":
                    Console.Write("1-Square\n2-Circle\n3-Triangle\nMake your choice = ");
                    secim = Convert.ToInt32(Console.ReadLine());
                    tercih = "";
                    uzunluk = 0;
                    switch (secim)
                    {
                        case 1:
                            Console.Write("You chose Square. Area/Perimeter = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Enter the length of one side of the square = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());
                            if (tercih == "area")
                            {
                                Console.WriteLine($"The area of the square is {uzunluk * uzunluk}");
                            }
                            else if (tercih == "perimeter")
                            {
                                Console.WriteLine($"The perimeter of the square is {4 * uzunluk}");
                            }
                            else
                            {
                                Console.WriteLine("You entered an invalid input");
                            }
                            break;
                        case 2:
                            Console.Write("You chose Circle. Area/Perimeter = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Enter the diameter of the circle = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());
                            if (tercih == "area")
                            {
                                Console.WriteLine($"The area of the circle is {uzunluk * uzunluk * Math.PI}");
                            }
                            else if (tercih == "perimeter")
                            {
                                Console.WriteLine($"The circumference of the circle is {2 * uzunluk * Math.PI}");
                            }
                            else
                            {
                                Console.WriteLine("You entered an invalid input");
                            }
                            break;
                        case 3:
                            Console.Write("You chose Triangle. Area/Perimeter = ");
                            tercih = Console.ReadLine().ToLower().Trim();
                            Console.Write("Enter the length of one side of the equilateral triangle = ");
                            uzunluk = Convert.ToInt32(Console.ReadLine());

                            if (tercih == "area")
                            {
                                Console.WriteLine($"The area of the equilateral triangle is {((uzunluk * uzunluk) * Math.Sqrt(3)) / 4}");
                            }
                            else if (tercih == "perimeter")
                            {
                                Console.WriteLine($"The perimeter of the equilateral triangle is {3 * uzunluk}");
                            }
                            else
                            {
                                Console.WriteLine("You entered an invalid input");
                            }

                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Bir seçim yapın / Make a choice");
                    break;
            }


            #endregion


        }
    }
}

//namespace:İçinde classları bulunduran yapılardır.
//Scope(Blok Yapıları): {} parantezleri arasındaki alanlardır.
//Class: İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yüzeysel olarak yapılmıştır. Daha sonra detaylandırılacaktır)
//Metod: İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının başlangıç noktasıdır.
//Ctrl+F5: Uygulamayı hata ayıklama modu olmadan başlatır.

//Syntax:Kod yazım kuralları
//1-Açılan her parantez mutlaka kapatılmalıdır.
//2- Scope tanımlamaları sonunda ; kullanılmaz ancak komut satırları sonlarında kullanılır.

//Syntax Hatalarını Nasıl Anlarız?
//1- Hata olan kodun altı kırmızı ile çizilir
//2-Scrool bar'da hata olan yere kırmızı işaretleme yapılır
//3-VS kod editörünün alt çubuğunda Kırmızı renkli X ve yanında hata sayısı görülür.

//Syntax Hatası olan program çalışır mı? Hayır, çünkü program derlenmez.

//IntelliSense: Kod yazarken açılan pencere ile karşımıza çıkan öneriler
//IntelliCode:Yapay zeka destekli kod yazım yardımcısı. Gelen önerileri TAB tuşu ile kabul edebiliriz.

//Solution->Project(s)
//View->Solution Explorer

//Ctrl+K+D: Kod hiyerarşisini düzenlemek için kullanılır.
//Ctrl+K+C: Seçili satırları açıklama satırı haline dönüştürür
//Ctrl+K+U: Açıklama satırını tekrar normal satır haline dönüştürür


//C# -> Derleme -> MS-IL -> .NET Runtime(Derleme) -> 0-1(Binary)

//Microsoft Intermediate Language

//1 Bit = 0 veya 1
//1 byte=8bit
//1 Kilo Byte(KB)=1024 byte
//1 Megabyte(MB) = 1024KB
//1 Gigabyte(GB) = 1024MB
//1 Terabyte(TB) = 1024GB

//sbyte=Signed Byte
//ushort=Unsigned Short

//Değer tipleri belleğin STACK bölgesini kullanır
//Referans tipleri HEAP bölgesi kullanır
//HEAP bölgesi stack bölgesine göre daha büyüktür. Dolayısıyla tek seferde birden fazla veri depolayabilir. Örn. Ahmet stringinde 5 tane char vardır.
//Referans tipi değişkenlerde, referanslar STACK bölgesinde, değerler HEAP bölgesinde tutulur. Değere ulaşmak için, o değerin HEAP bölgesindeki adresini bilen referansına ulaşmak gereklidir.

//Metod Parametresi: Metodların işlerini yapabilmek için ihtiyaç dudukları verilerdir. Bir metod hiç parametre istemeyebilir yada birden fazla veri tipinde paramere de kabul edebilir.

//void: Bu geri dönüş tipine sahip metodlar, işlerini yaptıktan sonra geriye bilgi dönmezler.

//C# programlama dili Tip Güvenliği(Type Safety) sağlayan bir dildir.
//Uyumsuz tipler arası veri ataması yapılamaz. Örn. string->byte
//checked blokları: Büyük türden küçük türe yapılan dönüşümlerde hata atarak, veri kaybı ihtimalini önler.
//Debug:Hata yakalama işlemleri. 
//Hata yönetimleri C#'da try-catch ile yapılır

//Ctrl+F5: Start without debugging
//F5: Start Debugging

//1 && 1 = 1
//1 && 0 = 0
//0 && 1 = 0
//0 && 0 = 0

//1 || 1 = 1
//1 || 0 = 1
//0 || 1 = 1
//0 || 0 = 0

//Breakpoint:Programın istenen satırda durdurulup, sonraki satırların adım adım izlenmesine olanak sağlayan DEBUG yöntemidir.

//Case Sensitive: C# programlama dilinde büyüm harfler ile küçük harfler aynı değildir. Büyük/Küçük harf duyarlılığı

//String classının metodlarından bazıları
//ToLower(): Tüm karakterleri küçük harfe çevir
//ToUpper():Tüm karakterleri büyük harfe çevir
//Trim(): String ifadenin başında ve sonunda bulunan boşlukları siler