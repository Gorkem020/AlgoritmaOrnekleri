namespace palindromSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. BASLA
             * 2. Kullanıcıdan bir kelime al.
             * 3. Kelimenin butun harflerini kucult
             * 4. Tersten kelime adında boş bir değşken oluştur.
             * 5. Tersten bir döngü başlat.
             *   5.1 : Herbir harfi tersten kelime değiskeni ile birlestir.
             * 6. Eger tersten kelime kelimeye esit ise sayi palindromdur yazdir.
             * 7. değilse palindrom degildir yazdir.
             * 8. Bitir.
             */
            Console.WriteLine("Lütfen bir kelime giriniz:");

            string kelime = Console.ReadLine();
            kelime = kelime.ToLower();

            string terstenKelime = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                terstenKelime = terstenKelime + kelime[i];

            }
            if (kelime == terstenKelime)
            {
                Console.WriteLine("Girdiginiz kelime palindromdur.");

            }
            else
            {
                Console.WriteLine("Girdiginiz kelime palindrom degildir");
            }
        }
    }
}
