namespace siralama_algoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* Bir dizinin elemanlarını küçükten büyüğe sıralayan algoritma
             1-Başla
             2-10 elemanlı bir dizi oluştur ve elemanları tekrar ata
             3-Bir döngü ile diziyi baştan sona tara
             4-Döngünün içinde bir başka döngü oluştur ve diziyi baştan sona tara
             4.1-Dizinin ilk elemanıyla ikinci elemanını karşılaştır
             4.2-Eğer ilk eleman ikinci elemandan büyükse, yer değiştir
             5-Sıralanmış diziyi yazdır
             6-Bitir

             
             */

            int[] dizi = { 34, 12, 5, 67, 23, 89, 1, 45, 78, 9 };

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 0; j < dizi.Length - 1 - i; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        // Yer değiştir
                        int temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                    }
                }
            }
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
        }
    }
}
