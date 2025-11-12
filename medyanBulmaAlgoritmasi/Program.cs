namespace medyanBulmaAlgoritmasi
{
    internal class Program
    {
          /* 
             * 1.Başlat
             * 2.Bir boş  listesi oluştur
             * 3.Kullanıcıdan kaç tane sayı girmek istediğini öğren
             * 4.Sayıları teker teker kullanıcıdan al
             * 5.Bir fonksiyon tanımlayıp liste uzunluğunu  bul
             *  5.1.Eğer uzunluk tek  sayı ise ortadaki sayı medyandır
             *  5.2.Eğer çift ise ortadaki iki sayının ortalaması medyandır.
             * 6.Bitir
             
             */
        
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();

            Console.Write("Kaç sayı gireceksiniz? : ");
            int adet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }

            double medyan = MedyanHesapla(sayilar);

            Console.WriteLine($"Girdiğiniz sayıların medyanı: {medyan}");
        }
        static double MedyanHesapla(List<int> sayilar)
        {
            sayilar.Sort();
            int n = sayilar.Count;
            int orta = n / 2;

            if (n % 2 == 1)
                return sayilar[orta];

            return (sayilar[orta - 1] + sayilar[orta]) / 2.0;
        }
    }
}
