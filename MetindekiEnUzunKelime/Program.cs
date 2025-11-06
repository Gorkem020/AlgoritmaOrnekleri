namespace MetindekiEnUzunKelime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir metin giriniz");
            string metin=Console.ReadLine();

            Console.WriteLine( " metindeki en uzun kelime: "+EnUzunKelimeBul(metin));
        }

        static string EnUzunKelimeBul(string metin)
        {
            string[] kelimeler = metin.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string max = kelimeler[0];
            for (int i = 1; i < kelimeler.Length; i++)
            {

                if (kelimeler[i].Length > max.Length)
                {
                    max = kelimeler[i];
                }
                

            }
            return max;
        }
    }
}
