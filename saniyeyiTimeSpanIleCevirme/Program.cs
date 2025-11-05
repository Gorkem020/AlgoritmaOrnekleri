namespace saniyeyiTimeSpanIleCevirme
{
    internal class Program
    {
            // Saniyeyi dakika ve saate çevirme işlemi Timespan kullanılarak yapılmışıtır.
        public static string SaniyeyiDijitalSaateCevir(long toplamSaniye)
        {
            TimeSpan sure = TimeSpan.FromSeconds(toplamSaniye);

            string cevrilmis = $"{(int)sure.TotalHours:D2}:{sure.Minutes:D2}:{sure.Seconds:D2}";

            return cevrilmis;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("--- Saniyeyi Dijital Saate Çevirme ---");
            while (true)
            {
                Console.Write("Lütfen toplam saniyeyi girin");
                string girdi = Console.ReadLine();
                if (long.TryParse(girdi, out long toplamSaniye))
                {
                    string cevrilmisZaman = SaniyeyiDijitalSaateCevir(toplamSaniye);
                    Console.WriteLine($"SONUÇ: {cevrilmisZaman}");
                }
                else
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sadece bir sayı girin.");
                }
            }
        }
    }
}

