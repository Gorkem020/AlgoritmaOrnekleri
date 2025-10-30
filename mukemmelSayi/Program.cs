namespace mukemmelSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -Girilen sayının mükemmel sayı olup olmadığını bulan program(Bir sayının kendisi hariç bölenlerinin toplamının kendisine eşit olması. 6 -> 1 - 2 - 3 - 6 | 1+2+3 = 6)
             
             1- Başla.
             2- Kullanıcıdan bir sayı al.
             3- toplam adında bir değişken tanımla ve 0'a eşitle.
             4- bir döngü kur.
                4.1- döngünün içinde girilen sayıyı girilen sayıya kadar böl.
                4.2- eğer tam bölünüyorsa toplama ekle.
             5- eğer toplam sayıya eşitse sayı mükemmel sayıdır yazdır.
             6- değilse mükemmel sayı değildir yazdır.
             7- Bitir.
             */

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine(sayi + " sayısı mükemmel sayıdır");
            }
            else
            {
                Console.WriteLine("Sayı mükemmel değildir.");
            }
        }
    }
}
