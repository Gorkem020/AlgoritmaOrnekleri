namespace DinnerTimeAlgorithm
{
    internal class Program
    {
        /*
         1.başla
         2.10 elemanlı boş bir integer dizisi tanımla 
         3.Kaç tane olay olduğunu kullanıcıdan al
         4.Olayları kullanıcıdan al
         5.Olaylar dizisini oku.
           5.1. Eğer karakter L ise soldan ilk boş masayı(0) dolu(1) yap
           5.2. Eğer karakter R ise sağdan ilk boş masayı(0) dolu(1) yap
           5.3 Eğer karakter bir rakam ise dizinin o indeksini boş(0) yap
         6.Diziyi yazdır
         7.Bitir
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Dinner Time uygulamasına hoşgeldiniz");
            int[] tables = new int[10];

            Console.Write("Kaç tane olay olacak: ");
            int eventCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Olayları giriniz:");
            string events = Console.ReadLine();

            foreach (char olay in events)
            {
                if (olay == 'L')
                {
                    for(int i = 0; i < tables.Length; i++)
                    {
                        if (tables[i] == 0)
                        {
                            tables[i] = 1; 
                            break;
                        }
                    }
                }
                else if (olay == 'R')
                {
                    for (int i = tables.Length -1; i >= 0; i--)
                    {
                        if (tables[i] == 0)
                        {
                            tables[i] = 1;
                            break;
                        }
                    }
                }
                else if (char.IsDigit(olay))
                {
                    int index = olay - '0';
                    tables[index] = 0;
                }
            }

            foreach(int i in tables)
            {
                Console.Write(i);
            }
        }
    }
}
