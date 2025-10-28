namespace KelimeninKacKezGectiginiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilen bir metin içinde belirli bir kelimenin kaç kez geçtiğini hesaplayan bir algoritma
              yazın.
          
            1.Basla
            2.Kullanıcıdan bir metin al
            3.Kullanıcıdan aranacak kelimeyi al
            4.Sonucu tutmak için bir sayaç tanımla
            5.Metni boşluklardan ayırarak bir metin dizisine ata
            6.Bir döngü ile metnin içini gez
             6.1. Eğer aranan kelime o anki kelimeye eşitse sayacı bir arttır
            7.Sayacı yazdır
            8.Bitir.   */

            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();

            Console.WriteLine("Aranacak kelimeyi giriniz:");
            string arananKelime = Console.ReadLine();

            int sayac = 0;
            string[] kelimeler = metin.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string kelime in kelimeler)
            {
                if ( kelime == arananKelime)
                {
                    sayac++;
                }
            }
            Console.WriteLine($"{arananKelime} kelimesi metinde {sayac} kere geçiyor");
            
        }
    }
}
