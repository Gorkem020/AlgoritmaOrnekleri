namespace girilenSayilarinOrtalamasiniHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0, sayac = 0;
            int number;
            string answer;

            Console.WriteLine("Bir sayı giriniz :");
            number = Convert.ToInt32(Console.ReadLine());
            result += number;
            sayac++;

            while (true)
            {
                Console.WriteLine("Başka bir sayı girmek istiyor musunuz?");
                answer = Console.ReadLine();
                if (answer == "hayır" || answer == "HAYIR")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bir sayı giriniz :");
                    number = Convert.ToInt32(Console.ReadLine());
                    result += number;
                    sayac++;
                }

            }
            float ortalama = (float)result / sayac;
            Console.WriteLine("Ortalama = " + ortalama);

            /*
             * başla
             * toplam ve sayac = 0
             * 
             * sayıyı kullanıcıdan oku
             * toplama sayıyı ekle
             * sayacı 1 arttır
             * 
             * döngüyü başlat
             * ekrana "Başka bir sayı girmek istiyor musunuz?" yazdır
             * kullanıcıdan cevabı oku
             * eğer cevap hayır ise döngüden çık
             * evet ise döngüye devam et
             * sayıyı kullanıcıdan oku
             * toplama sayıyı ekle
             * sayacı 1 arttır
             * 
             * 
             * 
             * ortalama = toplam/sayac
             * 
             * yazdır ortalama
             * 
             * bitir
             *
             */
        }
    }
}
