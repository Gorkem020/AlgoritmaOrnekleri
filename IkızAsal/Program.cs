namespace IkızAsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İkiz Asallar Algoritmasına Hoşgeldiniz..");
            int max = 1000;

            List<int> liste = IkizAsalBul(max);

            Console.WriteLine($"{max} sayısına kadar olan ikiz asallar:");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> IkizAsalBul(int max) 
        {
            int kalan = 0;
            List<int> asallar = new List<int>();
            List<int> ikizAsallar = new List<int>();

            if (max < 0)
            {
                return ikizAsallar;
            }

            for (int i = 3; i < max; i++)
            {
                kalan = i % 2;
                if (kalan == 0)
                {
                    asallar.Add(i);
                }
            }

            for (int j = 0; j < asallar.Count - 2; j++)
            {
                if (asallar[j + 2] - asallar[j] == 2)
                {
                   ikizAsallar.Add(asallar[j]);
                   ikizAsallar.Add(asallar[j + 2]);
                }

                if (ikizAsallar.Count > 10) break;
            }

            return ikizAsallar;
        }
    }
}
