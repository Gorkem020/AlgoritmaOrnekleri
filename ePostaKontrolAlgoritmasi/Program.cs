namespace ePostaKontrolAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen e posta adresinizi giriniz");
            string eposta = Console.ReadLine();

            if (eposta.Contains('@') && eposta.EndsWith(".com"))
            {

                Console.WriteLine($"e-posta adresiniz: {eposta}");
            }
            else
            {
                Console.WriteLine("geçersiz e_posta adresi");
            }
        }
    }
}

