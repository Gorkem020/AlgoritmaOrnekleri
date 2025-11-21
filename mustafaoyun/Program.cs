namespace mustafaoyun
{

    class Program
    {
        // FONKSİYON: Mustafa kazanır mı kontrol et
        static string MustafaKazanirMi(int n)
        {
            // Algoritma: Eğer enerji seviyesi çift ise Mustafa kazanır
            // Çünkü çift sayıdan 1 çıkararak rakibi tek sayıya sokabilir
            // Tek sayıdan sadece tek sayı çıkarılabilir, bu yüzden rakip hep tek kalır

            if (n % 2 == 0)
            {
                return "Mustafa wins";
            }
            else
            {
                return "Mustafa loses";
            }
        }

        // FONKSİYON: Detaylı açıklama ile simülasyon
        static void DetayliAciklama(int n)
        {
            Console.WriteLine($"Başlangıç Enerji Seviyesi: {n}");
            Console.WriteLine($"Enerji Tipi: {(n % 2 == 0 ? "ÇİFT" : "TEK")}\n");

            if (n % 2 == 0)
            {
                Console.WriteLine("─── MUSTAFA KAZANIR ───");
                Console.WriteLine("\n✓ Neden Kazanır?");
                Console.WriteLine($"  • {n} çift bir sayıdır");
                Console.WriteLine($"  • Mustafa {n}'dan 1 çıkararak rakibi {n - 1}'e (tek sayı) sokabilir");
                Console.WriteLine("  • Tek sayıların bölenleri hep tektir");
                Console.WriteLine("  • Rakip her hamlesinde Mustafa'yı tekrar çift sayıya getirir");
                Console.WriteLine("  • Mustafa her seferinde rakibi tek sayıya geri gönderir");
                Console.WriteLine("  • Sonunda Mustafa enerjiyi 1'e düşürür ve kazanır!");

                Console.WriteLine("\n─── Örnek Hamle Dizisi ───");
                int enerji = n;
                int hamle = 1;
                bool mustafaninSirasi = true;

                while (enerji > 1)
                {
                    if (mustafaninSirasi)
                    {
                        Console.Write($"Hamle {hamle}: Mustafa → ");
                        if (enerji % 2 == 0)
                        {
                            Console.WriteLine($"Enerji {enerji}, 1 vurur → Yeni enerji: {enerji - 1}");
                            enerji = enerji - 1;
                        }
                    }
                    else
                    {
                        Console.Write($"Hamle {hamle}: Rakip → ");
                        // Rakip tek sayıdan tek bir bölen seçer (en kötü durumda 1)
                        int secim = 1; // Genelde 1 seçecektir
                        Console.WriteLine($"Enerji {enerji}, {secim} vurur → Yeni enerji: {enerji - secim}");
                        enerji = enerji - secim;
                    }

                    mustafaninSirasi = !mustafaninSirasi;
                    hamle++;

                    if (hamle > 10) // Sonsuz döngü önleme
                    {
                        Console.WriteLine("...(devam eder)");
                        break;
                    }
                }

                if (enerji == 1 && !mustafaninSirasi)
                {
                    Console.WriteLine($"\n✓ Mustafa enerjiyi 1'e düşürdü → MUSTAFA KAZANDI!");
                }
            }
            else
            {
                Console.WriteLine("─── MUSTAFA KAYBEDİR ───");
                Console.WriteLine("\n✗ Neden Kaybeder?");
                Console.WriteLine($"  • {n} tek bir sayıdır");
                Console.WriteLine("  • Tek sayıların tüm bölenleri tektir");
                Console.WriteLine($"  • Mustafa hangi bölen seçerse seçsin: Yeni enerji = {n} - (tek) = TEK");
                Console.WriteLine("  • Rakip de aynı şekilde Mustafa'ya hep tek sayı gönderir");
                Console.WriteLine("  • Sonunda rakip enerjiyi 1'e düşürür ve kazanır!");

                Console.WriteLine("\n─── Matematiksel Kanıt ───");
                Console.WriteLine($"  • {n} tek sayısının bölenleri:");
                Console.Write("    [ ");
                for (int i = 1; i < n && i < 20; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                if (n > 20) Console.Write("...");
                Console.WriteLine("]");
                Console.WriteLine("  • Hepsi tek sayı! → Mustafa rakibi çifte çeviremez");
            }
        }

        static void Main()
        {
            Console.WriteLine("Oyun Kuralları:");
            Console.WriteLine("• Mustafa ve rakibi sırayla hamle yapar (Mustafa başlar)");
            Console.WriteLine("• Her hamle: Mevcut enerjinin bir bölenini seç ve vur");
            Console.WriteLine("• Enerji azalır: Yeni enerji = Eski enerji - Seçilen bölen");
            Console.WriteLine("• Kazanan: Enerjiyi tam olarak 1'e düşüren oyuncu\n");

            try
            {
                // Kullanıcıdan başlangıç enerjisini al
                Console.Write("Sihirli kürenin başlangıç enerji seviyesi (n): ");
                int n = int.Parse(Console.ReadLine());

                if (n < 2 || n > 1000000000)
                {
                    Console.WriteLine("\n✗ Hata: n 2 ile 10^10 arasında olmalıdır!");
                    Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
                    Console.ReadKey();
                    return;
                }

                // Detaylı açıklama göster
                DetayliAciklama(n);

                // Sonucu hesapla
                string sonuc = MustafaKazanirMi(n);

                Console.WriteLine($">>> {sonuc} <<<");

                // Test örnekleri
                Console.WriteLine("\n\n─── Diğer Test Örnekleri ───");
                int[] testler = { 79, 63, 2, 4, 100, 101 };
                foreach (int test in testler)
                {
                    string testSonuc = MustafaKazanirMi(test);
                    Console.WriteLine($"n = {test} → {testSonuc}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n✗ Hata: Lütfen geçerli bir tam sayı girin!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\n✗ Hata: Girdiğiniz sayı çok büyük!");
            }

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}