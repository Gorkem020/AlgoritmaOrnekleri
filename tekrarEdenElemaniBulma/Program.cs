namespace tekrarEdenElemaniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir sayı dizisi içinde tekrar eden elemanları bulan bir algoritma yazın 
             1.Başla
             2.Bir sayı dizisi tanımla
             3.Bir döngü oluştur
             4.Dizideki bir elemanı diğerleriyle karşılaştır
             5.Eğer bu elemandan varsa ve daha önce yazdırılmadıysa o elemanı ekrana yazdır.
             6.Bitir
             */

            int[] sayilar = { 1, 5, 6, 0, 4, 8, 1, 0, 5, 6 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                bool tekrarivarmi = false;
                bool dahaönceyazildimi = false;
                for (int j = 0; j<i ; j++)
                {
                    if( sayilar[j] == sayilar[i])
                    {
                        dahaönceyazildimi=true;
                        break;
                    }
                }
                if (!dahaönceyazildimi) {
                    for (int k = i+1; k < sayilar.Length; k++)
                    {
                        if (sayilar[k] == sayilar[i])
                        {
                            tekrarivarmi=true;
                            break;
                        }
                    }
                    if (tekrarivarmi)
                    {
                        Console.WriteLine(sayilar[i]);
                    }
                }
            }
           
        }
    }
}
