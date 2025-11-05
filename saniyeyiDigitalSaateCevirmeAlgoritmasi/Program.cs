namespace saniyeyiDigitalSaateCevirmeAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Saniye cinsinden bir süre girin: ");
            int toplamSaniye = Convert.ToInt32(Console.ReadLine());

            string saatFormati = SaniyeyiSaateCevir(toplamSaniye);

            Console.WriteLine($"Dijital saat formatı: {saatFormati}");
        }

        static string SaniyeyiSaateCevir(int saniye)
        {
            int saat = saniye / 3600;
            int dakika = (saniye % 3600) / 60;
            int kalanSaniye = saniye % 60;

            return $"{saat:D2}:{dakika:D2}:{kalanSaniye:D2}";
        }
    }
}
