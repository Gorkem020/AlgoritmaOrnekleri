namespace MaxMinYerDegistirme
{
    internal class Program
    {
        /*
         1.Başla
         2.Bir dizi tanımla ve içine birkaç sayı ekle
         3.max,min,maxİndex,minIndex değişkenlerini tanımla
         4. max ve min değişkenlerine dizinin ilk elemanını ata
         5.Döngü oluştur ve dizinin tüm elemanlarını kontrol et
            5.1.Eğer dizinin elemanı max'tan büyükse, max'ı güncelle ve maxIndex'i ata
            5.2.Eğer dizinin elemanı min'den küçükse, min'i güncelle ve minIndex'i ata
         6.maxIndex ve minIndex değerlerinin yerlerini değiştir
         7.Diziyi yazdır
         8.Bitir
         */
        static void Main(string[] args)
        {
            int[] dizi = { 34, 12, 5, 67, 23, 89, 1, 45 };
            int max = dizi[0];
            int min = dizi[0];

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1 ; i < dizi.Length; i++ )
            {
                if (dizi[i] < min)
                {
                    min = dizi[i];
                    minIndex = i;
                }

                if (dizi[i] > max)
                {
                    max = dizi[i];
                    maxIndex = i;
                }
            }

            int temp = dizi[maxIndex];
            dizi[maxIndex] = dizi[minIndex];
            dizi[minIndex] = temp;

            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
        }
    }
}
