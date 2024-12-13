namespace Gazi.DongulerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Adınızı Girin: ");
            //string name = Console.ReadLine();
            //Console.Write("adınız :{0}, kaç defa tekrar edilsin: ",name);
            //int repeatCount = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < repeatCount+1; i++)
            //{
            //    Console.WriteLine($"{i}.{name}");
            //}

            /*
        Başlangıç değeri giriniz:
       5 
       bitiş değeri giriniz:
       8
        */
            /* Kullanıcı tek derse tek sayıların toplamını kullanıcı çift yazarsa çift sayıları toplayacak */
            Console.Write("Başlangıç değerini giriniz: ");
            int baslangicDeger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş değerini giriniz: ");
            int bitisDeger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aralıktaki Sayıları Topla -> Tek/Çift: ");
            string sayiDurum = Console.ReadLine().ToLower().Trim();
            int toplam = 0;

            if (baslangicDeger > bitisDeger)
            {
                // Başlangıç değerini kaybetmeden
                int temp = baslangicDeger;
                baslangicDeger = bitisDeger;
                bitisDeger = temp;
            }
            switch (sayiDurum)
            {
                case "tek":

                    for (int i = baslangicDeger; i <= bitisDeger; i++)
                    {
                        if (i % 2 != 0)
                        {
                            toplam += i; // toplam = toplam + i;
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("Aralıktaki tek sayıların toplamı = {0}", toplam);
                    break;
                case "çift":

                    for (int i = baslangicDeger; i <= bitisDeger; i++)
                    {
                        if (i % 2 == 0)
                        {
                            toplam += i; // toplam = toplam + i;
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("Aralıktaki çift sayıların toplamı = {0}", toplam);
                    break;
                default:
                    Console.WriteLine("Yanlış değer girildi...");
                    break;
            }
        }
    }
}

// ctrl + F5 -> Kodu kullanacak kullanıcının ekranına çıkacak yapıyı çalıştırır
// F5 kodu yapan kişiye özel çalışır (hata kodları vs takip edilir)
// Döngüler: Aynı işi tekrar tekrar yaptırmak için kullanılan yapılardır.