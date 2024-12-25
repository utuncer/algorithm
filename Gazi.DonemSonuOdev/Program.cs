using System.ComponentModel;

namespace Gazi.DonemSonuOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string formatHata = "Lütfen sadece sayı giriniz";
            string OverflowHata = "Girilen sayı değeri tanımlanamadı";
            string notDegeriHata = "Notu 0-100 aralığında girmelisiniz";

            double vizeNotu = 0;
            double finalNotu = 0;
            double notOrtalama = 0;

            double sinifNotOrtalama = 0;
            double enKucuk = 0;
            double enBuyuk = 0;

        string[] tabloBaslik = new string[]
        {
                    "Numara",
                    "Ad",
                    "Soyad",
                    "Vize Notu",
                    "Final Notu",
                    "Ortalama",
                    "Harf Notu"
        };

            try
            {
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz: ");
                int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());


        double[] ortalamaToplam = new double[ogrenciSayisi];



        string[,] dizi = new string[ogrenciSayisi + 1, tabloBaslik.Length];

                for (int i = 0; i<tabloBaslik.Length; i++)
                {
                    dizi[0, i] = tabloBaslik[i];
                }


                for (int i = 0; i<ogrenciSayisi; i++)
                {
                    Console.Write($"{i + 1}. Öğrencinin Numarasını Giriniz: ");
                    dizi[i + 1, 0] = Console.ReadLine();

                    Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                    dizi[i + 1, 1] = Console.ReadLine();

                    Console.Write($"{i + 1}. Öğrencinin Soyadını Giriniz: ");
                    dizi[i + 1, 2] = Console.ReadLine();

                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i + 1}. Öğrencinin Vize Notunu Giriniz: ");
                            dizi[i + 1, 3] = Console.ReadLine();
                            vizeNotu = Convert.ToDouble(dizi[i + 1, 3]);

                            if (vizeNotu > 100 || vizeNotu< 0)
                            {
                                Console.WriteLine(notDegeriHata);
                            }
                            else
{
    break;
}
                        }
                        catch (FormatException)
                        {
    Console.WriteLine(formatHata);
}
                        catch (Exception hata)
                        {
                            Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Message}");
                        }
                    }

                    while (true)
{
    try
    {
        Console.Write($"{i + 1}. Öğrencinin Final Notunu Giriniz: ");
        dizi[i + 1, 4] = Console.ReadLine();
        finalNotu = Convert.ToDouble(dizi[i + 1, 4]);

        if (finalNotu > 100 || finalNotu < 0)
        {
            Console.WriteLine(notDegeriHata);
        }
        else
        {
            break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine(formatHata);
    }
    catch (Exception hata)
    {
        Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Message}");
    }
}

notOrtalama = vizeNotu * 0.40 + finalNotu * 0.60;
dizi[i + 1, 5] = notOrtalama.ToString();
ortalamaToplam[i] = notOrtalama;

if (notOrtalama >= 85) { dizi[i + 1, 6] = "AA"; }
else if (notOrtalama >= 75) { dizi[i + 1, 6] = "BA"; }
else if (notOrtalama >= 60) { dizi[i + 1, 6] = "BB"; }
else if (notOrtalama >= 50) { dizi[i + 1, 6] = "CB"; }
else if (notOrtalama >= 40) { dizi[i + 1, 6] = "CC"; }
else if (notOrtalama >= 30) { dizi[i + 1, 6] = "DC"; }
else if (notOrtalama >= 20) { dizi[i + 1, 6] = "DD"; }
else if (notOrtalama >= 10) { dizi[i + 1, 6] = "FD"; }
else { dizi[i + 1, 6] = "FF"; }

Console.WriteLine(" ");
                }

                enKucuk = ortalamaToplam.Min();
enBuyuk = ortalamaToplam.Max();
sinifNotOrtalama = ortalamaToplam.Average();

for (int i = 0; i < ogrenciSayisi + 1; i++)
{
    for (int j = 0; j < tabloBaslik.Length; j++)
    {
        Console.Write(dizi[i, j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine($"\nSınıf Ortalaması: {sinifNotOrtalama}\nEn Düşük Not: {enKucuk}\nEn Yüksek Not: {enBuyuk}");
            }
            catch (FormatException)
            {
    Console.WriteLine(formatHata);
}
            catch (OverflowException)
            {
    Console.WriteLine(OverflowHata);
}
            catch (Exception hata)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Message}");
            }
        }
    }
}

