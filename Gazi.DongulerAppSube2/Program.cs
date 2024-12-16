using System.ComponentModel;

namespace Gazi.DongulerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kullanıcı adını girip istediği sayıda tekrar eden program
            //Console.Write("Adınızı Girin: ");
            //string name = Console.ReadLine();
            //Console.Write("adınız :{0}, kaç defa tekrar edilsin: ",name);
            //int repeatCount = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < repeatCount+1; i++)
            //{
            //    Console.WriteLine($"{i}.{name}");
            //}
            #endregion
            #region Girilen sayıların arasındaki kullanıcının istediğine göre tek ya da çift sayıları toplayan program
            //Console.Write("Başlangıç değerini giriniz: ");
            //int baslangicDeger = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bitiş değerini giriniz: ");
            //int bitisDeger = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Aralıktaki Sayıları Topla -> Tek/Çift: ");
            //string sayiDurum = Console.ReadLine().ToLower().Trim();
            //int toplam = 0;

            //if (baslangicDeger > bitisDeger)
            //{
            //    // Başlangıç değerini kaybetmeden
            //    int temp = baslangicDeger;
            //    baslangicDeger = bitisDeger;
            //    bitisDeger = temp;
            //}
            //switch (sayiDurum)
            //{
            //    case "tek":

            //        for (int i = baslangicDeger; i <= bitisDeger; i++)
            //        {
            //            if (i % 2 != 0)
            //            {
            //                toplam += i; // toplam = toplam + i;
            //                Console.WriteLine(i);
            //            }
            //        }
            //        Console.WriteLine("Aralıktaki tek sayıların toplamı = {0}", toplam);
            //        break;
            //    case "çift":

            //        for (int i = baslangicDeger; i <= bitisDeger; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                toplam += i; // toplam = toplam + i;
            //                Console.WriteLine(i);
            //            }
            //        }
            //        Console.WriteLine("Aralıktaki çift sayıların toplamı = {0}", toplam);
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış değer girildi...");
            //        return;
            //}
            #endregion
            #region Girilen sayıların arasındaki kullanıcının istediğine göre tek ya da çift sayıları toplayan program (Kısa Düzeltilmiş Hali)
            //Console.Write("Başlangıç değerini giriniz: ");
            //int baslangicDeger = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bitiş değerini giriniz: ");
            //int bitisDeger = Convert.ToInt32(Console.ReadLine());
            //Console.Write("1-Tek/2-Çift: ");
            //int sayiDurum = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;
            //int sonuc = (sayiDurum == 1) ? 1 : 0;
            //string tekcift = (sonuc == 1) ? "Tek" : "Çift";
            //if (baslangicDeger > bitisDeger)
            //{
            //    // Başlangıç değerini kaybetmeden
            //    int temp = baslangicDeger;
            //    baslangicDeger = bitisDeger;
            //    bitisDeger = temp;
            //}

            //for (int i = baslangicDeger; i <= bitisDeger; i++)
            //{
            //    if (i % 2 == sonuc)
            //    {
            //        toplam += i; // toplam = toplam + i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine($"{tekcift} Sayıların toplamı = {toplam}");
            #endregion
            #region Girilen Taban Sayısının Girilen Üst Kuvvetinin eşitini veren uygulama
            //Console.Write("Taban değeri giriniz = ");
            //int taban = int.Parse(Console.ReadLine());

            //Console.Write("Üs değerini giriniz = ");
            //int ust = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 1; i <= ust; i++)
            //{
            //    sonuc *= taban;
            //}
            //Console.Write($"{taban} üsttü {ust} = {sonuc}");

            #endregion
            #region Girilen sayının faktöryelini bulan uygulama
            //Console.Write("Sayı Giriniz = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc = i * sonuc;
            //}
            //Console.WriteLine(sonuc);
            #endregion
            #region Girilen sayı asal mı değil mi bulan uygulama
            //// 1 değeri istisnaidir girilen sayı 2 den küçük girilemez !!
            //// Hiçbir sayı yarısından büyük bir sayıya bölünemez
            //// stopwatch araştır
            //Console.Write("Sayı giriniz = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //if (sayi > 2)
            //{
            //    for (int i = 2; i <= sayi / 2; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Girilen sayı = {sayi}, 2'den büyük sayı girmelisiniz");
            //    return;
            //}
            //Console.WriteLine(sayac == 0 ? "Asal" : "Asal Değildir");
            #endregion
            #region Kullanıcı doğru bilgileri girene kadar tekrar soran uygulama

            //while (true)
            //{
            //    Console.Write("Kullanıcı Adı Giriniz: ");
            //    string user = Console.ReadLine();

            //    Console.Write("Şifre Giriniz: ");
            //    string pass = Console.ReadLine();

            //    if (user == "Admin" && pass == "12345")
            //    {
            //        Console.WriteLine("Giriş başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar deneyiniz...");
            //    }
            //}

            #endregion
            #region
            //int i = 0;
            //int toplam = 0;
            //while (true)
            //{
            //    i++;
            //    Console.Write($"{i}.Sayıyı Giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    Console.Write("Devam etmek istiyor musunuz? (e/h): ");
            //    char devam = char.Parse(Console.ReadLine());
            //    if (devam == 'h')
            //    {
            //        Console.WriteLine($"Girilen {i} sayının toplam değeri = {toplam}");
            //        break;
            //    }
            //}
            #endregion
        }
    }
}

// ctrl + F5 -> Kodu kullanacak kullanıcının ekranına çıkacak yapıyı çalıştırır
// F5 kodu yapan kişiye özel çalışır (hata kodları vs takip edilir)
// Döngüler: Aynı işi tekrar tekrar yaptırmak için kullanılan yapılardır.