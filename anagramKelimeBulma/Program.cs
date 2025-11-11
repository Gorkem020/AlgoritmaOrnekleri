namespace anagramKelimeBulma
{
    internal class Program
    {
        /*
          başla
          kullanıcdan iki kelime al
          uzunluklaruını kıyasla eşit değilse anagram değil yazdır ve bitir.
          her iki kelimeyi karekter dizisine dönüştür
          dizileri sırala
          dizinin uzunluğu kadar bir döngü başlat
          dizilerin aynı indislerini karşılaştıralım
          eğer herhangi biri eşleşmiyorsa anagram değildir yazdır bitir.
          eğer hepsi aynıysa anagram yazdır bitir
        bitir        

      */
        static void Main(string[] args)
        {
            Console.WriteLine("ilk kelimeyi giriniz");
            string kelime1 = Console.ReadLine();

            Console.WriteLine("ikinci kelimeyi giriniz");
            string kelime2 = Console.ReadLine();

            if (kelime1.Length != kelime2.Length)
            {
                Console.WriteLine("girdiğiniz kelimeler anagram değildir");
                return;
            }
            char[] dizi1 = kelime1.ToCharArray();
            char[] dizi2 = kelime2.ToCharArray();
            Array.Sort(dizi1);
            Array.Sort(dizi2);//sıralama

            for (int i = 0; i < kelime1.Length; i++)
            {
                if (dizi1[i] != dizi2[i])
                {
                    Console.WriteLine("anagram değildir");
                    return;
                }

            }
            Console.WriteLine("girdiğiniz kelime anagramdır");

        }
    }
}
