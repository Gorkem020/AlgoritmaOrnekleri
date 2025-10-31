namespace gucluSayiBulmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 1-Başla
             * 2-Bir sayı girilmesini iste
             * 3-Toplam adında bir değişken tanımla.
             * 4-temp adında bir geçici değişken tanımla.
             * 5-geçici değişken 0'dan büyük olduğu sürece çalışacak bir döngü kur
             *  5.1-geçici değişkenin son basamğını al
             *  5.2-basamağın faktöriyel değereni al 
             *  5.3-toplama ekle.
             *  5.4-sayının son rakamını atmak için geçici değişkeni 10' a böl.
             * 6-Eğer toplam bizim orjinal sayımıza eşitse bu bir güçlü sayıdır yazdır.
             * 7-Değilse güçlü sayı değildir yazdır
             * 8-Bitir.
             */

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int temp = sayi;
            while (temp > 0)
            {
                int fakt = 1;
                int rakam = temp % 10;
                for (int i = 1; i <= rakam; i++)
                {
                    fakt = fakt * i;
                }
                toplam = fakt + toplam;

                temp = temp / 10;
            }
            if (toplam == sayi)
            {
                Console.WriteLine("Girilen sayı Güçlü sayıdır.");

            }
            else
            {
                Console.WriteLine("Girilen sayı Güçlü sayı değildir.");
            }

        }
    }
}
