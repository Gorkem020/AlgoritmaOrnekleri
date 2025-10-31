namespace orjinalSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Girilen dört basamaklı sayılardan ilk iki basamağı ile son iki basamağının toplamının karesi, sayının kendine eşit olan sayılara orijinal sayı denir.
          1- Başla
          2- Kullanıcdan 4 basamaklı pozitif sayı iste
          3-eğer 4 basamaklı sayı ise 
             3.1- İlk iki basamak = sayi / 100
             3.2- Son iki basamak = sayi % 100
             3.3- Toplam = (ilk iki basamak + son iki basamak)
             3.4- Karesi = toplam * toplam
             3.5- Eğer (karesi == sayi) ise, o sayı orijinal sayıdır
             3.6- Bütün orijinal sayıları ekrana yazdır
          4- Bitir
           */

            int sayi;

            Console.WriteLine("4 basamaklı bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());


            int ilkIki, sonIki, toplam, kare;


            if (sayi < 1000 || sayi > 9999)
            {
                Console.WriteLine("Lütfen 4 basamaklı bir sayı giriniz!");
            }
            else
            {
                ilkIki = sayi / 100;
                sonIki = sayi % 100;
                toplam = ilkIki + sonIki;
                kare = toplam * toplam;

                if (kare == sayi)
                {
                    Console.WriteLine($"{sayi} orijinal sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{sayi} orijinal sayı değildir.");
                }
            }

            Console.ReadLine();
        }
    }
}
