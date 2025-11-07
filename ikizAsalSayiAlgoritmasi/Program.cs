namespace ikizAsalSayiAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         * 1'den 1000'e kadar olan sayılar arasında ikiz asal (farkları 2 olan asal sayılar) çiftlerini bulun ve ekrana yazdırın. 
         * Ancak, toplam 10 çift bulduğunuzda döngüyü sonlandırın (break kullanarak). 
         * Asal olmayan sayıları atlayın (continue kullanarak).
         */

            Console.WriteLine("1-1000 Arası İkiz Asal Çiftleri");

            int ciftSayaci = 0;


            for (int n = 1; n <= 1000; n++)
            {

                if (!AsalMi(n))
                {
                    continue;
                }

                if (!AsalMi(n + 2))
                {
                    continue;
                }

                ciftSayaci++;
                Console.WriteLine($"Bulunan {ciftSayaci}. çift: ({n}, {n + 2})");

                if (ciftSayaci == 10)
                {
                    break;
                }
            }
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                return false;
            }
            if (sayi == 2)
            {
                return true;
            }
            if (sayi % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= sayi; i += 2)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
