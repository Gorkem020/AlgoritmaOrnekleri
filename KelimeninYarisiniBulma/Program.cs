namespace KelimeninYarisiniBulma
{
    internal class Program
    {
        /* Kelimenin yarısını bulan algoritma
           1.Basla
           2.Kullanıcıdan bir kelime al  
           3.kelimenin uzunluğunu bul
           4.kelimenin uzunluğunu 2'ye böl, kelimenin yarısını al
           5.ilk yarıyı ekrana yazdır
           6.ikinciyi yaryı alt satıra yazdır
           7.Bitir
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz:");
            string kelime = Console.ReadLine();

            int uzunlukYarisi = kelime.Length/2;

            string ilkYari = kelime.Substring(0, uzunlukYarisi);
            string ikinciYari = kelime.Substring(uzunlukYarisi);

            Console.WriteLine("Kelimenin ilk yarısı: " + ilkYari);
            Console.WriteLine("Kelimenin ikinci yarısı: " + ikinciYari);
        }
    }
}
