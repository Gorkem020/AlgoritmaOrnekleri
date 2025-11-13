namespace theOldGoldMinerAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                başla
                kaç tane yığın olduğunu kullanıcıdan al
                her yığında kaç parça olduğunu kullanıcıdan al
                kaç altın olduğunu al
                altın sıralarını al
                hangi yığında olduğunu yazdır
                bitir
           */

            Console.WriteLine("Yığın Sayısı Giriniz");
            int yiginSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Parça Sayısını Giriniz");
            string[] parcaSayisi = Console.ReadLine().Split();
            int[] parcalar = new int[yiginSayisi];

            for (int i = 0; i < yiginSayisi; i++)
            {
                parcalar[i] = int.Parse(parcaSayisi[i]);
            }

            Console.WriteLine("Altın Sayısını Giriniz");
            int altinSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Altın Numaralarını Giriniz");
            string[] numaralar = Console.ReadLine().Split();
            int[] altinNumaralari = new int[altinSayisi];

            for(int i = 0;i < altinSayisi; i++)
            {
                altinNumaralari[i] = int.Parse(numaralar[i]);
            }

            // Altınların Bulunduğu Yığınlar =  [(1),2,3] - [4,5,6,7,8,9,10] - [(11),12,] - [12,13,14,15,16,17,18,19,20,21] - [22,23,24,25] - [26,27,(28),29,30,(31)]

            int[] yiginToplami = new int[yiginSayisi];
            yiginToplami[0] = parcalar[0];

            for (int i = 1; i < yiginSayisi; i++)

            {
                yiginToplami[i] = yiginToplami[i - 1] + parcalar[i];
            }

            foreach (var altin in altinNumaralari)
            {
                for (int i = 0; i < yiginSayisi; i++)
                {
                    if (altin <= yiginToplami[i])
                    {
                        Console.Write($" {i+1} ");

                        break;
                    }
                }
            }
        }
    }
}
